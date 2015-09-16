using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FrontFlag.Control
{
    public partial class XPanel : System.Windows.Forms.Panel
    {
        //int _nRound = 1;
        //GraphicsPath _Path = null;

        private Image _imgBK = null;

        public EUMBKPPOS eumBKPos;

        #region 属性

        public string picBK
        {
            set { _imgBK = Image.FromFile(value); }
        }

        #endregion

        public XPanel()
        {
            InitializeComponent();

            SizeChanged += new System.EventHandler(this.OnSizeChanged);

            SetUpdateImgStyle();
        }

        /// <summary>
        /// 通过这些设置，pnl尺寸变化时，会把全部区域重新绘图，否则pnl只绘图变化区域。
        /// </summary>
        void SetUpdateImgStyle()
        {
            base.DoubleBuffered = true;

            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );

            UpdateStyles();
        }

        protected override void InitLayout ()
        {
            //Rectangle rc = new Rectangle ( 0 , 0 , this.Width , this.Height );
            //_Path = FF.Draw.Path.GetRound ( rc , _nRound );
            //Region rgn = new Region ( _Path );
            //this.Region = rgn;
        }

        protected override void OnPaint ( PaintEventArgs pe )
        {
            // TODO: 在此处添加自定义绘制代码

            // 调用基类 OnPaint
            base.OnPaint ( pe );

            DrawBKImg( pe );
        }

        private void DrawBKImg( PaintEventArgs e )
        {
            if (_imgBK == null)
                return;

            //Rectangle rc = new Rectangle( 0, 0, this.Width, this.Height );

            //Graphics g = e.Graphics;

            Rectangle rc = GetBKRect();

            e.Graphics.DrawImage( _imgBK, rc );


        }

        private Rectangle GetBKRect()
        {
            int X = 0;
            int Y = 0;
            int W = this.Width;
            int H = this.Height;

            Rectangle rc = new Rectangle(X,Y,W,H);

            if (_imgBK == null)
                return rc;

            int ImgW = _imgBK.Width;
            int ImgH = _imgBK.Height;

            if (eumBKPos == EUMBKPPOS.RT)
            {
                X = (W - ImgW);
                Y = 0;
                rc = new Rectangle( X, Y, ImgW, ImgH );
            }

            return rc;
        }

        private void OnSizeChanged ( object sender , EventArgs e )
        {
            //Rectangle rc = new Rectangle( 0, 0, this.Width, this.Height );
            //_Path = FF.Draw.Path.GetRound( rc, _nRound );
            //Region rgn = new Region( _Path );
            //this.Region = rgn;
        }

        public enum EUMBKPPOS
        {
            All = 1,
            L,
            T,
            R,
            B,
            LT,
            LB,
            RT,
            RB
        }
    }
}
