using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 福田民政.Forms.Work.数据管理.老龄办.Comm
{
    public partial class SelectType : Form
    {
        public SelectType()
        {
            InitializeComponent();
        }

        public string Type
        {
            get { return cmbType.Text; }
        }

        private void SelectType_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            cmbType.SelectedIndex = 0;
        }
    }
}
