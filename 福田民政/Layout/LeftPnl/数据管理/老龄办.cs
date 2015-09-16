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
    public partial class 老龄办 : XLeftPnl
    {
        public 老龄办()
        {
            InitializeComponent();
        }

        override protected void Init()
        {
            //lstMenu = Def.Menu.LeftMenu.数据管理_老龄办;
            Def.Act.Menu.Entry_数据管理_老龄办 += Call;

            InitTree();
        }

        private void InitTree()
        {
            MenuTree.SetMenu( Def.Pair.MenuCommand.老龄办.MainMenu );

            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.老龄办.NodeNo_Main.老龄优待证, Def.Pair.MenuCommand.老龄办.老龄优待证 );
            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.老龄办.NodeNo_Main.老龄津贴, Def.Pair.MenuCommand.老龄办.老龄津贴 );
        }
    }
}
