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
    public partial class 社工岗位 : XForm
    {

        public 社工岗位()
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
                    new COLHEAD("序号",""),
                    new COLHEAD("领域",""),
                    new COLHEAD("社工人数",""),
                    new COLHEAD("社工机构",""),
                    new COLHEAD("个案",""),
                    new COLHEAD("结案",""),
                    new COLHEAD("建档",""),
                    new COLHEAD("小组活动",""),
                    new COLHEAD("社区活动",""),
                    new COLHEAD("家访",""),
                    new COLHEAD("即时辅导",""),
                    new COLHEAD("咨询",""),
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
            社工岗位_Edit fm = new 社工岗位_Edit();
            fm.ShowDialog();
        }

        private void Delete()
        {
            MessageBox.Show( "请先选择一条记录！" );
        }
    }
}
