using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI.Dlg;

namespace 福田民政.Forms.Work.数据管理.民管局.登记备案_民非.Edit
{
    public partial class Edit : CommDlg
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
            Caption = "机构信息 民非";

            SetChild(uc);
        }
    }
}
