using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag;
using FrontFlag.Control;
using Buss;

namespace 福田民政.Forms.Comm.人员
{
    public partial class F查找人员 : UI.Dlg.CommDlg
    {
        List<DB.Stru.人员> _lst人员 = new List<DB.Stru.人员>() ;
        DB.Stru.人员 _struSel = new DB.Stru.人员();

        private string _strWhere = String.Empty;


        public F查找人员()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.人员 stru
        {
            get { return _struSel; }
        }

        #endregion

        override protected void InitForm()
        {
            Caption = "查找人员";

            InitFind();
            InitList();
        }

        protected override void OK()
        {
            if (_struSel.IsNotValid())
            {
                FF.Ctrl.MsgBox.ShowWarn( Def.Str.Msg.必须选择记录 );
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void InitFind()
        {
            查找人员_Find fFind = new 查找人员_Find();
            Form f = (Form) fFind;
            fl.AddFindPnl( ref f );

            fFind.dlgtFind = Find;
            //fFind.dlgtAddNew = AddNew;

            //Def.Act.Comm.人员.新加 += Call新加人员;
            //Def.CommandId_Act.SetAct(Def.Act.Comm.人员.新加, Call新加人员);
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("身份证号码","身份证"),
                    new COLHEAD("姓名","姓名"),
                    new COLHEAD("性别","性别"),
                    new COLHEAD("电话","电话"),
                    new COLHEAD("手机","联系手机"),
                    new COLHEAD("地址","地址"),
                } );

            fl.strIDCol = "ID";

            fl.OnShowPage = ShowPage;
            fl.OnSelectionChanged = SelectChange;
        }

        void Find( string strWhere )
        {
            _strWhere = strWhere;

            //设置翻页的数码。
            fl.MaxPage = BL.人员.GetPageMax( strWhere );
            ShowPage( 0 );
        }

        void ShowPage( int nPageNo )
        {
            _lst人员 = BL.人员.GetPage( nPageNo, _strWhere ); ;

            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList( _lst人员 );
            fl.Refresh();
        }

        void SelectChange( int nRow )
        {
            if ( nRow < 0 )
                return;

            _struSel = fl.grd.Rows[ nRow ].DataBoundItem as DB.Stru.人员;
        }

        //private void Call新加人员( object obj )
        //{
        //    F添加人员 fm = new F添加人员();
        //    if ( fm.ShowDialog() != DialogResult.OK )
        //        return;

        //}
    }
}
