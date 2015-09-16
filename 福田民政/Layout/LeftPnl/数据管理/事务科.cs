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
    public partial class 事务科 : XLeftPnl
    {
        public 事务科()
        {
            InitializeComponent();
        }

        override protected void Init()
        {
            //lstMenu = Def.Menu.LeftMenu.数据管理_事务科;
            Def.Act.Menu.Entry_数据管理_事务科 += Call; ;

            InitTree();
        }

        private void InitTree()
        {
            MenuTree.SetMenu( Def.Pair.MenuCommand.事务科.MainMenu );
        }

    }
}
