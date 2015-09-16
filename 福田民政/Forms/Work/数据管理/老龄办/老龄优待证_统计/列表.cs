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

namespace 福田民政.Forms.Work.数据管理.老龄办.老龄优待证_统计
{
    public partial class 列表 : XForm
    {
        List < DB.Stru.老龄办.敬老优待证统计 > _lst = new List<敬老优待证统计>();

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
                    new COLHEAD("街道办事处","街道"),
                    new COLHEAD("蓝证","蓝证"),
                    new COLHEAD("黄证","黄证"),
                    new COLHEAD("免费乘车证","免费乘车证"),
                    new COLHEAD("合计","合计"),
                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }

        public void 统计()
        {
            _lst = BL.老龄办.优待证.Get_统计();

            Fill();
        }

        void Fill()
        {
            fl.SortBindingList( _lst );
            fl.Refresh();

        }
    }
}
