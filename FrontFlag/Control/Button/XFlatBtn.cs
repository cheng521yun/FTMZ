using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control.Button
{
    public partial class XFlatBtn : System.Windows.Forms.Button
    {
        public delegate void dgtParamNone();
        public dgtParamNone dgtClick = null;

        public XFlatBtn()
        {
            InitializeComponent();
            Init();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        void Init()
        {
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false; 
            Cursor = System.Windows.Forms.Cursors.Hand;

            FlatAppearance.BorderColor = Color.Red;

            //点击按钮触发委托调用,这个委托调用会在直接Click()事件前调用个。
            this.Click += new EventHandler(ClickButton); 
        }

        #region 属性

        public Color clrFore
        {
            set
            {
                ForeColor = value;
            }
        }

        public Color clrBK
        {
            set
            {
                BackColor = value;
                FlatAppearance.BorderColor = value;
            }
        }

        public Color clrMouseOverBK
        {
            set
            {
                FlatAppearance.MouseOverBackColor = value;
            }
        }

        #endregion

        /// <summary>
        /// 点击按钮触发委托调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClickButton(object sender, System.EventArgs e)
        {
            if (dgtClick != null)
                dgtClick();
        }



    }
}
