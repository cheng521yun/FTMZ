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

namespace 福田民政.Forms.Work.数据交换
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
            Def.Act.Menu.Entry_数据交换_Excel方式 += Call;
        }

        void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.Work.数据交换.Excel.Wnd ), Def.FormId.数据交换_Excel );
            AddFormList( typeof( 福田民政.Forms.Work.数据交换.前置机.Wnd ), Def.FormId.数据交换_前置机 );
        }

        //private void Call( object obj )
        //{
        //    ShowDefaultForm();
        //}

        //private void ShowDefaultForm()
        //{
        //    GL.Command.Excute( Def.Command.Menu.数据交换_Excel方式 );
        //}

        private void Call( object obj )
        {
            if ( GL.User.Role != "系统管理" )
                GL.Command.Excute( Def.Command.Menu.首页 );

            ShowMe();
        }
    }
}
