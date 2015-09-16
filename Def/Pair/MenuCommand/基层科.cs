using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Pair.MenuCommand
{
    public class 基层科
    {
        static public List<MENU_COMMAND> MainMenu = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "民主管理信息管理", nCommand = Def.Command.Menu.数据管理_基层科_民主管理信息管理 },
                new MENU_COMMAND() { MenuText = "社区建设信息管理", nCommand = Def.Command.Menu.数据管理_基层科_社区建设信息管理 },
                new MENU_COMMAND() { MenuText = "社区服务信息管理", nCommand = Def.Command.Menu.数据管理_基层科_社区服务信息管理 },
                new MENU_COMMAND() { MenuText = "数据统计", nCommand = Def.Command.Menu.数据管理_基层科_数据统计 },
            };
    }
}
