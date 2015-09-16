using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;

namespace 福田民政.Layout.LeftPnl.技术支持
{
    public partial class Wnd : XLeftPnl
    {
        public Wnd()
        {
            InitializeComponent();
        }

        override protected void Init()
        {
            lstMenu = Def.Menu.LeftMenu.技术支持;
            Def.Act.Menu.Entry_技术支持_版本更新 += Call;
            Def.Act.Menu.Entry_技术支持_问题反馈 += Call;
        }

    }
}
