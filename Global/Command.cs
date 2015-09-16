using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Def;

namespace Global
{
    public class COMMAND
    {
        public bool Excute( int nCommand, object obj )
        {
            dlgt.ActObj Act = Def.CommandId_Act.GetAct( nCommand );
            if ( Act == null )
                return false;

            Act( obj );

            return true;
        }

        public bool Excute( int nCommand, string strParam )
        {
            return Excute( nCommand, (object)strParam );
        }

        public bool Excute( int nCommand )
        {
            if (nCommand == -1)
                return false ;
            return Excute( nCommand, String.Empty );
        }
    }
}
