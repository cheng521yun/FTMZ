using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;
using Global;

namespace 福田民政.Forms.系统配置
{
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        private void Wnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitForm();
        }

        private void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.Work.系统配置.用户管理.Wnd ), Def.FormId.系统配置_用户管理 );
            AddFormList( typeof( 福田民政.Forms.Work.系统配置.权限管理.Wnd ), Def.FormId.系统配置_权限管理 );
            AddFormList( typeof( 福田民政.Forms.Work.系统配置.参数管理.Wnd ), Def.FormId.系统配置_参数管理 );
        }

        public override void ShowWnd()
        {
            Show();
           
            if ( GL.User.Role!= "系统管理" )
                GL.Command.Excute( Def.Command.Menu.首页 );
        }
    }
}
