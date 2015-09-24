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
    public partial class 低保边缘户 : XForm
    {
        List<DB.Stru.事务科.专项救助_低保边缘户> _lst = new List<DB.Stru.事务科.专项救助_低保边缘户>();
        private string _strWhere = "";

        public 低保边缘户()
        {
            InitializeComponent();
        }

        private void 低保边缘户_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitList();
            InitTool();
            Find();
        }


        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("序号","序号"),
                    new COLHEAD("所属街道","所属街道"),
                    new COLHEAD("户主姓名","姓名"),
                    new COLHEAD("身份证","身份证"),
                    new COLHEAD("性别","性别"),
                    new COLHEAD("联系电话","联系电话"),
                    new COLHEAD("家庭成员","家庭成员"),
                    new COLHEAD("边缘证号","边缘证号"),
                    new COLHEAD("有效期","有效期"),
                    new COLHEAD("备注","备注"),
                } );

            fl.strIDCol = "ID";
        }

        private void InitTool()
        {
            //ButnTool fTool= new ButnTool();
            //Form f = (Form) fTool;
            //fl.AddFootPnl( ref f );

            //fTool.dlgtAdd = Add;
            //fTool.dlgtDelete = Delete;

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
            fl.MaxPage = BL.事务科.专项救助_低保边缘户.GetPageMax(strWhere);
            ShowPage(0);
        }

        void ShowPage(int nPageNo)
        {
            _lst = BL.事务科.专项救助_低保边缘户.GetPage(nPageNo, _strWhere); ;

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
