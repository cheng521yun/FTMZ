using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.数据管理.福利中心.老人费用_退费
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
                    new COLHEAD("姓名","姓名"),
                    new COLHEAD("入住押金","入住押金"),
                    new COLHEAD("医疗保证金","医疗保证金"),
                    new COLHEAD("老人服务费","老人服务费"),
                    new COLHEAD("伙食费","伙食费"),
                    new COLHEAD("药费","药费"),
                    new COLHEAD("电费","电费"),
                    new COLHEAD("银行帐号","银行帐号"),
                    new COLHEAD("备注","备注"),
                    new COLHEAD("时间","时间")

                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }

    }
}
