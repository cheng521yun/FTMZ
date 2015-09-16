using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using FrontFlag.Control.Menu;

namespace 福田民政.Layout.LeftPnl
{
    public partial class XLeftPnl : XForm
    {
        protected List<XToolStripMenuItem> lstMenu = new List<XToolStripMenuItem>();


        public XLeftPnl()
        {
            InitializeComponent();
        }

        #region Event

        private void XLeftPnl_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        #endregion

        protected virtual void Init()
        {
        }

        void LoadForm()
        {
            Init();

            uc.Set(lstMenu); 
        }

        protected void Call( object obj )
        {
            App.fMain.bShowLeftPnl = true;
            ShowMe();
        }


    }
}
