using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using DB.Stru.事务科;
using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.事务科.低收入居民数据;

namespace 福田民政.Forms.Work.数据管理.事务科.社会救助
{
    public partial class 列表 : XForm
    {
        List<DB.Stru.事务科.低收入居民> _lst = new List<低收入居民>();
        private string _strWhere = String.Empty;

        public 列表()
        {
            InitializeComponent();
        }

        private void 列表_Load( object sender, EventArgs e )
        {
            InitForm();
        }

        private void InitForm()
        {
            InitList();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("类别","类别"),
                    new COLHEAD("户主姓名","户主姓名"),
                    new COLHEAD("性别","性别Str"),
                    new COLHEAD("年龄","年龄"),
                    new COLHEAD("身份证","身份证"),
                    new COLHEAD("通讯住址","通讯住址"),
                    new COLHEAD("所属社区","所属社区"),
                    new COLHEAD("电话号码","电话号码"),
                    new COLHEAD("银行帐号","银行帐号"),
                } );

            fl.strIDCol = "ID";

            fl.OnShowPage = ShowPage;
            fl.OnDBClickCell = Modify;
            fl.OnSelectionChanged = SelectChange;

            Fun.List.SetCommStyle( fl, "数据管理_事务科_社会救助_列表" );
        }

        public void Find()
        {
            Find( String.Empty );
        }

        public void Find( string strWhere )
        {
            _strWhere = strWhere;

            //设置翻页的数码。
            fl.MaxPage = BL.事务科.低收入居民.GetPageMax( strWhere );
            ShowPage( 0 );
        }

        void ShowPage( int nPageNo )
        {
            _lst = BL.事务科.低收入居民.GetPage( nPageNo, _strWhere ); ;

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

            DB.Stru.事务科.低收入居民 struSel = fl.grd.Rows[ nRow ].DataBoundItem as DB.Stru.事务科.低收入居民;
            if ( struSel == null )
                return;

            事务科.低收入居民数据.FEdit fm = new FEdit();
            fm.stru = struSel;
            if ( fm.ShowDialog() != DialogResult.OK )
                return;

            if ( fm.stru.ID == "" )   //delete
                _lst.RemoveAt( nRow );
            else    //modify
                _lst[ nRow ] = fm.stru;

            Fill();
        }

        void SelectChange(int nRow)
        {
            DB.Stru.事务科.低收入居民 rowobject = fl.GetSelected(nRow) as DB.Stru.事务科.低收入居民;
            string id = rowobject.ID;

            if (string.IsNullOrEmpty(id))
                return;

            Tab.家庭成员 家庭成员 = new Tab.家庭成员();
            家庭成员.Find("父ID=" + id);

        }

    }
}
