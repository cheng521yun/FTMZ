using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Pair.MenuCommand
{
    public class 民管局
    {
        public enum NodeNo_Main
        {
            备案 = 0,
            注销 = 1,
        };

        //static public List<MENU_COMMAND> MainMenu = new List<MENU_COMMAND>()
        //    {
        //        new MENU_COMMAND() { MenuText = "民非", nCommand = Def.Command.Menu.数据管理_民管局_登记备案_民非 },
        //        new MENU_COMMAND() { MenuText = "社团", nCommand = Def.Command.Menu.数据管理_民管局_登记备案_社团 },
        //    };


        static public List<MENU_COMMAND> MainMenu = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "备案", nCommand = Def.Command.Menu.None },
                new MENU_COMMAND() { MenuText = "注销", nCommand = Def.Command.Menu.None },
            };

        static public List<MENU_COMMAND> 备案 = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "民非", nCommand = Def.Command.Menu.数据管理_民管局_登记备案_民非 },
                new MENU_COMMAND() { MenuText = "社团", nCommand = Def.Command.Menu.数据管理_民管局_登记备案_社团 },
            };

        static public List<MENU_COMMAND> 注销 = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "民非", nCommand = Def.Command.Menu.数据管理_民管局_注销备案_民非 },
                new MENU_COMMAND() { MenuText = "社团", nCommand = Def.Command.Menu.数据管理_民管局_注销备案_社团 },
            };
    }
}
