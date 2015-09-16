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
    public partial class 民管局 : XLeftPnl
    {
        public 民管局()
        {
            InitializeComponent();
        }

        override protected void Init()
        {
            //lstMenu = Def.Menu.LeftMenu.数据管理_民管局;
            Def.Act.Menu.Entry_数据管理_民管局 += Call; ;

            InitTree();
        }

        private void InitTree()
        {
            MenuTree.SetMenu( Def.Pair.MenuCommand.民管局.MainMenu );

            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.民管局.NodeNo_Main.备案, Def.Pair.MenuCommand.民管局.备案 );
            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.民管局.NodeNo_Main.注销, Def.Pair.MenuCommand.民管局.注销 );
        }
    }
}
