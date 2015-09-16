using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D ;

using FrontFlag ;

namespace FrontFlag.Control
{
    public partial class XLabel : System.Windows.Forms.Label
    {
        //设置权限
        POPEDOM Popedom = new POPEDOM ();

        int     _nPad = 5 ;         //图片或文字距离横向两头的空白尺寸.
        int     _nJG = 5 ;          //图片和文字之间的间隔
        int     _Round = 0;

        int     _ImgX = 0;
        int     _ImgY = 0;
        int     _ImgW = 0;
        int     _ImgH = 0;

        Size     _CtrlSize=new Size ( 0,0) ;   

        int     _BorderW = 0;    
        Color   _clrBorder = Color.Transparent ;

        int     _nAngle = 0;
        Color   _clrBK = Color.Transparent ;
        Color   _clrBK2 = Color.Transparent ;

        public XLabel ()
        {
            InitializeComponent ( );

            SetStyle ( ControlStyles.UserPaint , true );
            SetStyle ( ControlStyles.FixedHeight , false );
            SetStyle ( ControlStyles.FixedWidth , false );
            SetStyle ( ControlStyles.Opaque , false );
            SetStyle ( ControlStyles.ResizeRedraw , true );

            this.AutoSize = false;

            BackColor = System.Drawing.Color.Transparent;

            //
            Popedom.Ctrl = this;
        }

        public void Init ()
        {
        }

        protected override void InitLayout ()
        {
            Init ( );
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

        #region Set

        //
        public void SetBorder ( Color clrBorder )
        {
            _BorderW = 1;
            _clrBorder = clrBorder;
        }

        public void SetBorder ( Color clrBorder , int BorderW ) 
        {
            SetBorder ( clrBorder );
            _BorderW = BorderW ;
        }

        public void SetRound ( int Round )
        {
            _Round = Round ;
        }

        public void SetBKColor ( Color clr1 , Color clr2 , int nAngle )
        {
            SetBKColor ( clr1 , clr2 ) ;
            _nAngle = nAngle ;
        }

        public void SetBKColor ( Color clr1 , Color clr2 )
        {
            _clrBK = clr1 ;
            _clrBK2 = clr2 ;
        }

        public void SetBKColor ( Color clr )
        {
            _clrBK = clr ;
            _clrBK2 = clr ;
        }

        public void SetPad ( int nPand )
        {
            _nPad = nPand;
        }

        public void SetJG ( int nJG )
        {
            _nJG = nJG;
        }

        #endregion Set

        #region Get

        public Size GetSize()
        {
            return _CtrlSize ;
        }

        #endregion Get

        #region Draw

        protected override void OnPaint ( PaintEventArgs e )
        {
            if ( this.Text == "" )
                return;

            //base.OnPaint ( e );
            base.OnPaintBackground ( e );

            Measure ( e.Graphics );

            //Draw My BK
            DrawBK ( e.Graphics );

            //Draw Img
            DrawImg ( e.Graphics );

            //Draw Text
            DrawText ( e.Graphics );
        }

        void Measure ( Graphics g )
        {
            MeasureImg ( this.Image , ref _ImgX , ref _ImgY , ref _ImgW , ref _ImgH );
 
            SizeF szStr = g.MeasureString ( this.Text , Font );
            int strW = ( int ) szStr.Width + 1 ;

            this.Width = _nPad + _ImgW + strW + _nPad ;
        }

        void MeasureImg ( Image Img , ref int ImgX , ref int ImgY , ref int ImgW , ref int ImgH )
        {
            ImgW = ImgH = 0 ;

            if ( Img == null )
                return;

            Rectangle rcBtn = new Rectangle ( 0 , 0 , Size.Width , Size.Height );

            int X = _nPad , Y = 0 , W = Img.Width , H = Img.Height;
            if ( Img.Width > rcBtn.Width || Img.Height > rcBtn.Height )
            {
                if ( Img.Width > Img.Height )
                {
                    W = rcBtn.Width;
                    H = ( int ) ( float ) ( ( float ) rcBtn.Width * ( float ) Img.Height / ( float ) Img.Width );
                    Y = ( rcBtn.Height - H ) / 2;
                }
                else
                {
                    H = rcBtn.Height;
                    W = ( int ) ( float ) ( ( float ) rcBtn.Height * ( float ) Img.Width / ( float ) Img.Height );
                    //X = ( rcBtn.Width - W ) / 2;
                    X = 0;
                }
            }
            else
            {
                //X = ( rcBtn.Width - W ) / 2;
                X = 0;
                Y = ( rcBtn.Height - H ) / 2;
            }

            ImgX = _nPad + X ;
            ImgY = Y;
            ImgW = W;
            ImgH = H;
        }

        void DrawBK ( Graphics g )
        {
            Rectangle rc = new Rectangle ( 0 , 0 , this.Width-1 , this.Height-1 );
            _CtrlSize = new Size( this.Width-1 , this.Height-1 );

            GraphicsPath path ;

            if ( _Round == -1 )
                path = FF.Draw.Path.GetRound ( rc );
            else if ( _Round > 0 )
                path = FF.Draw.Path.GetRound ( rc , _Round );
            else 
                path = FF.Draw.Path.GetRect ( rc );

            LinearGradientBrush brush = new LinearGradientBrush ( rc , _clrBK , _clrBK2 , _nAngle );
            g.FillPath ( brush , path );
            brush.Dispose ( ); 

            //
            if ( _BorderW > 0 )
            {
                Pen pen = new Pen ( _clrBorder , _BorderW );
                g.DrawPath ( pen , path );
            }
        }

        void DrawImg ( Graphics g )
        {
            if ( this.Image == null )
                return;

            g.DrawImage ( this.Image , _ImgX , _ImgY , _ImgW , _ImgH );
        }

        void DrawText ( Graphics g )
        {
            SizeF szStr = g.MeasureString ( this.Text , Font );
            int W = ( int ) szStr.Width + 1 ;

            int X = ( _ImgW > 0 ) ? _nPad + _ImgW + _nJG : _nPad ;
            //Rectangle rc = new Rectangle ( X , 0 , W , this.Height );
            Rectangle rc = new Rectangle(X-3, 0, W, this.Height ); //临时调整,不对的.

            StringFormat format = new StringFormat ( );

            if ( TextAlign == ContentAlignment.TopLeft || TextAlign == ContentAlignment.TopCenter || TextAlign == ContentAlignment.TopRight )
                format.LineAlignment = StringAlignment.Near;
            else if ( TextAlign == ContentAlignment.MiddleLeft || TextAlign == ContentAlignment.MiddleCenter || TextAlign == ContentAlignment.MiddleRight )
                format.LineAlignment = StringAlignment.Center;
            else
                format.LineAlignment = StringAlignment.Far;

            if ( TextAlign == ContentAlignment.TopLeft || TextAlign == ContentAlignment.MiddleLeft || TextAlign == ContentAlignment.BottomLeft )
                format.Alignment = StringAlignment.Near;
            else if ( TextAlign == ContentAlignment.TopCenter || TextAlign == ContentAlignment.MiddleCenter || TextAlign == ContentAlignment.BottomCenter )
                format.Alignment = StringAlignment.Center;
            else            
                format.Alignment = StringAlignment.Far;

            g.DrawString ( this.Text , Font , new SolidBrush ( this.ForeColor ) , rc , format );
        }

        #endregion Draw
    }
}
