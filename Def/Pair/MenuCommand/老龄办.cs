using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Pair.MenuCommand
{
    public class 老龄办
    {
        public enum NodeNo_Main
        {
            老龄优待证 = 0,
            老龄津贴 = 1,
        };

        static public List<MENU_COMMAND> MainMenu = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "老龄优待证", nCommand = Def.Command.Menu.数据管理_老龄办_老龄优待证_发放 },
                new MENU_COMMAND() { MenuText = "老龄津贴", nCommand = Def.Command.Menu.数据管理_老龄办_老龄津贴_发放 },
            };

        static public List<MENU_COMMAND> 老龄优待证 = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "发放", nCommand = Def.Command.Menu.数据管理_老龄办_老龄优待证_发放 },
                new MENU_COMMAND() { MenuText = "统计", nCommand = Def.Command.Menu.数据管理_老龄办_老龄优待证_统计 },
            };

        static public List<MENU_COMMAND> 老龄津贴 = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "发放", nCommand = Def.Command.Menu.数据管理_老龄办_老龄津贴_发放 },
                new MENU_COMMAND() { MenuText = "统计", nCommand = Def.Command.Menu.数据管理_老龄办_老龄津贴_统计 },
                new MENU_COMMAND() { MenuText = "停发", nCommand = Def.Command.Menu.数据管理_老龄办_老龄津贴_停发 },
            };

    }
}
