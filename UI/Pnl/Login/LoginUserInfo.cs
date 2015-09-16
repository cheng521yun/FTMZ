using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Global;

namespace UI.Pnl.Login
{
    public partial class LoginUserInfo : UserControl
    {
        public LoginUserInfo()
        {
            InitializeComponent();
        }

        #region 属性

        public string strUser
        {
            set { labUser.Text = value; }
        }

        #endregion

        private void LoginUserInfo_Load( object sender, EventArgs e )
        {
            Def.Act.Sys.ChangeLoginUser += Call;
        }

        private void Call( string strUser )
        {
            labUser.Text = strUser;
        }
    }
}
