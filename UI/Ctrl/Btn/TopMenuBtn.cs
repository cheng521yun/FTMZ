using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Def;
using FrontFlag.Control.Menu;
using Global;

namespace UI.Ctrl.Btn
{
    public partial class TopMenuBtn : UserControl
    {
        private Image _imgComm = null ;
        private Image _imgHove = null ;

        private Color _clrComm = Color.Black;
        private Color _clrHove = Color.DarkRed;

        ContextMenuStrip _Menu = new ContextMenuStrip();
        private int _nCommandId = -1;

        public TopMenuBtn()
        {
            InitializeComponent();
        }

        #region 属性

        private bool hasMenu
        {
            get { return _Menu.Items.Count > 0; }
        }

        #endregion

        #region Event

        private void TopMenuBtn_Load( object sender, EventArgs e )
        {
        }

        private void TopMenuBtn_SizeChanged( object sender, EventArgs e )
        {
            ChangeSize();
        }

        private void TopMenuBtn_MouseDown( object sender, MouseEventArgs e )
        {
            OnMouseDown( e );
        }

        private void TopMenuBtn_MouseEnter( object sender, EventArgs e )
        {
            MouseFocus();
        }

        private void TopMenuBtn_MouseLeave( object sender, EventArgs e )
        {
            MouseUnFocus();
        }

        private void picbox_MouseDown( object sender, MouseEventArgs e )
        {
            OnMouseDown( e );
        }

        private void picbox_MouseEnter( object sender, EventArgs e )
        {
            MouseFocus();
        }

        private void picbox_MouseLeave( object sender, EventArgs e )
        {
            MouseUnFocus();
        }

        private void labCaption_MouseDown( object sender, MouseEventArgs e )
        {
            OnMouseDown( e );
        }

        private void labCaption_MouseEnter( object sender, EventArgs e )
        {
            MouseFocus();
        }

        private void labCaption_MouseLeave( object sender, EventArgs e )
        {
            MouseUnFocus();
        }



        #endregion

        #region public

        public void Init( Image imgComm, Image imgHove, string strCaption, List<XToolStripMenuItem> lstMenuItem )
        {
            _imgComm = imgComm;
            _imgHove = imgHove;

            if (_imgComm != null)
                picbox.Image = _imgComm;

            strCaption = GetShowedCaption( strCaption );
            labCaption.Text = strCaption;

            //设置弹出菜单
            SetMenu ( lstMenuItem );
        }

        /// <summary>
        /// 没有弹出菜单，比如Home按钮
        /// </summary>
        /// <param name="imgComm"></param>
        /// <param name="imgHove"></param>
        /// <param name="strCaption"></param>
        public void Init( Image imgComm, Image imgHove, string strCaption, int nComandId )
        {
            List<XToolStripMenuItem> lstMenuItemBlank = new List<XToolStripMenuItem>();
            Init( imgComm, imgHove, strCaption, lstMenuItemBlank );

            _nCommandId = nComandId;
        }

        #endregion

        private void SetMenu( List<XToolStripMenuItem> lstMenuItem )
        {
            foreach ( XToolStripMenuItem Item in lstMenuItem )
            {
                Item.Enabled = Item.Permission.CanEnable;
                _Menu.Items.Add( Item );
                Item.dlgtAction = ExcutCommand;
            }
        }

        #region 显示相关

        private void ChangeSize()
        {
            int AllW = this.Width;
            int X;
            int Y;

            //
            int picW = picbox.Width;
            X = ( AllW - picW ) / 2;
            Y = picbox.Location.Y;
            picbox.Location = new Point( X, Y );

            //
            int labW = GetLableW();
            X = ( AllW - labW ) / 2;
            Y = labCaption.Location.Y;
            labCaption.Location = new Point( X, Y );

        }

        private void MouseFocus()
        {
            Cursor = Cursors.Hand;
            labCaption.ForeColor = _clrHove;
        }

        private void MouseUnFocus()
        {
            Cursor = Cursors.Default;
            labCaption.ForeColor = _clrComm;
        }

        /// <summary>
        /// 因为strCaption对汉字字串获取Sizef不准确，需要修补。
        /// </summary>
        /// <param name="strCaption"></param>
        /// <returns></returns>
        private string GetShowedCaption( string strCaption )
        {
            string strRet = strCaption;

            int nLen = strCaption.Length;
            if ( nLen == 2 )
                strRet = "  " + strCaption;
            if ( nLen == 3 )
                strRet = " " + strCaption;
            if ( nLen == 4 )
                strRet = "" + strCaption;

            return strRet;
        }

        private int GetLableW()
        {
            string strCaption = labCaption.Text.Trim();
            Font font = labCaption.Font;

            Graphics graphics = CreateGraphics();
            SizeF sizeF = graphics.MeasureString( strCaption, font );
            graphics.Dispose();

            return (int)sizeF.Width;
        }

        #endregion

        #region 点击执行相关

        private void OnMouseDown( MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
            {
                ClickBtn();
            }
            else if ( e.Button == MouseButtons.Right )
            {
                DisbleMenu();
            }
        }

        private void ClickBtn()
        {
            if ( hasMenu )
                ShowMenu();
            else
                ExcutCommand();
        }

        void ShowMenu()
        {
            ContextMenuStrip = _Menu;
            ContextMenuStrip.Show( this, new Point( 0, this.Size.Height +5 ) );
        }

        private void DisbleMenu()
        {
            ContextMenuStrip = null;
        }

        private void ExcutCommand( int nCommand )
        {
            GL.Command.Excute(nCommand);
        }

        private void ExcutCommand()
        {
            ExcutCommand( _nCommandId );
        }

        #endregion





    }
}
