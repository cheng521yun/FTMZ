using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Def.Delegt;

namespace Def
{
    static public class CommandId_Act
    {
        static List<COMMANDID_ACT_UNIT> lst = new List<COMMANDID_ACT_UNIT>()
                        {
                            new COMMANDID_ACT_UNIT( Def.CommandId.首页, Def.Delegate.Act.Entry_首页 ),

                            //数据管理  ------------------------------------------------------------------------------------------------
                            
                            //老龄办
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_老龄办, Def.Delegate.Act.Entry_数据管理_老龄办 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_老龄办_老龄优待证_发放, Def.Delegate.Act.Entry_数据管理_老龄办_老龄优待证_发放 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_老龄办_老龄优待证_统计, Def.Delegate.Act.Entry_数据管理_老龄办_老龄优待证_统计 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_老龄办_老龄津贴_发放, Def.Delegate.Act.Entry_数据管理_老龄办_老龄津贴_发放 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_老龄办_老龄津贴_停发, Def.Delegate.Act.Entry_数据管理_老龄办_老龄津贴_停发 ),
                            
                            //民管局
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_民管局, Def.Delegate.Act.Entry_数据管理_民管局 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_民管局_登记备案, Def.Delegate.Act.Entry_数据管理_民管局_登记备案 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_民管局_台账列表, Def.Delegate.Act.Entry_数据管理_民管局_台账列表 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_民管局_台账统计, Def.Delegate.Act.Entry_数据管理_民管局_台账统计 ),

                            //事务科
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_事务科, Def.Delegate.Act.Entry_数据管理_事务科 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_事务科_社会救助, Def.Delegate.Act.Entry_数据管理_事务科_社会救助 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_事务科_临时救助, Def.Delegate.Act.Entry_数据管理_事务科_临时救助 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_事务科_居家养老服务补贴, Def.Delegate.Act.Entry_数据管理_事务科_居家养老服务补贴 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_事务科_救助统计, Def.Delegate.Act.Entry_数据管理_事务科_救助统计 ),

                            //基层科
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_基层科, Def.Delegate.Act.Entry_数据管理_基层科 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_基层科_民主管理信息管理, Def.Delegate.Act.Entry_数据管理_基层科_民主管理信息管理 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_基层科_社区建设信息管理, Def.Delegate.Act.Entry_数据管理_基层科_社区建设信息管理 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_基层科_社区服务信息管理, Def.Delegate.Act.Entry_数据管理_基层科_社区服务信息管理 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_基层科_数据统计, Def.Delegate.Act.Entry_数据管理_基层科_数据统计 ),

                            //优抚科
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_优抚科, Def.Delegate.Act.Entry_数据管理_优抚科 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_优抚科_优抚对象_登记, Def.Delegate.Act.Entry_数据管理_优抚科_优抚对象_登记 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_优抚科_优抚对象_查询, Def.Delegate.Act.Entry_数据管理_优抚科_优抚对象_查询 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_优抚科_伤残物品_登记, Def.Delegate.Act.Entry_数据管理_优抚科_伤残物品_登记 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_优抚科_伤残物品_发放, Def.Delegate.Act.Entry_数据管理_优抚科_伤残物品_发放 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_优抚科_抚恤标准管理, Def.Delegate.Act.Entry_数据管理_优抚科_抚恤标准管理 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_优抚科_优抚资金发放, Def.Delegate.Act.Entry_数据管理_优抚科_优抚资金发放 ),
                            
                            //福利中心
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_福利中心, Def.Delegate.Act.Entry_数据管理_福利中心 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_福利中心_老人入住管理, Def.Delegate.Act.Entry_数据管理_福利中心_老人入住管理 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_福利中心_老人退住管理, Def.Delegate.Act.Entry_数据管理_福利中心_老人退住管理 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_福利中心_老人费用管理_费用登记, Def.Delegate.Act.Entry_数据管理_福利中心_老人费用管理_费用登记 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_福利中心_老人费用管理_退费登记, Def.Delegate.Act.Entry_数据管理_福利中心_老人费用管理_退费登记 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据管理_福利中心_老人费用统计, Def.Delegate.Act.Entry_数据管理_福利中心_老人费用统计 ),




                            //数据分析  ------------------------------------------------------------------------------------------------
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据分析_老龄办, Def.Delegate.Act.Entry_数据分析_老龄办 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据分析_民管局, Def.Delegate.Act.Entry_数据分析_民管局 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据分析_事务科, Def.Delegate.Act.Entry_数据分析_事务科 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据分析_基层科, Def.Delegate.Act.Entry_数据分析_基层科 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据分析_优抚科, Def.Delegate.Act.Entry_数据分析_优抚科 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.数据分析_福利中心, Def.Delegate.Act.Entry_数据分析_福利中心 ),

                            //日志管理
                            new COMMANDID_ACT_UNIT( Def.CommandId.日志管理_登录日志, Def.Delegate.Act.Entry_日志管理_登录日志 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.日志管理_操作日志, Def.Delegate.Act.Entry_日志管理_操作日志 ),

                            //系统配置
                            new COMMANDID_ACT_UNIT( Def.CommandId.系统配置_参数设置, Def.Delegate.Act.Entry_系统配置_参数设置 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.系统配置_个性化, Def.Delegate.Act.Entry_系统配置_个性化 ),

                            //技术支持
                            new COMMANDID_ACT_UNIT( Def.CommandId.技术支持_版本更新, Def.Delegate.Act.Entry_技术支持_版本更新 ),
                            new COMMANDID_ACT_UNIT( Def.CommandId.技术支持_问题反馈, Def.Delegate.Act.Entry_技术支持_问题反馈 ),
                        };


        static public dlgt.ActionParam GetAct( int nCommand )
        {
            foreach ( COMMANDID_ACT_UNIT Unit in lst )
            {
                if ( Unit.nCommandId == nCommand )
                    return Unit.Act;
            }

            return null;
        }
    }

    public class COMMANDID_ACT_UNIT
    {
        public COMMANDID_ACT_UNIT( int nCommandId, dlgt.ActionParam Act )
        {
            this.nCommandId = nCommandId;
            this.Act = Act;
        }

        public int nCommandId;
        public dlgt.ActionParam Act;
    }
}
