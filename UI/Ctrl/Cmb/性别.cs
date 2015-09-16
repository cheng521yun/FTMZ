using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.Ctrl.Cmb
{
    public class 性别 : System.Windows.Forms.ComboBox
    {
        string[] strs = new[] {"男", "女"};

        public 性别()
        {
            if ( this.DesignMode ) return;

            FF.Ctrl.Combo.Strs2Combo_WithBlank( this, strs );
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();

            
        //}

        public string Value
        {
            set
            {
                string str = ( Value == "True" ) ? "男" : "女";
                FF.Ctrl.Combo.SetSelectText( this, str );
            }
            get
            {
                string str = this.Text;
                return (str == "男") ? "True" : "False";
            }
        }
    }
}
