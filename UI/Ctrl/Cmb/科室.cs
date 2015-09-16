using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Def.Const;
using FrontFlag;

namespace UI.Ctrl.Cmb
{
    public class 科室 : System.Windows.Forms.ComboBox
    {

        public 科室()
        {
            if ( this.DesignMode ) return;

            FF.Ctrl.Combo.Strs2Combo_WithBlank( this, Def.Strs.职员.科室 );
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();

           
        //}

    }
}
