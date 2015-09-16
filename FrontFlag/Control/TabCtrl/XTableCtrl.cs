//////////////////////////////////////////////////////////////////////////
/* 名称： XTableCtrl
 * 
 * 日期：2007-04-10
 * 
 * 创建方法：   选择 “用户控件”来生成，继承自 System.Windows.Forms.TabControl
 * 
 * OnLoad()
 * {
 *      COMMTHIS.Ctrl.TabCtrl.SetXTab ( ref tab );
 * }
 * 
*/
//////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using FrontFlag;

namespace FrontFlag.Control
{
    public partial class XTableCtrl : System.Windows.Forms.TabControl
    {
        FrontFlag.DRAW Draw = new FrontFlag.DRAW ( );

        private static Color clrBK = Color.White;
        private static Color clrBarBK = Color.FromArgb( 53, 193, 150 );
        private static Color clrBarBK2 = Color.FromArgb( 53, 193, 150 );
        private static Color clrBtnBK = clrBarBK;
        private static Color clrSelBtnBK = clrBK ;
        private static Color clrBorder = Color.FromArgb( 53, 193, 150 );
        private static Color clrText = Color.White;
        private static Color clrSelText = Color.FromArgb( 68, 68, 68 );
        private static Color clrLineV = Color.White;

        Rectangle   _rcTab ;

        int         _nEnterBtn = -1 ;
        bool        _bLockPage = false;                      //如果需要禁止用户通过鼠标或者Ctrl+Tab改变标签页，需要设定 _bLockPage 为true。  
        ArrayList   _aryPage = new ArrayList ()  ;           //保存tab全部的Page   

        public XTableCtrl ()
        {
            InitializeComponent ( );

            SetDafaultStyle ( );
            SetStyle ( ControlStyles.UserPaint , true );

            //this.MouseDown += new MouseEventHandler ( this.OnMouseEnter );
            this.MouseEnter += new EventHandler ( this.OnMouseEnter );
            this.MouseLeave += new EventHandler ( this.OnMouseLeave );

            ItemSize = new Size( 100, 30 );   //每个标签的大小。
            //SizeMode = TabSizeMode.FillToRight;   //没用。因为自己绘画标签。

        }

        public void SetDafaultStyle ()
        {
            Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
        }

        public void SetBarColor ( Color clr1 , Color clr2 )
        {
            clrBarBK = clr1 ;
            clrBarBK2 = clr2 ;
        }

        public void SetTextColor ( Color clr1 , Color clr2 )
        {
            clrText = clr1;
            clrSelText = clr2;
        }  

        public void Lock ()
        {
            _bLockPage = true;
        }

        public void UnLock()
        {
            _bLockPage = false;
        }

        public void StorePage ()
        {
            _aryPage.Clear();
            foreach (TabPage p in TabPages)
                _aryPage.Add( p );
        }

        public void RestorePage()
        {
            TabPages.Clear();
            foreach (TabPage p in _aryPage)
                TabPages.Add(p);

        }

        public void ShowPage ( TabPage page )
        {
            if ( !TabPages.Contains ( page ) )
                TabPages.Add ( page );
        }
        
        public void HidePage ( TabPage page )
        {
            if ( TabPages.Contains ( page ) )
                TabPages.Remove ( page );
        }

        #region Draw

        protected override void OnPaint ( PaintEventArgs e )
        {
            try
            {
                Draw.g = e.Graphics;
                _rcTab = e.ClipRectangle;

                if (e.ClipRectangle.Width <= 0)
                    return;

                //绘制标签栏背景
                Draw.g.FillRectangle(new SolidBrush(clrBK), _rcTab);

                //Draw Bar
                Rectangle rc = new Rectangle(_rcTab.Left, _rcTab.Top, _rcTab.Width, GetTabRect(0).Height);
                if (rc.Width == 0 || rc.Height == 0)
                    return;

                LinearGradientBrush brush = new LinearGradientBrush(rc, clrBarBK, clrBarBK2, 90);
                Draw.g.FillRectangle(brush, rc);
                brush.Dispose();

                if (this.TabCount <= 0)
                    return;

                //依次绘制单个标签
                for (int i = 0; i < this.TabCount; i++)
                {
                    DrawItem(i);
                }
            }
            catch ( Exception ex )
            {
            }
        }

