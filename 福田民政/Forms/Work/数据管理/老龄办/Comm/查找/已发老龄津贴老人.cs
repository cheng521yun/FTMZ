using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DB.Stru.老龄办;
using FrontFlag;
using FrontFlag.Control;
using Buss;

namespace 福田民政.Forms.Work.数据管理.老龄办.Comm.查找
{
    public partial class 已发老龄津贴老人 : UI.Dlg.CommDlg
    {
        List<DB.Stru.老龄办.发放老龄津贴> _lst = new List<发放老龄津贴>();
        DB.Stru.老龄办.发放老龄津贴 _struSel = new DB.Stru.老龄办.发放老龄津贴();

        private string _strWhere = String.Empty;


        public 已发老龄津贴老人()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.老龄办.发放老龄津贴 stru
        {
            get { return _struSel; }
        }

        #endregion

        override protected void InitForm()
        {
            Caption = "查找已经发放老龄津贴的老人";

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
            已发老龄津贴老人_Find fFind = new 已发老龄津贴老人_Find();
            Form f = (Form) fFind;
            fl.AddFindPnl( ref f );

            fFind.dlgtFind = Find;
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("接收人","接收人"),
                    new COLHEAD("身份证号码","身份证"),
                    new COLHEAD("出生日期","出生日期"),
                    new COLHEAD("街道","街道"),
                    new COLHEAD("领取时间","领取时间"),
                    new COLHEAD("类别","类别"),
                    new COLHEAD("银行账号","银行账号"),
                    
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
            _lst = BL.老龄办.发放老龄津贴.GetPage( nPageNo, _strWhere ); ;

            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList( _lst );
            fl.Refresh();
        }

        void SelectChange( int nRow )
        {
            if ( nRow < 0 )
                return;

            _struSel = fl.grd.Rows[ nRow ].DataBoundItem as DB.Stru.老龄办.发放老龄津贴;
        }

    }
}
