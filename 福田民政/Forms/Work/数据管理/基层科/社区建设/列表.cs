using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.基层科.社区建设
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

                    new COLHEAD("街道",""),
                    new COLHEAD("社区",""),
                    new COLHEAD("办公房",""),
                    new COLHEAD("党员活动室",""),
                    new COLHEAD("社区警务室",""),
                    new COLHEAD("人民调解室",""),
                    new COLHEAD("社区健康服务中心","",120),
                    new COLHEAD("社区图书室",""),
                    new COLHEAD("星光老年之家",""),
                    new COLHEAD("户外文体广场",""),
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
