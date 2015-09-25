using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.数据管理.福利中心.老人费用登记管理
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
                    new COLHEAD("用户代码",""),
                    new COLHEAD("老人名称",""),
                    new COLHEAD("银行帐号",""),
                    new COLHEAD("养老服务费",""),
                    new COLHEAD("老人伙食费	",""),
                    new COLHEAD("老人药费",""),
                    new COLHEAD("老人电费",""),
                    new COLHEAD("应收金额",""),
                    new COLHEAD("时间",""),

                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }

    }
}
