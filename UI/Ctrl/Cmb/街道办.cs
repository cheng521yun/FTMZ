using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag;

namespace UI.Ctrl.Cmb
{
    public partial class 街道办 : UserControl
    {
        public 街道办()
        {
           InitializeComponent();
        }

        #region 属性

        public bool bShow工作站
        {
            set { cmb工作站.Visible = value; }
        }

        public string str街道办
        {
            set { FF.Ctrl.Combo.SetSelectText( cmb街道办, value ); }
            get { return cmb街道办.Text; }
        }

        public string str工作站
        {
            set { FF.Ctrl.Combo.SetSelectText( cmb工作站, value ); }
            get { return cmb工作站.Text; }
        }

        #endregion

        #region Event

        private void 街道办_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void cmb街道办_SelectedIndexChanged( object sender, EventArgs e )
        {
            Select街道办();
        }

        #endregion

        private void LoadForm()
        {
            FF.Ctrl.Combo.Strs2Combo( cmb街道办, Def.Strs.Comm.所属街道.街道办 );
        }

        private void Select街道办()
        {
            string str街道办 = cmb街道办.Text;
            string[] strs工作站 = Def.Strs.Comm.所属街道.Get工作站( str街道办 );

            FF.Ctrl.Combo.Strs2Combo( cmb工作站, strs工作站 );
        }

    }
}
