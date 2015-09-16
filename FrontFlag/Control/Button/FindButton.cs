using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Test;

namespace FrontFlag.Control.Button
{
    public partial class XFindButton : UserControl
    {
        public delegate void DELE_NoParam();
        public DELE_NoParam delgFind = null;

        public enum FINDMODE
        {
            精确查询 = 1,
            首字符匹配 = 2,
            模糊查询 = 3,
            忽略特殊字符 = 4
        } ;

        private string _strIgnoreChar = String.Empty;

        #region 属性

        private FINDMODE _FindeMode = FINDMODE.精确查询;

        public FINDMODE FindeMode
        {
            get { return _FindeMode; }
        }

        public string strIgnoreChar
        {
            set { _strIgnoreChar = value; } 
        }

        #endregion 


        public XFindButton()
        {
            InitializeComponent();
        }

        #region Event

        private void XFindButton_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void OnlabModeClick(object sender, EventArgs e)
        {
            menuFind.Show(labMode, new Point(0, labMode.Size.Height));
        }

        private void menu_JQ_Click(object sender, EventArgs e)
        {
            SetMode(1);
        }

        private void menu_FIx_Click(object sender, EventArgs e)
        {
            SetMode(2);
        }

        private void menu_MH_Click(object sender, EventArgs e)
        {
            SetMode(3);
        }

        private void menu_HL_Click( object sender, EventArgs e )
        {
            SetMode(4);
        }

        private void OnlabModeEnter(object sender, EventArgs e)
        {
            SetLabColor(Color.Brown);
        }

        private void OnlabModeLeave(object sender, EventArgs e)
        {
            SetLabColor(Color.Black);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (delgFind != null)
                delgFind();
        }

        #endregion

        void LoadForm()
        {
            //默认首字符匹配。
            SetMode(2);
        }

        void SetMode ( int nMode )
        {
            if ( nMode ==1 )
            {
                _FindeMode = FINDMODE.精确查询;
                labMode.Text = "=";
            }
            else if (nMode == 2)
            {
                _FindeMode = FINDMODE.首字符匹配;
                labMode.Text = "=≈";
            }
            else if (nMode == 3)
            {
                _FindeMode = FINDMODE.模糊查询;
                labMode.Text = "≈";
            }
            else if ( nMode == 4 )
            {
                _FindeMode = FINDMODE.忽略特殊字符;
                labMode.Text = "≈≈";
            }
        }

        void SetLabColor ( Color clr )
        {
            labMode.ForeColor = clr;
        }

        //public void Test ()
        //{
        //    strIgnoreChar = "! @ # $ % ^ & * ( ) _ +";
        //    //txtIgnoreChar.Text = ORM.System.GetValue_ByName( DEF.Tab.System.IgnoreCharOfFind );
        //}

        public string GetCause(string strFld, string strValue)
        {
            if (String.IsNullOrEmpty(strValue) )
                return String.Empty;

            string strRet = "";

            if ( _FindeMode == FINDMODE.首字符匹配 )
                strRet = String.Format( "( {0} like '{1}%' )", strFld, strValue );

            else if ( _FindeMode == FINDMODE.模糊查询 )
                strRet = String.Format( "( {0} like '%{1}%' )", strFld, strValue );

            else if ( _FindeMode == FINDMODE.忽略特殊字符 )
                strRet = CreateReplaceStr( strFld, strValue, _strIgnoreChar );

            else //默认都是精确查询
                strRet = String.Format( "( {0} = '{1}' )", strFld, strValue );

            return strRet;
        }

        /// <summary>
        /// 把指定字段里的特殊字符全部清除掉（替换为''）
        /// </summary>
        /// <param name="strFld"></param>
        /// <param name="strValue"></param>
        /// <param name="strReplaceChar"></param>
        /// <returns></returns>
        string CreateReplaceStr ( string strFld, string strValue, string strReplaceChar )
        {
            string strRetDefault = String.Format( "( {0} like '%{1}%' )", strFld, strValue );
            string strRet = String.Empty;

            string[] strs = strReplaceChar.Split(new char[] {' '});   //使用空格分隔
            if ( strs == null || strs.Length <= 0 )
                return strRetDefault;

            List<string> lstStr = new List<string>();
            string strUnit = String.Empty;
            foreach (var str in strs)
            {
                if ( String.IsNullOrEmpty( str.Trim() ) )
                    continue;

                if ( String.IsNullOrEmpty( strUnit ) )
                    strUnit = string.Format( "REPLACE({0}, '{1}', '') ", strFld, str );
                else
                {
                    strUnit = string.Format( "REPLACE({0}, '{1}', '') ", strUnit, str );
                }
            }

            if ( string.IsNullOrEmpty( strUnit ) )
                return strRetDefault;

            strRet = string.Format( "{0} like '%{1}%'", strUnit, strValue  );
            return strRet;
        }
    }
}
