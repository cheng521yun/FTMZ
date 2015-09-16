using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.基层科.社区服务.Tab
{
    public partial class 社区公益服务 : XForm
    {
        public 社区公益服务()
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
                    new COLHEAD("街道名称",""),
                    new COLHEAD("已开展服务项目（项）","",200),
                    new COLHEAD("已开展服务的社区（个）","",200),
                    new COLHEAD("未开展服务的社区（个）","",200),
                    new COLHEAD("参与服务人数",""),
                    new COLHEAD("已发生费用",""),

                } );

            fl.strIDCol = "ID";
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
            社区公益服务Edit fm = new 社区公益服务Edit();
            fm.ShowDialog();
        }

        private void Delete()
        {
            MessageBox.Show( "请先选择一条记录！" );
        }
    }
}
