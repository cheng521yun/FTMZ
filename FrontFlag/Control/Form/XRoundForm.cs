using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

using FrontFlag;

namespace FrontFlag.Control
{
    public partial class XRoundForm : System.Windows.Forms.Form
    {
        int     _nRound = 10;
        GraphicsPath _Path = null;

        Color   _clrBK = Color.White ;
        Color   _clrBK2 = Color.White;
        int     _nAngle = 90;

        int     _nBorderW = 0;
        Color   _clrBorder = Color.Transparent;

        public XRoundForm ()
        {
            InitializeComponent ( );

            SizeChanged += new System.EventHandler ( this.OnSizeChanged );
        }

        protected override void InitLayout ()
        {

        }

        #region Set

        public void SetBK ( Color clrBK1 , Color clrBK2 )
        {
            _clrBK = clrBK1;
            _clrBK2 = clrBK2;
        }

        public void SetBK ( Color clrBK )
        {
            _clrBK = _clrBK2 = clrBK;
        }

        public void SetBK ( Color clrBK1 , Color clrBK2 , int nAngle )
        {
            SetBK ( clrBK1 , clrBK2 );
            _nAngle = nAngle;
        }

        public void SetBorder ( Color clrBorder , int nBorderW )
        {
            _clrBorder = clrBorder;
            _nBorderW = nBorderW;
        }

        public void SetRound ( int nRound )
        {
            _nRound = nRound ;
        }

        #endregion Set

        #region Draw

        protected override void OnPaint ( PaintEventArgs pe )
        {
            // 调用基类 OnPaint
            //base.OnPaint ( pe );

            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            DrawBK ( g );
            DrawBorder ( g );
        }

        void DrawBK ( Graphics g )
        {
            Rectangle rc = new Rectangle ( 0 , 0 , this.Width , this.Height ) ;

            if ( _clrBK == _clrBK2 )
            {
                SolidBrush brush = new SolidBrush ( _clrBK );
                g.FillRectangle ( brush , rc );
            }
            else
            {
                LinearGradientBrush brush = new LinearGradientBrush ( rc , _clrBK , _clrBK2 , _nAngle );
                g.FillPath ( brush , _Path );
                brush.Dispose ( ); 
            }
        }

        void DrawBorder ( Graphics g )
        {
            if ( _nBorderW <= 0 || _Path == null )
                return;

            Rectangle rc = new Rectangle ( 0 , 0 , this.Width-1 , this.Height-1 );
            GraphicsPath Path = FF.Draw.Path.GetRound ( rc , _nRound );

            Pen pen = new Pen ( _clrBorder , _nBorderW ) ; 
            g.DrawPath ( pen , Path );
        }

        #endregion Draw

        private void OnSizeChanged ( object sender , EventArgs e )
        {
            try
            {
                Rectangle rc = new Rectangle( 0, 0, this.Width, this.Height );
                _Path = FF.Draw.Path.GetRound( rc, _nRound );
                Region rgn = new Region( _Path );
                this.Region = rgn;

            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
        }
    }
}
