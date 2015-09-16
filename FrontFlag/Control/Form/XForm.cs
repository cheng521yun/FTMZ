using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control
{
    public partial class XForm : System.Windows.Forms.Form
    {
        string FullClassName = "FrontFlag.Control.XForm" ;

        public delegate void DLGTStr( string str );
        public DLGTStr dlgtShowMe = null;

        public delegate void DLGTCommand( UICOMMAND command );
        public DLGTCommand dlgtCommand = null;

        private string _strID = String.Empty;   //每个Form会有一个独立的ID编号。比如，通过点击菜单，传入一个FormID号，通过ID号可以找到并显示这个Form.

        protected List<XForm> _lstForm = new List<XForm>();

        public XForm()
        {
            InitializeComponent();
        }

        public XForm( string strID )
        {
            InitializeComponent();

            _strID = strID;
        }

        #region 属性

        public string ID 
        {
            set { _strID = value; }
            get { return _strID; }
        }

        public List<XForm> lstForm
        {
            get { return _lstForm; }
        }

        #endregion

        #region public
        
        public void SetParent(System.Windows.Forms.Control fParent, bool bShow)
        {
            TopLevel = false;
            Parent = fParent;
            Dock = DockStyle.Fill;

            if (bShow)
                Show();
        }

        public void SetParent(System.Windows.Forms.Control fParent)
        {
            SetParent(fParent, true);
        }

        public void SetParent( System.Windows.Forms.Control fParent, string strID )
        {
            _strID = strID;
            SetParent( fParent, true );
        }

        public void AddFormList( XForm fm )
        {
            _lstForm.Add( fm );
        }

        public void AddFormList( Type FormTypeName, string strMenuID )
        {
            //if ( FormTypeName.BaseType.FullName != FullClassName )
            //    return;

            XForm fm = System.Activator.CreateInstance( FormTypeName ) as XForm;

            fm.SetParent( this, strMenuID );
            AddFormList( fm );

            fm.dlgtShowMe = ShowWnd;  //调用ShowWnd( string strFoemID )
        }

        //private void ShowChild(string strFormId)
        //{

        //}

        /// <summary>
        /// 查找窗口ID编号，是（或是父窗口）就显示窗口。
        /// </summary>
        /// <param name="strFormID">窗口的唯一ID编号</param>
        /// <returns>true=比较结果为目标窗口（或父窗口）</returns>
        public void ShowWnd( string strFormID )
        {
            if (String.IsNullOrEmpty(strFormID.Trim()))
                return;

            bool bFind = false;

            HideAll();
            foreach ( XForm fm in _lstForm )
            {
                if (fm.ID == strFormID)
                {
                    bFind = true;
                    fm.ShowWnd();
                    break;
                }
            }

            //如果没有匹配的子窗口，则向上的递归显示就终止。
            if (!bFind)
                return;

            //
            ShowWnd();

            //
            ShowMe();

            return;
        }

        public void ShowWnd( string strFormID, UICOMMAND Command )
        {
            if ( String.IsNullOrEmpty( strFormID.Trim() ) )
                return ;

            if ( !strFormID.StartsWith( _strID ) )
            {
                Hide();
                return ;
            }

            foreach ( XForm fm in _lstForm )
            {
                fm.ShowWnd( strFormID, Command );
            }

            //
            ShowWnd();

            //窗口编号完全相同，则执行函数。（父窗口不执行）
            if ( _strID == strFormID && dlgtCommand != null )
                dlgtCommand( Command );

            return ;
        }

        public void HideAll()
        {
            foreach ( XForm fm in _lstForm )
            {
                fm.Hide();
            }
        }

        public void ShowMe()
        {
            Show();

            if ( dlgtShowMe != null )
            {
                dlgtShowMe( ID );
            }
        }

        #endregion

        #region virtual

        public virtual void ShowWnd()
        {
            //ShowChildForm( 0 );

            Show();
            
           // ShowMe();
        }

        protected virtual void InitForm()
        {

        }

        protected virtual void ExecuteCommand( UICOMMAND command )
        {
        }

        //protected virtual void ShowWnd( string strMenuID )
        //{
        //    //if ( Param.strPageNo == EntryPage.strPageNo )
        //    //    ShowWnd();
        //    //else
        //    //    Hide();
        //}

        #endregion

        #region Protected

        /// <summary>
        /// 取当前第一级子菜单序号
        /// </summary>
        /// <param name="strMenuID"></param>
        /// <returns></returns>
        //XForm GetChildFormByID( string strMenuID )
        //{
        //    int GradW = 2;

        //    int Len = strMenuID.Length;
        //    if ( Len < GradW )
        //        return null;

        //    return GetChild( strMenuID, 0 );
        //}

        protected void ShowChildForm(int No)
        {
            if (No < 0 || No >= _lstForm.Count)
                return;

            HideAll();

            XForm fm = _lstForm[No];
            fm.ShowWnd();
        }

        #endregion

        #region Private

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strMenuID">strMenuID="0102" 菜单编号</param>
        /// <param name="GradNo">[0,1,2,3...] 表示获取第几级菜单序号。 0=取主菜单，1,2,3...=取各级子菜单</param>
        /// <returns></returns>
        private XForm GetChild( string strMenuID, int GradNo )
        {
            int GradW = 2;                    //每个级别的菜单用两位数字表示。每个菜单下面的子菜单最多有99个。
            int MenuIDLen = GradNo * GradW;   //可以有效截取的菜单ID长度，小于这个长度则无效

            if ( strMenuID.Length < MenuIDLen )
                return null;

            string strSubID = strMenuID.Substring( GradNo, GradW );    //截取所需的子菜单序号。可能是主菜单序号，也可能是任意级别的子菜单序号
            int nSubID = FF.Fun.MyConvert.Str2Int( strSubID );

            nSubID -= 1;   //菜单从1起算。Form列表从0 起算。

            if ( nSubID < 0 || nSubID >= _lstForm.Count )
                return null;

            return _lstForm[ nSubID ];
        }

        private string GetNextGradMenu( string strMenuID )
        {
            int GradW = 2;

            int Len = strMenuID.Length;
            if ( Len < GradW )
                return String.Empty;

            //去除最左边的当前菜单ID。
            string strNextMenuID = strMenuID.Substring( GradW, Len - GradW );
            return strNextMenuID;
        }

        #endregion

    }
}
