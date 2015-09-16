using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;


namespace FrontFlag.Control
{
    public partial class XImgButton : System.Windows.Forms.Button
    {
        bool _bMouseEnter = false;
        bool _bMousePress = false;

        int _nPressOffset = 1;

        ToolTip _Tip = new ToolTip () ;
        string _strTipText = "";
        Image _Img = null;

        public XImgButton ()
        {
            InitializeComponent ( );

            SetStyle ( ControlStyles.UserPaint , true );
            SetStyle ( ControlStyles.Selectable , false );

            //this.OnCreateControl += new System.Windows.Forms.Control. ( this.OnCreateControl );

            this.MouseDown += new System.Windows.Forms.MouseEventHandler ( this.mouseDown );
            this.MouseUp += new System.Windows.Forms.MouseEventHandler ( this.mouseUp );

            this.MouseEnter += new System.EventHandler ( this.weGotFocus );
            this.MouseLeave += new System.EventHandler ( this.weLostFocus );

            this.KeyDown += new System.Windows.Forms.KeyEventHandler ( this.keyDown );
            this.KeyUp += new System.Windows.Forms.KeyEventHandler ( this.keyUp );

            //
            BackColor = System.Drawing.Color.Transparent;
            FlatAppearance.BorderColor = System.Drawing.Color.FromArgb ( 0,255,0,0 );
            FlatAppearance.BorderSize = 0 ;
            FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;

        }

        public void Init ()
        {
            this.BackColor = Color.Transparent;
            _strTipText = this.Text;
            _Img = Image;
        }

        protected override void InitLayout ()
        {
            Init ( );
        }

        protected override void OnCreateControl ()
        {
            Init ();
        }

        #region Draw

        protected override void OnPaint ( PaintEventArgs e )
        {
            //base.OnPaint ( e );
            base.OnPaintBackground ( e );

            Rectangle rcBtn = new Rectangle ( 0 , 0 , Size.Width - _nPressOffset*2 , Size.Height - _nPressOffset*2 );
            if ( this.Enabled )
                DrawEnable ( e.Graphics , rcBtn );
            else
                DrawDisEnable ( e.Graphics , rcBtn );
        }

        void DrawEnable ( Graphics g , Rectangle rcBtn )
        {
            if ( _bMousePress )
                rcBtn.Offset ( _nPressOffset , _nPressOffset );

            //Draw Border
            if ( _bMouseEnter || _bMousePress )
            {
                Pen pen = new Pen ( Color.Orange );
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;   
                g.DrawRectangle ( pen , rcBtn );
            }

            //
            DrawImg ( g , rcBtn ) ;
        }

        void DrawImg ( Graphics g , Rectangle rcBtn )
        {
            if ( _Img == null )
                return ;

            int X = 0 , Y = 0 , W = _Img.Width , H = _Img.Height ;
            if ( _Img.Width > rcBtn.Width || _Img.Height > rcBtn.Height )
            {
                if ( _Img.Width > _Img.Height )
                {
                    W = rcBtn.Width;
                    H = ( int )( float ) ( ( float ) rcBtn.Width * ( float ) _Img.Height / ( float ) _Img.Width );
                    Y = ( rcBtn.Height - H ) / 2;
                }
                else
                {
                    H = rcBtn.Height;
                    W = ( int ) ( float ) ( ( float ) rcBtn.Height * ( float ) _Img.Width / ( float ) _Img.Height );
                    X = ( rcBtn.Width - W ) / 2;                        
                }
            }
            else
            {
                X = ( rcBtn.Width - W ) / 2  ;
                Y = ( rcBtn.Height - H ) / 2  ;
            }

            if ( _bMousePress )
            {
                X ++;
                Y ++;
            } 

            g.DrawImage ( _Img , X , Y , W , H );
        }

        void DrawDisEnable ( Graphics g , Rectangle rcBtn )
        {
        }

        #endregion Draw

        #region Event Handlers

        protected void mouseDown ( object sender , System.Windows.Forms.MouseEventArgs e )
        {
            buttonDown ( );
        }

        protected void mouseUp ( object sender , System.Windows.Forms.MouseEventArgs e )
        {
            buttonUp ( );
        }

        protected void buttonDown ()
        {
            _bMousePress = true;
            this.Invalidate ( );
        }

        protected void buttonUp ()
        {
            _bMousePress = false;
            this.Invalidate ( );
        }

        protected void keyDown ( object sender , System.Windows.Forms.KeyEventArgs e )
        {
            if ( e.KeyCode.ToString ( ) == "Space" )
            {
                buttonDown ( );
            }
        }

        protected void keyUp ( object sender , System.Windows.Forms.KeyEventArgs e )
        {
            if ( e.KeyCode.ToString ( ) == "Space" )
            {
                buttonUp ( );
            }
        }

        protected void weGotFocus ( object sender , System.EventArgs e )
        {
            FlatAppearance.BorderSize = 1;
            _Tip.SetToolTip ( this , _strTipText );

            Cursor = Cursors.Hand;
            _bMouseEnter = true;
            this.Invalidate ( );
        }

        protected void weLostFocus ( object sender , System.EventArgs e )
        {
            FlatAppearance.BorderSize = 0;
            _Tip.SetToolTip ( this , "" );

            Cursor = Cursors.Default;
            _bMouseEnter = false;
            buttonUp ( );
            this.Invalidate ( );
        }

        #endregion Event Handlers			

        #region No Use	

        [DllImport ( "gdi32.dll" )]
        private static extern bool BitBlt (
        IntPtr hdcDest ,   //   handle   to   destination   DC   
        int nXDest ,   //   x-coord   of   destination   upper-left   corner   
        int nYDest ,   //   y-coord   of   destination   upper-left   corner   
        int nWidth ,   //   width   of   destination   rectangle   
        int nHeight ,   //   height   of   destination   rectangle   
        IntPtr hdcSrc ,   //   handle   to   source   DC   
        int nXSrc ,   //   x-coordinate   of   source   upper-left   corner   
        int nYSrc ,   //   y-coordinate   of   source   upper-left   corner   
        System.Int32 dwRop   //   raster   operation   code   
        );

        private const Int32 SRCCOPY = 0xCC0020;

        public Bitmap GetBitmap ( Graphics g , Rectangle rc )
        {
            Bitmap memImage = new Bitmap ( rc.Width , rc.Height , g );
            Graphics memGraphic = Graphics.FromImage ( memImage );
            IntPtr dcRes = g.GetHdc ( );
            IntPtr dcDes = memGraphic.GetHdc ( );
            BitBlt ( dcDes , 0 , 0 , rc.Width , rc.Height , dcRes , rc.Left , rc.Top , SRCCOPY );
            g.ReleaseHdc ( dcRes );
            memGraphic.ReleaseHdc ( dcDes );
            return memImage;
        }  

        #endregion No Use	
    }
}
