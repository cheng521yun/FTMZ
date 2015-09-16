using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.系统配置.权限管理
{
    public partial class Wnd : WorkForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        //private void Wnd_Load( object sender, EventArgs e )
        //{

        //}

        protected override void Init()
        {
            strCaption = "系统配置 权限管理";
            Def.Act.Menu.Entry_系统配置_权限管理 += Call;
        }
    }
}
