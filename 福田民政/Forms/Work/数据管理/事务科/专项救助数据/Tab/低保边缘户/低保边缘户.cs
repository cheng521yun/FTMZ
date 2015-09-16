using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.事务科.临时救助.Tab
{
    public partial class 低保边缘户 : XForm
    {

        public 低保边缘户()
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
                    new COLHEAD("所属街道",""),
                    new COLHEAD("户主姓名",""),
                    new COLHEAD("身份证",""),
                    new COLHEAD("性别",""),
                    new COLHEAD("联系电话",""),
                    new COLHEAD("家庭成员",""),
                    new COLHEAD("边缘证号",""),
                    new COLHEAD("有效期",""),
                    new COLHEAD("备注",""),
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
