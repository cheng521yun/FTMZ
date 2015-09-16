using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.基层科.民主管理.Tab
{
    public partial class 选举结果 : XForm
    {

        public 选举结果()
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
                    new COLHEAD("街道（办事处）","",120),
                    new COLHEAD("本级社区居委会数","",160),
                    new COLHEAD("需要换届选举的社区居委会数","",200),
                    new COLHEAD("社区综合党组织班子总职数","",200),
                    new COLHEAD("社区居委会班子总职数","", 200),
                    new COLHEAD("总数",""),
                } );

            fl.strIDCol = "ID";

            //fl.OnDBClickCell = Modify;
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
            选举结果_Edit fm = new 选举结果_Edit();
            fm.ShowDialog();
        }

        private void Delete()
        {
            MessageBox.Show( "请先选择一条记录！" );
        }
    }
}
