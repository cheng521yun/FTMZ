using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control.UserCtrl
{
    public partial class XUserControl : UserControl
    {
        public XUserControl()
        {
            InitializeComponent();
        }

        public void SetParent( System.Windows.Forms.Control fParent, bool bShow )
        {
            //TopLevel = false;
            Parent = fParent;
            Dock = DockStyle.Fill;

            if ( bShow )
                Show();
        }

        public void SetParent( System.Windows.Forms.Control fParent )
        {
            SetParent( fParent, true );
        }
    }
}
