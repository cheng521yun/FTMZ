using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using DB.Stru.老龄办;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_停发
{
    public partial class 列表 : XForm
    {
        private List<DB.Stru.老龄办.停发老龄津贴> _lst = new List<停发老龄津贴>();
        private string _strWhere = "-1";

        public 列表()
        {
            InitializeComponent();
        }

        private void fl_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitList();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("所属街道","街道"),
                    new COLHEAD("姓名","姓名"),
                    new COLHEAD("身份证","身份证"),
                    new COLHEAD("停发日期","停发日期Str"),
                    new COLHEAD("原因","停发原因"),
                    new COLHEAD("操作日期","CreateDateStr"),
                    new COLHEAD("操作人","Creator"),
                } );


            fl.strIDCol = "ID";

            fl.OnShowPage = ShowPage;
            fl.OnDBClickCell = Modify;
        }

        public void Find()
        {
            Find( String.Empty );
        }

        public void Find( string strWhere )
        {
            //if ( strWhere == _strWhere )
            //    return;

            _strWhere = strWhere;

            //设置翻页的数码。
            fl.MaxPage = BL.老龄办.停发老龄津贴.GetPageMax( strWhere );
            ShowPage( 0 );
        }

        void ShowPage( int nPageNo )
        {
            _lst = BL.老龄办.停发老龄津贴.GetPage( nPageNo, _strWhere ); ;

            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList( _lst );
            fl.Refresh();

        }

        void Modify( int nRow, int nCol )
        {
            if ( nRow < 0 || nRow >= _lst.Count )
                return;

            DB.Stru.老龄办.停发老龄津贴 struSel = fl.grd.Rows[ nRow ].DataBoundItem as DB.Stru.老龄办.停发老龄津贴;
            if ( struSel == null )
                return;

            FEdit fm = new FEdit();
            fm.stru = struSel;
            if ( fm.ShowDialog() != DialogResult.OK )
                return;

            if ( fm.stru.ID == "" )   //delete
                _lst.RemoveAt( nRow );
            else    //modify
                _lst[ nRow ] = fm.stru;

            //Refreah
            //Fill();
            Find();
        }
    }
}
