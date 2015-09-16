using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FrontFlag.Control
{
    public partial class XFloatForm : Form
    {
        private System.Threading.Timer tmr = null ;

        public XFloatForm()
        {
            InitializeComponent();
        }

        #region Event

        private void FloatForm_Load(object sender, EventArgs e)
        {
            Hide(); 
        }

        private void timerCall( Object obj )
        {
            Call_JustHide();
        }

        private void FloatForm_MouseEnter(object sender, EventArgs e)
        {
            StartTimer();
            Show();
        }

        private void FloatForm_MouseLeave(object sender, EventArgs e)
        {
            if (Call_IsMouseInWnd())
                return;

            EndTimer();
            Hide();
        }

        #endregion

        #region Private

        void StartTimer()
        {
            //if (this.tmr != null)
            //    this.tmr.Dispose();
            //this.tmr = new System.Threading.Timer(new TimerCallback(timerCall), null, 0, 1000);
        }

        void EndTimer()
        {
            //if (this.tmr != null)
            //{
            //    this.tmr.Dispose();
            //    this.tmr = null;
            //}
        }

        private delegate bool dgIsMouseInWnd();
        bool Call_IsMouseInWnd()
        {
            if (!this.InvokeRequired)
            {
                return IsMouseInWnd();
            }
            else
            {
                dgIsMouseInWnd d = new dgIsMouseInWnd(IsMouseInWnd);
                return (bool)this.Invoke(d, new object[] {}) ;
            }
        }

        bool IsMouseInWnd()
        {
            Point pt = this.PointToClient(MousePosition);
            if (pt.X > 0 && pt.Y > 0 && pt.X < this.Width && pt.Y < this.Height)
                return true;
            return false;
        }

        private delegate void dgHide();
        void Call_JustHide()
        {
            if (!this.InvokeRequired)
            {
                JustHide();
            }
            else
            {
                dgHide d = new dgHide(JustHide);
                this.Invoke(d, new object[] { });
            }
        }

        #endregion

        /// <summary>
        /// 显示FloatForm。
        /// 显示的坐标根据ctl的定位。OffsetX，OffsetY 是针对ctl的偏移。
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="OffsetX"></param>
        /// <param name="OffsetY"></param>
        protected void ShowForm(System.Windows.Forms.Control ctl, int OffsetX, int OffsetY)
        {
            Point p = ctl.PointToScreen ( new Point ( OffsetX, OffsetY ) ) ;
            Location = p;

            StartTimer();
            Show();
        }

        protected void JustHide()
        {
            if (!Call_IsMouseInWnd())
            {
                EndTimer();
                Hide();
            }
                
        }

    }
}
