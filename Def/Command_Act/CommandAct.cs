using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def
{
    static public class CommandId_Act
    {
        public static List<COMMANDID_ACT_UNIT> lst = new List<COMMANDID_ACT_UNIT>();

        static CommandId_Act()
        {
            Combin( lst, Def.Command_Act.Menu.lst );
            Combin( lst, Def.Command_Act.数据管理.老龄办.lst );
            Combin( lst, Def.Command_Act.Comm.人员.lst );
        }

        static public void SetAct( dlgt.ActObj act, dlgt.ActObj act2 )
        {
            foreach ( COMMANDID_ACT_UNIT Unit in lst )
            {
                if (Unit.Act == act)
                {
                    Unit.Act += act2;
                    break;
                }
            }

            return ;
        }

        static public dlgt.ActObj GetAct( int nCommand )
        {
            foreach ( COMMANDID_ACT_UNIT Unit in lst )
            {
                if ( Unit.nCommandId == nCommand )
                    return Unit.Act;
            }

            return null;
        }

        private static void Combin(List<COMMANDID_ACT_UNIT> lstAll, List<COMMANDID_ACT_UNIT> lst)
        {
            foreach (COMMANDID_ACT_UNIT stru in lst)
            {
                lstAll.Add( stru );
            }
        }
    }

    public class COMMANDID_ACT_UNIT
    {
        public COMMANDID_ACT_UNIT( int nCommandId, dlgt.ActObj Act )
        {
            this.nCommandId = nCommandId;
            this.Act = Act;
        }

        public int nCommandId;
        public dlgt.ActObj Act;
    }
}
