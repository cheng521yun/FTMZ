using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;

namespace 福田民政.Layout.LeftPnl.系统配置
{
    public partial class Wnd : XLeftPnl
    {
        public Wnd()
        {
            InitializeComponent();
        }

        override protected void Init()
        {
            lstMenu = Def.Menu.LeftMenu.系统配置;
            Def.Act.Menu.Entry_系统配置_用户管理 += Call;
            Def.Act.Menu.Entry_系统配置_权限管理 += Call;
            Def.Act.Menu.Entry_系统配置_参数管理 += Call;
        }

    }
}
