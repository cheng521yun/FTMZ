using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Global;

namespace UI.Pnl.Status
{
    public partial class StatusPnl : UserControl
    {
        public StatusPnl()
        {
            InitializeComponent();
        }

        private void StatusPnl_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            this.BackColor = Def.Style.SysColor.Main;

            GetVersion();
        }

        private void GetVersion()
        {
            string strVer = String.Format( "当前版本是 {0}.{1}", GL.Version.nMain, GL.Version.nSub );
            labVersion.Text = strVer;
        }
    }
}
