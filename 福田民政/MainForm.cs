using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using FrontFlag.Control;
using 福田民政.Core;
using 福田民政.Layout;

namespace 福田民政
{
    public partial class MainForm : XForm
    {
        CCommand Command = new CCommand();

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event

        private void MainForm_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        #endregion

        private void LoadForm()
        {
            Layout();
            InitForm();

            CommandReady();

            StartForm();
        }

        private void Layout()
        {
            FTopBar fTopBar = new FTopBar();
            fTopBar.SetParent( pnlTop );

            FStatusBar fStatusBar = new FStatusBar();
            fStatusBar.SetParent( pnlBottom );
        }
    }
}
