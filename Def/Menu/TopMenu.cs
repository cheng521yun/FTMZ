using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag.Control.Menu;

namespace Def.Menu
{
    public class TopMenu
    {
        static public List<XToolStripMenuItem> 数据管理 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "老龄办", Def.Command.Menu.数据管理_老龄办 ),
                            new XToolStripMenuItem( "民管局", Def.Command.Menu.数据管理_民管局),
                            new XToolStripMenuItem( "事务科", Def.Command.Menu.数据管理_事务科 ),
                            new XToolStripMenuItem( "基层科", Def.Command.Menu.数据管理_基层科  ),
                            new XToolStripMenuItem( "优抚科", Def.Command.Menu.数据管理_优抚科 ),
                            new XToolStripMenuItem( "福利中心", Def.Command.Menu.数据管理_福利中心 ),
                        };

        static public List<XToolStripMenuItem> 数据分析 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "老龄办", Def.Command.Menu.数据分析_老龄办 ),
                            new XToolStripMenuItem( "民管局", Def.Command.Menu.数据分析_民管局 ),
                            new XToolStripMenuItem( "事务科", Def.Command.Menu.数据分析_事务科 ),
                            new XToolStripMenuItem( "基层科", Def.Command.Menu.数据分析_基层科 ),
                            new XToolStripMenuItem( "优抚科", Def.Command.Menu.数据分析_优抚科 ),
                            new XToolStripMenuItem( "福利中心", Def.Command.Menu.数据分析_福利中心 ),
                        };

        static public List<XToolStripMenuItem> 日志管理 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "登录日志", Def.Command.Menu.日志管理_登录日志 ),
                            new XToolStripMenuItem( "操作日志", Def.Command.Menu.日志管理_操作日志 ),
                            
                        };

        static public List<XToolStripMenuItem> 系统配置 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "用户管理", Def.Command.Menu.系统配置_用户管理 ),
                            new XToolStripMenuItem( "权限管理", Def.Command.Menu.系统配置_权限管理 ),
                            new XToolStripMenuItem( "参数管理", Def.Command.Menu.系统配置_参数管理 ),
                        };

        static public List<XToolStripMenuItem> 技术支持 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "版本更新", Def.Command.Menu.技术支持_版本更新 ),
                            new XToolStripMenuItem( "问题反馈", Def.Command.Menu.技术支持_问题反馈 ),
                        };

        static public List<XToolStripMenuItem> 数据交换 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "Excel方式", Def.Command.Menu.数据交换_Excel方式 ),
                            new XToolStripMenuItem( "前置机方式", Def.Command.Menu.数据交换_前置机方式 ),
                        };

        //static public List<XToolStripMenuItem> 回收站 = new List<XToolStripMenuItem>()
        //                {  
        //                    new XToolStripMenuItem( "老龄办6", Def.Command.Menu.Test ),
        //                    new XToolStripMenuItem( "民管局6", Def.Command.Menu.Test ),
        //                    new XToolStripMenuItem( "事务科6", Def.Command.Menu.Test ),
        //                };

    }
}
