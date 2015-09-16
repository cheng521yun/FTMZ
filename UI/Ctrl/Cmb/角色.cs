using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.Ctrl.Cmb
{
    public class 角色 : System.Windows.Forms.ComboBox
    {
        public 角色()
        {
            if ( this.DesignMode ) return;

            FF.Ctrl.Combo.Strs2Combo_WithBlank( this, Def.Strs.职员.角色 );
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();

        //}
    }
}
