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

namespace 福田民政.Forms.日志管理
{
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        private void Wnd_Load( object sender, EventArgs e )
        {
            InitForm();
        }

        private void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.日志管理.登录日志 ), Def.FormId.日志管理_登录日志 );
            AddFormList( typeof( 福田民政.Forms.日志管理.操作日志 ), Def.FormId.日志管理_操作日志 );
        }

        //private void Call( object obj )
        //{
        //    //MessageBox.Show( "in 老龄办" );

        //    ShowMe();
        //}

        public override void ShowWnd()
        {
            Show();

            if ( GL.User.Role != "系统管理" )
                GL.Command.Excute( Def.Command.Menu.首页 );
        }
    }
}
