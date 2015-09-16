using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.DefCtrl
{
    public class CmbDropDown : System.Windows.Forms.ComboBox
    {
        protected void SetItem( string[] strsItem )
        {
            DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            FF.Ctrl.Combo.Strs2Combo_WithBlank( this, strsItem );
        }

    }
}
