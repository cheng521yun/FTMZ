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
    public partial class SmallIconBtn : UserControl
    {
        public Def.dlgt.Act dlgtRun = null;

        private Image _imgComm = null ;

        private Color _clrComm = Color.Black;  //Color.Blue;
        private Color _clrHove = Color.LightBlue;  //Color.DarkGreen;

        private int _nCommandId = -1;

        public SmallIconBtn()
        {
            InitializeComponent();
        }

        #region 属性

        public string BtnTexT
        {
            set { labText.Text = value; }
            get { return labText.Text; }
        }

        public Image BtnImg
        {
            set { this.picbox.Image = value; }
            get { return this.picbox.Image ; }
        }

        public int CommandId
        {
            set { _nCommandId = value; }
            get { return _nCommandId; }
        }

        #endregion

        #region Event

        private void TopMenuBtn_Load( object sender, EventArgs e )
        {
        }

        private void TopMenuBtn_SizeChanged( object sender, EventArgs e )
        {
            //ChangeSize();
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

        public void Set( Image imgComm, string strCaption, int nComandId)
        {
            _imgComm = imgComm;

            if (_imgComm != null)
                picbox.Image = _imgComm;

            labText.Text = strCaption;

            _nCommandId = nComandId;

        }


        #endregion

        #region 显示相关

        private void MouseFocus()
        {
            Cursor = Cursors.Hand;
            labText.ForeColor = _clrHove;
        }

        private void MouseUnFocus()
        {
            Cursor = Cursors.Default;
            labText.ForeColor = _clrComm;
        }

        #endregion

        #region 点击执行相关

        private void OnMouseDown( MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
            {
                ClickBtn();
            }
        }

        private void ClickBtn()
        {
            if (dlgtRun != null)
                dlgtRun();

            if ( _nCommandId != -1 )
                ExcutCommand();
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
