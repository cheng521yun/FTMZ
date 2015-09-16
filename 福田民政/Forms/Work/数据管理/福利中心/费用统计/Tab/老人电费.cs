using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.数据管理.福利中心.费用统计.Tab
{
    public partial class 老人电费 : XForm
    {

        public 老人电费()
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
            InitTool();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("统计月份",""),
                    new COLHEAD("金额",""),
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
    }
}
