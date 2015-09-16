using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FrontFlag.Control
{
    public partial class XButton : System.Windows.Forms.Button
    {
        //设置权限
        POPEDOM Popedom = new POPEDOM ( );

        private Image _imgBK = null;
        private Image _imgBK2 = null;

        Color _clrBK = Color.FromArgb( 21, 170, 127 );
        Color _clrBK2 = Color.FromArgb( 57, 185, 148 ); 
        Color _clrText = Color.Black ;
        Color _clrSelText = Color.Black;
        Color _clrBorder = Color.Gray ;

        int     _nPressOffset = 1 ;
        bool    _bMouseEnter = false ;
        bool    _bMousePress = false;

        public XButton ()
        {
            InitializeComponent ();

            //SetStyle ( ControlStyles.UserPaint, true );

            this.MouseDown += new System.Windows.Forms.MouseEventHandler ( this.mouseDown );
            this.MouseUp += new System.Windows.Forms.MouseEventHandler ( this.mouseUp );

            this.MouseEnter += new System.EventHandler ( this.weGotFocus );
            this.MouseLeave += new System.EventHandler ( this.weLostFocus );

            this.KeyDown += new System.Windows.Forms.KeyEventHandler ( this.keyDown );
            this.KeyUp += new System.Windows.Forms.KeyEventHandler ( this.keyUp );

            //this.Resize += new EventHandler( OnReResize );//调整大小


            //this.SetStyle( ControlStyles.ResizeRedraw, true );

            //
            Popedom.Ctrl = this;

            //FlatStyle = true;
            //FlatAppearance.BorderSize = 0;
            //FlatAppearance.BorderColor = System.Drawing.Color.White;
        }

        //private void OnReResize( object sender, EventArgs e )
        //{
        //    Rectangle r = this.ClientRectangle;

        //    Graphics g = this.CreateGraphics();
        //    g.SmoothingMode = SmoothingMode.AntiAlias;

        //    //Draw All BK
        //    Rectangle _rcBK = this.ClientRectangle;

        //    Rectangle rcBtn = _rcBK;

        //    if ( this.Enabled )
        //        DrawEnable( g, rcBtn );
        //    else
        //        DrawDisEnable( g, rcBtn );

        //    g.Dispose();
        //}

        #region 属性

        public Color clrBK
        {
            set 
            { 
                _clrBK = value;
                _clrBK2 = value;
            }
        }

        public string picBK 
        {
            set { _imgBK = Image.FromFile(value); }
        }

        public string picBK2
        {
            set { _imgBK2 = Image.FromFile( value ); }
        }

        public bool SelectTable
        {
            get
            {
                return GetStyle(ControlStyles.Selectable);
            }

            set
            {
                SetStyle(ControlStyles.Selectable, value);
            }
        }

        //是否设置成平板样式的按钮。
        public bool FlatStyle
        {
            get
            {
                return SelectTable;
            }

            set
            {
                SelectTable = value;
            }
        }

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

        #region Event

        protected override void OnPaint ( PaintEventArgs e )
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //Draw All BK
            Rectangle _rcBK = this.ClientRectangle;

            //Rectangle rcBtn = new Rectangle ( _rcBK.Left , _rcBK.Top , _rcBK.Width - _nPressOffset , _rcBK.Height - _nPressOffset );
            Rectangle rcBtn = _rcBK;

            if ( this.Enabled )
                DrawEnable ( g , rcBtn );
            else
                DrawDisEnable ( g , rcBtn );
        }

        protected void mouseDown ( object sender, System.Windows.Forms.MouseEventArgs e )
        {
            buttonDown ();
        }

        protected void mouseUp ( object sender, System.Windows.Forms.MouseEventArgs e )
        {
            buttonUp ();
        }

        protected void buttonDown ()
        {
            _bMousePress = true;
            this.Invalidate ();
        }

        protected void buttonUp ()
        {
            _bMousePress = false;
            this.Invalidate ();
        }

        protected void keyDown ( object sender, System.Windows.Forms.KeyEventArgs e )
        {
            if ( e.KeyCode.ToString () == "Space" )
            {
                buttonDown ();
            }
        }

        protected void keyUp ( object sender, System.Windows.Forms.KeyEventArgs e )
        {
            if ( e.KeyCode.ToString () == "Space" )
            {
                buttonUp ();
            }
        }

        protected void weGotFocus ( object sender, System.EventArgs e )
        {
            Cursor = Cursors.Hand;
            _bMouseEnter = true;
            this.Invalidate ();
        }

        protected void weLostFocus ( object sender, System.EventArgs e )
        {
            Cursor = Cursors.Default;
            _bMouseEnter = false;
            buttonUp ();
            this.Invalidate ();
        }

        #endregion

        #region private

        void DrawEnable ( Graphics g , Rectangle rcBtn )
        {
            if ( _bMousePress )
                rcBtn.Offset ( _nPressOffset , _nPressOffset );

            if (!_bMouseEnter)
            {
                if (_imgBK != null)
                {
                    g.DrawImage(_imgBK, rcBtn);
                }
                else
                {
                    SolidBrush brush = new SolidBrush( _clrBK );
                    g.FillRectangle( brush, rcBtn );
                    brush.Dispose(); 
                }
            }
            else
            {
                if ( _imgBK2 != null )
                {
                    g.DrawImage( _imgBK2, rcBtn );
                }
                else
                {
                    SolidBrush brush = new SolidBrush( _clrBK2 );
                    g.FillRectangle( brush, rcBtn );
                    brush.Dispose();
                }
            }
            

            //
            //LinearGradientBrush brush = ( !_bMouseEnter ) ? new LinearGradientBrush( rcBtn, _clrBK, _clrBK, 90 ) : new LinearGradientBrush( rcBtn, _clrBK2, _clrBK2, 90 );
            //g.FillRectangle ( brush , rcBtn );
            //brush.Dispose ( ); 

            //
            StringFormat format = new StringFormat ( );
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            g.DrawString ( this.Text , Font , new SolidBrush ( ( !_bMouseEnter ) ? _clrText : _clrSelText ) , rcBtn , format );
            
        }

        void DrawDisEnable ( Graphics g , Rectangle rcBtn )
        {
            g.FillRectangle ( new SolidBrush ( Color.FromArgb ( 230,230,230 ) ) , rcBtn );
            g.DrawRectangle ( new Pen ( Color.FromArgb ( 230 , 230 , 230 ) ) , rcBtn );

            //
            StringFormat format = new StringFormat ( );
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            g.DrawString ( this.Text , Font , new SolidBrush ( Color.DarkGray ) , rcBtn , format );
        }

        #endregion

        #region public

        //public void SetPopedom ()
        //{
        //    Visible = _PopedomByte.CanRead;             //不可见           
        //    Enabled = _PopedomByte.CanModify;           //可见，状态无效
        //}

        public void SetWH ( int W, int H )
        {
            //this.Width = W;
            //this.Height = H;
            Size = new Size( W, H );
        }

        public void SetBKColor( Color clr, Color clrHover )
        {
            _clrBK = clr;
            _clrBK2 = clrHover;
        }

        public void SetBKColor( Color clr )
        {
            _clrBK = clr;
            _clrBK2 = clr;
        }

        public void SetTxtColor( Color clr, Color clrHover )
        {
            _clrText = clr;
            _clrSelText = clrHover;
        }

        public void SetTxtColor( Color clr )
        {
            _clrText = clr;
            _clrSelText = clr;
        }

        #endregion

    }
}
