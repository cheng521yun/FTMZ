using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.基层科.民主管理
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
                    new COLHEAD("居委会名称",""),
                    new COLHEAD("所属街道",""),
                    new COLHEAD("办公电话",""),
                    new COLHEAD("居委会地址",""),
                    new COLHEAD("人口数",""),
                    new COLHEAD("面积",""),
                    new COLHEAD("辖区范围",""),
                    new COLHEAD("组织机构代码",""),
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
