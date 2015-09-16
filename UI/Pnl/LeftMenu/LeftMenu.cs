using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control.Menu;
using UI.Ctrl.Btn;

namespace UI.Pnl.LeftMenu
{
    public partial class LeftMenu : UserControl
    {
        public LeftMenu()
        {
            InitializeComponent();
        }

        private void LeftMenu1_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            this.BackColor = Def.Style.SysColor.LeftPnl_BK;
        }

        public void Set( List<XToolStripMenuItem> lstMenuItem )
        {
            int X = Def.Style.LeftBar.X0;
            int Y = Def.Style.LeftBar.Y0;

            foreach ( XToolStripMenuItem Item in lstMenuItem )
            {
                LeftMenuBtn btn = new LeftMenuBtn();
                btn.Set( Item.Text, Item.CommandId );
                this.Controls.Add( btn );

                btn.Location = new Point( X, Y );
                Y += Def.Style.LeftBar.JGV;
            }
        }
    }
}
