using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Layout.LeftPnl.日志管理
{
    public partial class Wnd : XLeftPnl
    {
        public Wnd()
        {
            InitializeComponent();
        }

        override protected void Init()
        {
            lstMenu = Def.Menu.LeftMenu.日志管理;
            Def.Act.Menu.Entry_日志管理_登录日志 += Call;
            Def.Act.Menu.Entry_日志管理_操作日志 += Call; 
        }

    }
}
