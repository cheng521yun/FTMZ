using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Ctrl.Btn
{
    public partial class btnFind : UserControl
    {
        public Def.dlgt.Act dlgtClickFind = null ;

        public btnFind()
        {
            InitializeComponent();
        }

        private void xImgButton1_Click( object sender, EventArgs e )
        {
            if (dlgtClickFind != null)
                dlgtClickFind();
        }


    }
}
