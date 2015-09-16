using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;
using Global;
using 福田民政.Core;

namespace 福田民政.Layout
{
    public partial class FTopBar : XForm
    {
        public FTopBar()
        {
            InitializeComponent();
        }

        #region Event

        private void FTopBar_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        #endregion

        private void LoadForm()
        {
        }
    }
}
