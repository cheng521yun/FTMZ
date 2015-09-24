using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.事务科.居家养老服务补贴
{
    public partial class Find : XForm
    {
        public Def.dlgt.Act dlgtAdd = null;

        public Find()
        {
            InitializeComponent();
        }

        private void Find_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            btnAdd.dlgtRun = AddNew;
        }

        private void AddNew()
        {
            if (dlgtAdd != null)
                dlgtAdd();
        }
        
    }
}
