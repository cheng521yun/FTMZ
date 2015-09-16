using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Pnl.CaptionBar
{
    public partial class CaptionBar : UserControl
    {
        public CaptionBar()
        {
            InitializeComponent();
        }

        public void ShowCaption(string strCaptionText )
        {
            labCaption.Text = strCaptionText;
        }
    }
}
