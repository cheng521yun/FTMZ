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

namespace 福田民政.Forms.数据分析.福利中心
{
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        private void Wnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }
        private void LoadForm()
        {
            Act.Entry_数据分析_福利中心 += Call;
        }

        private void Call( object obj )
        {
            ShowMe();
        }
    }
}
