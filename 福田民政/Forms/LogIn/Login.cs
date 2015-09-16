using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DB.Stru;
using FrontFlag;
using Global;

namespace 福田民政.Forms.LogIn
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void Login_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        #region 属性

        public bool bCheckOK
        {
            get { return GL.User.IsValid(); }
        }

        #endregion

        private void LoadForm()
        {
        }

        #region Event

        private void btnLogin_Click( object sender, EventArgs e )
        {
            Login();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            Close();
        }

        #endregion

        private void Login()
        {
            string strUser = txtUser.Text.Trim();
            string strPass = txtPassword.Text.Trim();

            bool bLogin = false;
            DB.Stru.USER struUser = Buss.BL.User.Check( strUser, strPass, ref bLogin );
            struUser = Buss.BL.User.GetEx_ByUserName(struUser.Name);
            GL.User = struUser;

            if (!bLogin)
            {
                FF.Ctrl.MsgBox.ShowWarn("抱歉，输入的账号或密码不正确！\n请重新输入。");
            }

            DialogResult = bLogin ? DialogResult.OK : DialogResult.None;



            return ;
        }

        private void txtUser_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
