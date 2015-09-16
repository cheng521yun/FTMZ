using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;

namespace 福田民政.Layout.LeftPnl.数据管理
{
    public partial class 福利中心 : XLeftPnl
    {
        public 福利中心()
        {
            InitializeComponent();
        }

        override protected void Init()
        {
            //lstMenu = Def.Menu.LeftMenu.数据管理_福利中心;
            Def.Act.Menu.Entry_数据管理_福利中心 += Call; ;

            InitTree();
        }

        private void InitTree()
        {
            MenuTree.SetMenu( Def.Pair.MenuCommand.福利中心.MainMenu );

            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.福利中心.NodeNo_Main.老人入退住管理, Def.Pair.MenuCommand.福利中心.老人入退住管理 );
            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.福利中心.NodeNo_Main.老人费用管理, Def.Pair.MenuCommand.福利中心.老人费用管理 );
        }

    }
}
