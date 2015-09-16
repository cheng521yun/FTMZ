using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Type
{
    public class IntStr
    {
        public IntStr()
        {
        }

        public IntStr( int nNo, string strVal )
        {
            this.nNo = nNo;
            this.strVal = strVal;
        }


        public int nNo { set; get; }
    
        public string strVal { set; get; }
    }
}
