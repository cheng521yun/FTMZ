using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Def.Pair.MenuCommand;
using FrontFlag;
using FrontFlag.Control;
using Global;

namespace 福田民政.Layout.LeftPnl.数据管理
{
    public partial class 优抚科 : XLeftPnl
    {
        public 优抚科()
        {
            InitializeComponent();
        }

        override protected void Init()
        {
            //lstMenu = Def.Menu.LeftMenu.数据管理_优抚科;
            Def.Act.Menu.Entry_数据管理_优抚科 += Call; 

            InitTree();
        }

        private void InitTree()
        {
            MenuTree.SetMenu( Def.Pair.MenuCommand.优抚科.MainMenu );

            //优抚对象登记
            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.优抚科.NodeNo_Main.优抚对象登记, Def.Pair.MenuCommand.优抚科.优抚对象 );

            //伤残物品登记
            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.优抚科.NodeNo_Main.伤残物品登记, Def.Pair.MenuCommand.优抚科.伤残物品登记 );
            
            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.优抚科.NodeNo_Main.伤残物品登记, (int)Def.Pair.MenuCommand.优抚科.NodeNo_伤残物品登记.假肢类, Def.Pair.MenuCommand.优抚科.伤残物品登记_假肢类 );
            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.优抚科.NodeNo_Main.伤残物品登记, (int)Def.Pair.MenuCommand.优抚科.NodeNo_伤残物品登记.矫形器类, Def.Pair.MenuCommand.优抚科.伤残物品_矫形器类 );
            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.优抚科.NodeNo_Main.伤残物品登记, (int)Def.Pair.MenuCommand.优抚科.NodeNo_伤残物品登记.助行器具类, Def.Pair.MenuCommand.优抚科.伤残物品_助行器具类 );
            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.优抚科.NodeNo_Main.伤残物品登记, (int)Def.Pair.MenuCommand.优抚科.NodeNo_伤残物品登记.助听器类, Def.Pair.MenuCommand.优抚科.伤残物品_助听器类 );
            MenuTree.SetSubMenu( (int)Def.Pair.MenuCommand.优抚科.NodeNo_Main.伤残物品登记, (int)Def.Pair.MenuCommand.优抚科.NodeNo_伤残物品登记.其他辅助类, Def.Pair.MenuCommand.优抚科.伤残物品_其它辅助类 );
        }


    }
}
