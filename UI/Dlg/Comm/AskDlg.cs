using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Dlg
{
    public partial class AskDlg : Form
    {
        public AskDlg()
        {
            InitializeComponent();
        }

        public string strNote
        {
            set
            {
                Text = String.Empty;
                txtNote.Text = value;
            }
        }

        #region Event

        private void CommDlg_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void CommDlg_Resize( object sender, EventArgs e )
        {
            OnSize();
        }

        private void btnOK_Click( object sender, EventArgs e )
        {
            OK();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {

        }

        #endregion

        private void LoadForm()
        {
            InitForm();
            OnSize();
        }

        private void OnSize()
        {
            int JG = 100;               //2个按钮之间的横向间距
            int AllW = this.Width;
            int btnW = btnOK.Width;

            int X = ( AllW - btnW * 2 - JG ) / 2;
            int Y = btnOK.Location.Y;

            btnOK.Location = new Point( X, Y );
            X += btnW + JG;
            btnCancel.Location = new Point( X , Y );
        }

        #region virtual protected

        virtual protected void InitForm()
        {
        }

        virtual protected void OK()
        {

        }

        #endregion

        #region protected

        protected void Close_None()
        {
            DialogResult = DialogResult.None;
        }

        protected void Close_OK()
        {
            DialogResult = DialogResult.OK;
        }

        #endregion
    }
}
