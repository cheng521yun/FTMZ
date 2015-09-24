using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 福田民政.Forms.数据管理.福利中心.老人入住.Tab
{
    public partial class ButnTool : Form
    {
        public Def.dlgt.Act dlgtAdd = null;
        public Def.dlgt.Act dlgtDelete = null;

        public ButnTool()
        {
            InitializeComponent();

        }

        private void labAdd_Click( object sender, EventArgs e )
        {
            Add();
        }

        private void label2_Click( object sender, EventArgs e )
        {
            Delete();
        }

        private void Add()
        {
            if ( dlgtAdd != null )
                dlgtAdd();
        }

        private void Delete()
        {
            if (dlgtDelete != null)
                dlgtDelete();
        }
    }
}
