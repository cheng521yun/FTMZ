using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrontFlag.Control.Menu;

namespace Def.Menu
{
    public class LeftMenu
    {
        #region 数据管理

        static public List<XToolStripMenuItem> 数据管理_老龄办 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "老龄优待证 发放", Def.Command.Menu.数据管理_老龄办_老龄优待证_发放 ),
                            new XToolStripMenuItem( "老龄优待证 统计", Def.Command.Menu.数据管理_老龄办_老龄优待证_统计 ),
                            new XToolStripMenuItem( "老龄津贴 发放", Def.Command.Menu.数据管理_老龄办_老龄津贴_发放 ),
                            new XToolStripMenuItem( "老龄津贴 统计", Def.Command.Menu.数据管理_老龄办_老龄津贴_统计 ),
                            new XToolStripMenuItem( "老龄津贴 停发", Def.Command.Menu.数据管理_老龄办_老龄津贴_停发 ),
                        };

        static public List<XToolStripMenuItem> 数据管理_民管局 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "登记备案 民非", Def.Command.Menu.数据管理_民管局_登记备案_民非 ),
                            new XToolStripMenuItem( "登记备案 社团", Def.Command.Menu.数据管理_民管局_登记备案_社团 ),
                            new XToolStripMenuItem( "注销备案 民非", Def.Command.Menu.数据管理_民管局_注销备案_民非 ),
                            new XToolStripMenuItem( "注销备案 社团", Def.Command.Menu.数据管理_民管局_注销备案_社团 ),
                            //new XToolStripMenuItem( "台账列表", Def.Command.Menu.数据管理_民管局_台账列表 ),
                            //new XToolStripMenuItem( "台账统计", Def.Command.Menu.数据管理_民管局_台账统计 ),
                            
                        };

        static public List<XToolStripMenuItem> 数据管理_事务科 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "低收入居民数据", Def.Command.Menu.数据管理_事务科_低收入居民数据 ),
                            new XToolStripMenuItem( "专项救助数据", Def.Command.Menu.数据管理_事务科_专项救助数据 ),
                            new XToolStripMenuItem( "居家养老服务补贴", Def.Command.Menu.数据管理_事务科_居家养老服务补贴 ),
                            new XToolStripMenuItem( "救助统计", Def.Command.Menu.数据管理_事务科_救助统计 ),
                        };

        static public List<XToolStripMenuItem> 数据管理_基层科 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "民主管理信息管理", Def.Command.Menu.数据管理_基层科_民主管理信息管理 ),
                            new XToolStripMenuItem( "社区建设信息管理", Def.Command.Menu.数据管理_基层科_社区建设信息管理 ),
                            new XToolStripMenuItem( "社区服务信息管理", Def.Command.Menu.数据管理_基层科_社区服务信息管理 ),
                            new XToolStripMenuItem( "数据统计", Def.Command.Menu.数据管理_基层科_数据统计 ),
                        };

        static public List<XToolStripMenuItem> 数据管理_福利中心 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "老人入住管理", Def.Command.Menu.数据管理_福利中心_老人入住管理 ),
                            new XToolStripMenuItem( "老人退住管理", Def.Command.Menu.数据管理_福利中心_老人退住管理 ),
                            new XToolStripMenuItem( "老人费用管理 记费", Def.Command.Menu.数据管理_福利中心_老人费用管理_费用登记 ),
                            new XToolStripMenuItem( "老人费用管理 退费", Def.Command.Menu.数据管理_福利中心_老人费用管理_退费登记 ),
                            new XToolStripMenuItem( "老人费用统计", Def.Command.Menu.数据管理_福利中心_老人费用统计 ),
                        };

        static public List<XToolStripMenuItem> 数据管理_优抚科 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "优抚对象 登记", Def.Command.Menu.数据管理_优抚科_优抚对象_登记 ),
                            new XToolStripMenuItem( "优抚对象 查询", Def.Command.Menu.数据管理_优抚科_优抚对象_查询 ),
                            new XToolStripMenuItem( "伤残物品 登记", Def.Command.Menu.数据管理_优抚科_伤残物品_登记 ),
                            new XToolStripMenuItem( "伤残物品 发放", Def.Command.Menu.数据管理_优抚科_伤残物品_发放 ),
                            new XToolStripMenuItem( "抚恤标准管理", Def.Command.Menu.数据管理_优抚科_抚恤标准管理 ),
                            new XToolStripMenuItem( "优抚资金发放", Def.Command.Menu.数据管理_优抚科_优抚资金发放 ),
                        };

        #endregion

        #region 日志管理

        static public List<XToolStripMenuItem> 日志管理 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "登录日志", Def.Command.Menu.日志管理_登录日志 ),
                            new XToolStripMenuItem( "操作日志", Def.Command.Menu.日志管理_操作日志 ),
                        };

        #endregion

        #region 系统配置

        static public List<XToolStripMenuItem> 系统配置 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "用户管理", Def.Command.Menu.系统配置_用户管理 ),
                            new XToolStripMenuItem( "权限管理", Def.Command.Menu.系统配置_权限管理 ),
                            new XToolStripMenuItem( "参数管理", Def.Command.Menu.系统配置_参数管理 ),
                        };

        #endregion

        #region 技术支持

        static public List<XToolStripMenuItem> 技术支持 = new List<XToolStripMenuItem>()
                        {  
                            new XToolStripMenuItem( "版本更新", Def.Command.Menu.技术支持_版本更新 ),
                            new XToolStripMenuItem( "问题反馈", Def.Command.Menu.技术支持_问题反馈 ),
                        };

        #endregion


    }
}
