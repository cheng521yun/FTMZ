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
using 福田民政.Forms.Work.数据管理.事务科.低收入居民数据.Tab.发放记录;

namespace 福田民政.Forms.Work.数据管理.事务科.社会救助.Tab
{
    public partial class 发放记录 : XForm
    {
        List<DB.Stru.事务科.低收入居民_发放记录> _lst = new List<DB.Stru.事务科.低收入居民_发放记录>();
        private string _strWhere = "";

        public 发放记录()
        {
            InitializeComponent();
        }

        private void 发放记录_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitList();
            InitTool();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("审批时间","审批时间Str"),
                    new COLHEAD("待遇有效期截止时间","待遇截止日期Str",300),
                    new COLHEAD("接收人","接收人"),
                    new COLHEAD("低保证号","低保证号"),
                    new COLHEAD("发放年月","发放年月"),
                    new COLHEAD("发放类型","发放类型"),
                } );

            fl.strIDCol = "ID";
        }
        public void Find()
        {
            Find(String.Empty);
        }

        public void Find(string strWhere)
        {
            //if ( strWhere == _strWhere )
            //    return;

            _strWhere = strWhere;

            //设置翻页的数码。
            fl.MaxPage = BL.事务科.低收入居民_发放记录.GetPageMax(strWhere);
            ShowPage(0);
        }

        void ShowPage(int nPageNo)
        {
            _lst = BL.事务科.低收入居民_发放记录.GetPage(nPageNo, _strWhere); ;

            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList(_lst);
            fl.Refresh();

        }

        private void InitTool()
        {
            ButnTool fTool= new ButnTool();
            Form f = (Form) fTool;
            fl.AddFootPnl( ref f );

            fTool.dlgtAdd = Add;
            fTool.dlgtDelete = Delete;

        }

        private void Add()
        {
            //MessageBox.Show("Add");
            Edit fm = new Edit();
            fm.ShowDialog();
        }

        private void Delete()
        {
            Edit fm = new Edit();
            fm.Delete(fl.strSelectID);
        }
        
    }
}
