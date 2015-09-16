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

namespace 福田民政.Layout.LeftPnl
{
    public partial class 技术支持 : XForm
    {
        public 技术支持()
        {
            InitializeComponent();
        }

        private void 事务科_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            //Act.Entry_事务科 += Call;
        }

        private void Call( object obj )
        {
            ShowMe();
        }
    }
}
