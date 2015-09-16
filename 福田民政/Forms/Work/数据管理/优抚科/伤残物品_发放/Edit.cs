using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI.Dlg;

namespace 福田民政.Forms.Work.数据管理.优抚科.伤残物品_发放
{
    public partial class Edit : EditDlg
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Caption = "伤残物品 发放";
        }
    }
}
