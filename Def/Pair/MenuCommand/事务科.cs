using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Pair.MenuCommand
{
    public class 事务科
    {
        static public List<MENU_COMMAND> MainMenu = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "低收入居民数据", nCommand = Def.Command.Menu.数据管理_事务科_低收入居民数据 },
                new MENU_COMMAND() { MenuText = "专项救助数据", nCommand = Def.Command.Menu.数据管理_事务科_专项救助数据 },
                new MENU_COMMAND() { MenuText = "居家养老服务补贴", nCommand = Def.Command.Menu.数据管理_事务科_居家养老服务补贴 },
                new MENU_COMMAND() { MenuText = "救助统计", nCommand = Def.Command.Menu.数据管理_事务科_救助统计 },
            };
    }
}
