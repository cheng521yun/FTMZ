using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Pair.MenuCommand
{
    public class 优抚科
    {
        public enum NodeNo_Main
        {
            优抚对象登记 = 0,
            伤残物品登记 = 2,
        };

        static public List<MENU_COMMAND> MainMenu = new List<MENU_COMMAND>()
            {
                new MENU_COMMAND() { MenuText = "优抚对象 登记", nCommand = Def.Command.Menu.数据管理_优抚科_优抚对象_登记 },
                new MENU_COMMAND() { MenuText = "优抚对象 查询", nCommand = Def.Command.Menu.数据管理_优抚科_优抚对象_查询 },
                new MENU_COMMAND() { MenuText = "伤残物品 登记", nCommand = Def.Command.Menu.数据管理_优抚科_伤残物品_登记 },
                new MENU_COMMAND() { MenuText = "伤残物品 发放", nCommand = Def.Command.Menu.数据管理_优抚科_伤残物品_发放 },
                new MENU_COMMAND() { MenuText = "抚恤标准管理", nCommand = Def.Command.Menu.数据管理_优抚科_抚恤标准管理 },
                new MENU_COMMAND() { MenuText = "优抚资金发放", nCommand = Def.Command.Menu.数据管理_优抚科_优抚资金发放 },
            };


        public static List<MENU_COMMAND> 优抚对象
        {
            get
            {
                return MENU_COMMAND.GetMenuCommandList( Def.Command.Menu.数据管理_优抚科_优抚对象_登记, Def.Strs.优抚科.优抚对象.对象类别 ); 
            }
        }

        public enum NodeNo_伤残物品登记
        {
            假肢类 = 0,
            矫形器类 = 1,
            助行器具类 = 2,
            助听器类 = 3,
            其他辅助类 = 4,
        };

        static public List<MENU_COMMAND> 伤残物品登记
        {
            get
            {
                return MENU_COMMAND.GetMenuCommandList( Def.Command.Menu.数据管理_优抚科_伤残物品_发放, Def.Strs.优抚科.伤残物品.伤残物品类别, false );
            }
        }

        static public List<MENU_COMMAND> 伤残物品登记_假肢类
        {
            get
            {
                return MENU_COMMAND.GetMenuCommandList( Def.Command.Menu.数据管理_优抚科_伤残物品_发放, Def.Strs.优抚科.伤残物品.伤残物品_假肢类 );
            }
        }

        static public List<MENU_COMMAND> 伤残物品_矫形器类
        {
            get
            {
                return MENU_COMMAND.GetMenuCommandList( Def.Command.Menu.数据管理_优抚科_伤残物品_发放, Def.Strs.优抚科.伤残物品.伤残物品_矫形器类 );
            }
        }

        static public List<MENU_COMMAND> 伤残物品_助行器具类
        {
            get
            {
                return MENU_COMMAND.GetMenuCommandList( Def.Command.Menu.数据管理_优抚科_伤残物品_发放, Def.Strs.优抚科.伤残物品.伤残物品_助行器具类 );
            }
        }

        static public List<MENU_COMMAND> 伤残物品_助听器类
        {
            get
            {
                return MENU_COMMAND.GetMenuCommandList( Def.Command.Menu.数据管理_优抚科_伤残物品_发放, Def.Strs.优抚科.伤残物品.伤残物品_助听器类 );
            }
        }

        static public List<MENU_COMMAND> 伤残物品_其它辅助类
        {
            get
            {
                return MENU_COMMAND.GetMenuCommandList( Def.Command.Menu.数据管理_优抚科_伤残物品_发放, Def.Strs.优抚科.伤残物品.伤残物品_其它辅助类 );
            }
        }
    }
}
