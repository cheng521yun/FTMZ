using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using UI.Dlg;

namespace 福田民政.Forms.Work.数据管理.优抚科.优抚资金发放
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
            Caption = "优抚资金 发放";
        }
    }
}
