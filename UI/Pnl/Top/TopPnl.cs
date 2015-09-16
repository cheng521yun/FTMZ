using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Pnl.Top
{
    public partial class TopPnl : UserControl
    {
        public TopPnl()
        {
            InitializeComponent();
        }

        private void TopPnl_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            this.BackColor = Def.Style.SysColor.Main;
        }
    }
}