        protected void DrawItem ( int index )
        {
            if ( index == -1 )
                return;
            
            Graphics g = this.CreateGraphics ( );
            g.SmoothingMode = SmoothingMode.HighQuality;

            Color clr;
            Rectangle rc = GetTabRect ( index );

            if ( index == 0 )
                rc.X = 0;

            if ( SelectedIndex == index )
            {
                //Rectangle rcBox = new Rectangle ( rc.Left , rc.Top + 4 , rc.Width , rc.Height - 4 );

                /*
                GraphicsPath Path;
                int nRound = 20;

                Path = FF.Draw.Path.GetHalfRoundN_ ( rcBox , nRound );
                Draw.g.FillPath ( new SolidBrush ( clrSelBtnBK ) , Path );
                Path = FF.Draw.Path.GetHalfRoundN ( rcBox , nRound );
                Draw.g.DrawPath ( new Pen ( clrBorder ) , Path );
                 * */

                LinearGradientBrush brush = new LinearGradientBrush ( rc , clrBarBK , clrBK , 90 );
                Draw.g.FillRectangle ( brush , rc );
                brush.Dispose ( ); 

                //Draw Line
                Draw.g.DrawLine ( new Pen ( clrBorder ) , new Point ( _rcTab.Left , rc.Bottom ) , new Point ( rc.Left-1 , rc.Bottom ) ) ;
                Draw.g.DrawLine ( new Pen ( clrBorder ) , new Point ( rc.Right , rc.Bottom ) , new Point ( _rcTab.Right , rc.Bottom ) );

                clr = clrSelText;
            }
            else
            {
                clr = clrText;
            }

            //Drwa Text
            StringFormat format = new StringFormat ( );
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            g.DrawString ( TabPages [ index ].Text , Font , new SolidBrush ( clr ) , rc , format );

            //
            g.Dispose ( );
        }

        protected void DrawEnterItem ( int No )
        {
            if ( No == -1 )
                return;

            Graphics g = this.CreateGraphics ( );
            g.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rc = GetTabRect ( No );
            if ( No == 0 )
                rc.X = 0;
                
            //
            LinearGradientBrush brush = new LinearGradientBrush ( rc , clrBarBK , clrBarBK2 , 90 );
            g.FillRectangle ( brush , rc );
            brush.Dispose ( );

            //
            StringFormat format = new StringFormat ( );
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            //Font font = new Font ( this.Font , FontStyle.Underline );
            //g.DrawString ( TabPages [ No ].Text , font , new SolidBrush ( clrText ) , rc , format );
            g.DrawString( TabPages[ No ].Text, Font, new SolidBrush( clrText ), rc, format );

            g.Dispose ( );
        }

        protected void DrawLeaveItem ()
        {
            if ( _nEnterBtn == -1 || _nEnterBtn == SelectedIndex )
                return;

            Graphics g = this.CreateGraphics ( );
            g.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rc = GetTabRect ( _nEnterBtn );
            if ( _nEnterBtn == 0 )
                rc.X = 0;
            
            //
            LinearGradientBrush brush = new LinearGradientBrush ( rc , clrBarBK , clrBarBK2 , 90 );
            g.FillRectangle ( brush , rc );
            brush.Dispose ( );
            
            //
            StringFormat format = new StringFormat ( );
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            g.DrawString ( TabPages [ _nEnterBtn ].Text , Font , new SolidBrush ( clrText ) , rc , format );
            
            g.Dispose ( );
        }

        #endregion Draw

        protected override void WndProc ( ref   System.Windows.Forms.Message m )
        {
            if ( m.Msg == 513 && this._bLockPage )
            {
                return;   //一旦 this._bLockPage 的值为true（即不允许用户来改变标签页），则将捕获的事件销毁，不再传递给基类的事件处理函数。   

            }
            else
            {
                base.WndProc ( ref  m );
            }
        }

        protected override void OnKeyDown ( KeyEventArgs e )
        {
            if ( e.Control == true && e.KeyCode == System.Windows.Forms.Keys.Tab && this._bLockPage )
            {
                return;   //一旦 this._bLockPage 的值为true（即不允许用户来改变标签页），则将捕获的 CTRL+TAB and CTRL+SHIFT+TAB 事件销毁，不再传递给基类的事件处理函数。  
            }
            else
            {
                base.OnKeyDown ( e );
            }
        }

        //protected void OnMouseEnter ( KeyEventArgs e )
        private void OnMouseEnter ( object sender, EventArgs e )
        {
            Cursor = Cursors.Hand;

            Rectangle rc = _rcTab;
            Point pt = new Point ( MousePosition.X , MousePosition.Y );

            pt = PointToClient ( pt );

            for ( int i = 0 ; i < this.TabCount ; i++ )
            {
                rc = GetTabRect ( i );
                if ( i != SelectedIndex && pt.X > rc.Left && pt.X < rc.Right && pt.Y > rc.Top && pt.Y < rc.Bottom )
                {
                    _nEnterBtn = i;
                    DrawEnterItem ( _nEnterBtn );
                }
            }
        }

        private void OnMouseLeave ( object sender , EventArgs e )
        {
            Cursor = Cursors.Default;

            DrawLeaveItem ();
            _nEnterBtn = -1;
        }
    }
}
