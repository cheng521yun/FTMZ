using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control.PickerDate;

namespace FrontFlag.Control
{
    public partial class XGroupBox : System.Windows.Forms.GroupBox
    {
        //设置权限
        POPEDOM Popedom = new POPEDOM (); 

        public XGroupBox ()
        {
            InitializeComponent ();
        }

        protected override void OnPaint ( PaintEventArgs pe )
        {
            base.OnPaint ( pe );
        }

        #region 属性

        /// <summary>
        /// 设置权限
        /// </summary>
        public Byte PByte
        {
            set { Popedom.Byte = value; }
        }

        public FUN.POPEDOMBYTE PopedomByte
        {
            set { Popedom.PopedomByte = value; }
            get { return Popedom.PopedomByte; }
        }

        #endregion

        public void SetChildPopedom ( string strCtrlName , byte p )
        {
            foreach ( System.Windows.Forms.Control ctrl in this.Controls )
            {
                if ( strCtrlName == ctrl.Name )
                {
                    if (ctrl is XButton)
                    {
                        XButton c = ctrl as XButton;
                        c.PByte = p;

                    }
                    else if (ctrl is XTextBox)
                    {
                        XTextBox c = ctrl as XTextBox;
                        c.PByte = p;

                    }
                    else if (ctrl is XComboBox)
                    {
                        XComboBox c = ctrl as XComboBox;
                        c.PByte = p;

                    }
                    else if (ctrl is XDatePicker)
                    {
                        XDatePicker c = ctrl as XDatePicker;
                        c.PByte = p;

                    }
                }
            }
        }

    }
}
