using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.DefCtrl
{
    public class CmbList : System.Windows.Forms.ComboBox
    {
        protected void SetItem( string[] strsItem )
        {
            FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            Items.Clear();
            FF.Ctrl.Combo.Strs2Combo_WithBlank( this, strsItem );
        }

    }
}
