using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag;

namespace UI.Ctrl.TextBox
{
    public class NumberTextBox : System.Windows.Forms.TextBox
    {
        public NumberTextBox()
        {
        }

        //public override string Text
        //{
        //    get
        //    {
        //        string str = base.Text;
        //        int n = FF.Fun.MyConvert.Str2Int(str);
        //        return n.ToString(); 
                
        //    }
        //    set 
        //    {
        //        int n = FF.Fun.MyConvert.Str2Int( value );
        //        base.Text = n.ToString();
        //    }
        //}

        protected override void OnTextChanged( EventArgs e )
        {
            base.OnTextChanged( e );

            string str = base.Text;
            int n = FF.Fun.MyConvert.Str2Int( str );
            base.Text = n.ToString();
        }
    }
}
