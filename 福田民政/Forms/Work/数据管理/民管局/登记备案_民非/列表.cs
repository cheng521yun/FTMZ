using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.民管局.登记备案
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
                    new COLHEAD("ID","ID"),
                    new COLHEAD("备案日期",""),
                    new COLHEAD("机构名称",""),
                    new COLHEAD("法定代表",""),
                    new COLHEAD("固定联系人",""),
                    new COLHEAD("联系电话",""),
                    new COLHEAD("联系手机",""),
                    new COLHEAD("联系邮箱",""),
                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }

    }
}
