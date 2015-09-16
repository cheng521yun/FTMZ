using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buss.人员
{
    public class PERSON
    {
        DB.ORM.人员 orm人员 = new DB.ORM.人员();

        public DB.Stru.人员 AddNew( DB.Stru.人员 stru )
        {
            stru.ID = orm人员.Save( stru );
            return stru;
        }

        public List<DB.Stru.人员> GetPage( int nPageNo, string strWhere )
        {
            return orm人员.GetPage( nPageNo, strWhere );
        }

        public int GetPageMax( string strWhere )
        {
            return orm人员.GetPageMax( strWhere );
        }
    }
}
