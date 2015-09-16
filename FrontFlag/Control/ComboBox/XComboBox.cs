using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control
{
    public partial class XComboBox : System.Windows.Forms.ComboBox 
    {
        //设置权限
        POPEDOM Popedom = new POPEDOM (); 


        public XComboBox ():base()
        {
            InitializeComponent ();

            //
            Popedom.Ctrl = this;
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

        protected override void OnPaint ( PaintEventArgs pe )
        {
            base.OnPaint ( pe );
        }
    }
}
