using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.事务科.临时救助.Tab
{
    public partial class 意外或其他救助 : XForm
    {
        List<DB.Stru.事务科.专项救助_意外救助> _lst = new List<DB.Stru.事务科.专项救助_意外救助>();
        private string _strWhere = "";

        public 意外或其他救助()
        {
            InitializeComponent();
        }

        private void 成员信息_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitList();
            //InitTool();
            Find();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("序号","序号"),
                    new COLHEAD("所属街道","所属街道"),
                    new COLHEAD("姓名","姓名"),
                    new COLHEAD("性别","性别"),
                    new COLHEAD("联系电话","联系电话"),
                    new COLHEAD("救助原因","救助原因"),
                    new COLHEAD("金额（元）","金额"),
                    new COLHEAD("救助时间","救助时间"),
                    new COLHEAD("类别","类别"),
                    new COLHEAD("备注","备注"),
                } );

            fl.strIDCol = "ID";
        }
                

        private void Add()
        {
            MessageBox.Show("Add");
        }

        private void Delete()
        {
            MessageBox.Show( "Delete" );
        }

        public void Find()
        {
            Find(String.Empty);
        }

        public void Find(string strWhere)
        {
            _strWhere = strWhere;

            //设置翻页的数码。
            fl.MaxPage = BL.事务科.专项救助_意外救助.GetPageMax(strWhere);
            ShowPage(0);
        }

        void ShowPage(int nPageNo)
        {
            _lst = BL.事务科.专项救助_意外救助.GetPage(nPageNo, _strWhere); ;

            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList(_lst);
            fl.Refresh();

        }
    }
}
