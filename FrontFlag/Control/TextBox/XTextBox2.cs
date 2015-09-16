/*
 * 
 *  与 XTextBox 的区别。
 *  显示字串的时候，在Y方向，向Top对齐。
 *      在多行文本框显示多行文字的时候有用。
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control
{
    public partial class XTextBox2 : System.Windows.Forms.TextBox
    {
        //设置权限
        POPEDOM Popedom = new POPEDOM ();

        public enum eumFORMAT { Normal , Upper , FirstUpper } ;

        eumFORMAT _Format = eumFORMAT.Normal;

        public XTextBox2 ()
        {
            InitializeComponent ();

            //
            Popedom.Ctrl = this;
        }

        public eumFORMAT Format
        {
            set { _Format = value; }
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

        #region Event

        //重写OnEnabledChanged  
        protected override void OnEnabledChanged ( EventArgs e )
        {
            if ( Enabled == false )
            {
                SetStyle ( ControlStyles.UserPaint , true );
            }
            else
            {
                SetStyle ( ControlStyles.UserPaint , false );
            }
 
            base.OnEnabledChanged ( e );
        }  

        protected override void OnPaint ( PaintEventArgs pe )
        {
            // TODO: 在此处添加自定义绘制代码

            // 调用基类 OnPaint
            base.OnPaint ( pe );

            if ( Enabled == false )
            {
                //填充背景
                pe.Graphics.FillRectangle ( new SolidBrush ( Color.WhiteSmoke ) , pe.ClipRectangle );


                //文字描画  
                int x = 0 , y = 0;
                Size s = pe.Graphics.MeasureString ( Text , Font ).ToSize ();
                x = 0;
                y = 0;

                pe.Graphics.DrawString ( this.Text , this.Font , Brushes.Black , x , y );
            }
        }

        private void OnTextChanged ( object sender , EventArgs e )
        {
            if ( _Format == eumFORMAT.Upper )
                ToUpper ();

            else if ( _Format == eumFORMAT.FirstUpper )
                ToFirstUpper ();
        }

        /*
        protected override void OnCreateControl ()
        {
            base.OnCreateControl ();
            if ( this.Enabled == true )
                this.ForeColor = Color.Blue;
            else
                this.ForeColor = Color.Black;
        }

        protected override void OnReadOnlyChanged ( EventArgs e )
        {
            base.OnReadOnlyChanged ( e );
            if ( this.Enabled == true )
                this.ForeColor = Color.Blue;
            else
                this.ForeColor = Color.Black;
        }
        */

        #endregion

        public void ToUpper ( )
        {
            int n = Text.Length;
            Text = Text.ToUpper ();
            SelectionStart = n;
        }

        public void ToFirstUpper ()
        {
            /*
            int n = Text.Length;
            if ( n > 0 )
            {
                Text = Text.ToLower ();
                char ch = Text [ 0 ];
                //string strRight = Text.Substring ( 1 , n - 1 );

                if ( Char.IsLetter ( ch ) )
                    ch = Char.ToUpper ( ch );
                   
                //Text = ch.ToString () + strRight;
            }
            SelectionStart = n;
             */ 
        }

        public void SetPassword ( bool bFlag )
        {
            if ( bFlag )
                PasswordChar = '*';
            else
                PasswordChar = Convert.ToChar ( 0 );
        }

        public void SetReadOnly ( bool bFlag )
        {
            if ( bFlag )
            {
                ReadOnly = true;
                BackColor = Color.WhiteSmoke;
            }
            else
            {
                int n = Text.Length;
                //Text = Text.ToUpper ();
                SelectionStart = n;
            }
        }
    }
}
