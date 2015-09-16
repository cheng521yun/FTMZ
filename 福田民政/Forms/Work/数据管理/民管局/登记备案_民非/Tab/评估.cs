using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.民管局.登记备案.Tab
{
    public partial class 评估 : XForm
    {

        public 评估()
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
            //InitTool();
        }

   
        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("等级",""),
                    new COLHEAD("有效期",""),
                    new COLHEAD("变动日期",""),
                    new COLHEAD("变动原因",""),
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
            MessageBox.Show("Add");
        }

        private void Delete()
        {
            MessageBox.Show( "Delete" );
        }
    }
}
