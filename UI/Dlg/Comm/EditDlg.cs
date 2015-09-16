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
    public partial class EditDlg : Form
    {
        public EditDlg()
        {
            InitializeComponent();
        }

        public string Caption
        {
            set
            {
                Text = String.Empty;
                labCaption.Text = value;
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
            Save();
        }

        private void btnDelete_Click( object sender, EventArgs e )
        {
            Delete();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {

        }

        #endregion

        private void LoadForm()
        {
            InitForm();
            OnSize();

            btnDelete.clrBK = Def.Style.SysColor.Btn_Delete_BK;
        }

        private void OnSize()
        {
            int JG = 60;               //2个按钮之间的横向间距
            int AllW = this.Width;
            int btnW = btnOK.Width;

            int X = ( AllW - btnW * 3 - JG*2 ) / 2;
            int Y = btnOK.Location.Y;

            btnOK.Location = new Point( X, Y );
            X += btnW + JG;
            btnDelete.Location = new Point( X, Y );
            X += btnW + JG;
            btnCancel.Location = new Point( X , Y );
        }

        #region virtual protected

        virtual protected void InitForm()
        {
        }

        virtual protected void Save()
        {

        }

        virtual protected void Delete()
        {

        }

        #endregion

        #region protected

        protected void SetChild( UserControl uc )
        {
            //uc.TopLevel = false;
            uc.Parent = pnlContent;
            Dock = DockStyle.Fill;
        }

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
