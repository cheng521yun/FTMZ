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

namespace 福田民政.Forms.技术支持
{
    public partial class 问题反馈 : XForm
    {
        public 问题反馈()
        {
            InitializeComponent();
        }

        private void 问题反馈_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Act.Entry_技术支持_问题反馈 += Call;
        }

        private void Call( object obj )
        {
            //MessageBox.Show( "in 老龄办" );

            ShowMe();
        }
    }
}
