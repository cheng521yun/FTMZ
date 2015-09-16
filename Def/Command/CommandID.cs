using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def
{
    public class CommandId
    {
        static public int 首页 = 1000;


        //数据管理 ----------------------------------------------------------------
        static public int 数据管理 = 2000;

        //数据管理 老龄办
        static public int 数据管理_老龄办 = 2010;
            static public int 数据管理_老龄办_老龄优待证_发放 = 201010;
            static public int 数据管理_老龄办_老龄优待证_统计 = 201020;
            static public int 数据管理_老龄办_老龄津贴_发放 = 201030;
            static public int 数据管理_老龄办_老龄津贴_停发 = 201040;

        //数据管理 民管局
        static public int 数据管理_民管局 = 2020;
            static public int 数据管理_民管局_登记备案 = 202010;
            static public int 数据管理_民管局_台账列表 = 202020;
            static public int 数据管理_民管局_台账统计 = 202030;

        //数据管理 事务科
        static public int 数据管理_事务科 = 2030;
        static public int 数据管理_事务科_社会救助 = 203010;
        static public int 数据管理_事务科_临时救助 = 203020;
        static public int 数据管理_事务科_居家养老服务补贴 = 203030;
        static public int 数据管理_事务科_救助统计 = 203040;

        //数据管理 基层科
        static public int 数据管理_基层科 = 2040;
        static public int 数据管理_基层科_民主管理信息管理 = 204010;
        static public int 数据管理_基层科_社区建设信息管理 = 204020;
        static public int 数据管理_基层科_社区服务信息管理 = 204030;
        static public int 数据管理_基层科_数据统计 = 204040;

        //优抚科
        static public int 数据管理_优抚科 = 2050;
        static public int 数据管理_优抚科_优抚对象_登记 = 205010;
        static public int 数据管理_优抚科_优抚对象_查询 = 205011;
        static public int 数据管理_优抚科_伤残物品_登记 = 205020;
        static public int 数据管理_优抚科_伤残物品_发放 = 205021;
        static public int 数据管理_优抚科_抚恤标准管理 = 205030;
        static public int 数据管理_优抚科_优抚资金发放 = 205031;

        //福利中心
        static public int 数据管理_福利中心 = 2060;
        static public int 数据管理_福利中心_老人入住管理 = 206010;
        static public int 数据管理_福利中心_老人退住管理 = 206020;
        static public int 数据管理_福利中心_老人费用管理_费用登记 = 206030;
        static public int 数据管理_福利中心_老人费用管理_退费登记 = 206040;
        static public int 数据管理_福利中心_老人费用统计 = 206050;



        //数据分析 ----------------------------------------------------------------
        static public int 数据分析 = 3000;

        static public int 数据分析_老龄办 = 3010;
        static public int 数据分析_民管局 = 3020;
        static public int 数据分析_事务科 = 3030;
        static public int 数据分析_基层科 = 3040;
        static public int 数据分析_优抚科 = 3050;
        static public int 数据分析_福利中心 = 3060;

        //日志管理
        static public int 日志管理_登录日志 = 4010;
        static public int 日志管理_操作日志 = 4020;

        //系统配置
        static public int 系统配置_参数设置 = 5010;
        static public int 系统配置_个性化 = 5020;

        //技术支持
        static public int 技术支持_版本更新 = 6010;
        static public int 技术支持_问题反馈 = 6020;


        //test
        static public int Test = 9999;
        
    }
}
