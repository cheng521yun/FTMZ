using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.事务科.救助统计
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
                    new COLHEAD("户数",""),
                    new COLHEAD("人数",""),
                    new COLHEAD("低保金",""),
                    new COLHEAD("燃气补贴",""),
                    new COLHEAD("小计",""),

                    new COLHEAD("养育扶助份数",""),
                    new COLHEAD("金额",""),
                    new COLHEAD("疾病数据宗数",""),
                    new COLHEAD("金额",""),
                    new COLHEAD("基本医疗报销",""),
                    new COLHEAD("按月份合计",""),
                    new COLHEAD("按季度合计",""),
                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }

    }
}
