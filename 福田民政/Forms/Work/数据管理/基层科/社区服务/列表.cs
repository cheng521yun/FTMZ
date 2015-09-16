using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.基层科.社区服务
{
    public partial class 列表 : XForm
    {
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
                    new COLHEAD("序号",""),
                    new COLHEAD("街道",""),
                    new COLHEAD("社区服务中心",""),
                    new COLHEAD("管理人员",""),
                    new COLHEAD("专业社工",""),
                    new COLHEAD("辅助人员",""),
                    new COLHEAD("个案",""),
                    new COLHEAD("结案",""),
                    new COLHEAD("建档",""),
                    new COLHEAD("小组活动",""),
                    new COLHEAD("社区活动",""),
                    new COLHEAD("家访",""),
                    new COLHEAD("即时辅导",""),
                    new COLHEAD("咨询",""),
                    new COLHEAD("服务机构",""),


                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }

        public void ExcelIn()
        {
            string strTmp = Fun.Comm.GetExcelFile();
        }

        public void ExcelOut()
        {
            string strTmp = Fun.Comm.GetExcelFile();
        }

    }
}
