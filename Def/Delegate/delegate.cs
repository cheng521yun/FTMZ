using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def
{
    public class dlgt
    {
        public delegate void Act();
        public delegate void ActObj ( object objParam );
        public delegate void ActStr( string strParam );
        public delegate void ActDateTime( DateTime dat );
        
    }
}
