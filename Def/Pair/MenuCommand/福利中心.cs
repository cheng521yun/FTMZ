using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Pair.MenuCommand
{
    public class 福利中心
    {
        public enum NodeNo_Main
        {
            老人入退住管理 = 0,
            老人费用管理 = 1,
        };

        static public List<MENU_COMMAND> MainMenu = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "老人入退住管理", nCommand = Def.Command.Menu.数据管理_福利中心_老人入住管理 },
                new MENU_COMMAND() { MenuText = "老人费用管理", nCommand = Def.Command.Menu.数据管理_福利中心_老人费用管理_费用登记 },
            };

        static public List<MENU_COMMAND> 老人入退住管理 = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "老人入住", nCommand = Def.Command.Menu.数据管理_福利中心_老人入住管理 },
                new MENU_COMMAND() { MenuText = "老人退住", nCommand = Def.Command.Menu.数据管理_福利中心_老人退住管理 },
            };

        static public List<MENU_COMMAND> 老人费用管理 = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "费用登记", nCommand = Def.Command.Menu.数据管理_福利中心_老人费用管理_费用登记 },
                new MENU_COMMAND() { MenuText = "退费登记", nCommand = Def.Command.Menu.数据管理_福利中心_老人费用管理_退费登记 },
                new MENU_COMMAND() { MenuText = "费用统计", nCommand = Def.Command.Menu.数据管理_福利中心_老人费用统计 },
            };
    }
}
