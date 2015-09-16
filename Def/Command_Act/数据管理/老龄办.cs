using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Command_Act.数据管理
{
    public class 老龄办
    {
        public static List<COMMANDID_ACT_UNIT> lst = new List<COMMANDID_ACT_UNIT>()
            {
                new COMMANDID_ACT_UNIT(Def.Command.数据管理.老龄办.老龄优待证_发放, Def.Act.数据管理.老龄办.优待证_发放),
                new COMMANDID_ACT_UNIT(Def.Command.数据管理.老龄办.老龄优待证_停发, Def.Act.数据管理.老龄办.优待证_停发),
                new COMMANDID_ACT_UNIT(Def.Command.数据管理.老龄办.老龄优待证_查询, Def.Act.数据管理.老龄办.优待证_查询),

                new COMMANDID_ACT_UNIT(Def.Command.数据管理.老龄办.老龄津贴_发放, Def.Act.数据管理.老龄办.老龄津贴_发放),
                new COMMANDID_ACT_UNIT(Def.Command.数据管理.老龄办.老龄津贴_停发, Def.Act.数据管理.老龄办.老龄津贴_停发),
                new COMMANDID_ACT_UNIT(Def.Command.数据管理.老龄办.老龄津贴_查询, Def.Act.数据管理.老龄办.老龄津贴_查询),

            };
    }
}
