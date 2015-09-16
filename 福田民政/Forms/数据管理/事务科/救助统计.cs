using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Def.Delegate;
using FrontFlag.Control;

namespace 福田民政.Forms.数据管理.事务科
{
    public partial class 救助统计 : XForm
    {
        public 救助统计()
        {
            InitializeComponent();
        }

        private void 社会救助_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Act.Entry_数据管理_事务科_救助统计 += Call;
        }

        private void Call( object obj )
        {
            ShowMe();
        }
    }
}
