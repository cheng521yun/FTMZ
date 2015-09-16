using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buss.老龄办
{
    public class 老龄津贴
    {

        DB.Orm.老龄办.发放老龄津贴 Orm = new DB.Orm.老龄办.发放老龄津贴();

        public DB.Stru.老龄办.发放老龄津贴 Save( DB.Stru.老龄办.发放老龄津贴 stru )
        {
            string strID = Orm.Save( stru );
            stru.ID = strID;

            return stru;
        }

        public DB.Stru.老龄办.发放老龄津贴 Delete( DB.Stru.老龄办.发放老龄津贴 stru )
        {
            Orm.Delete( stru );
            stru.ID = String.Empty;

            return stru;
        }

        #region Page

        public List<DB.Stru.老龄办.发放老龄津贴> GetPage( int nPageNo, string strWhere )
        {
            return Orm.GetPage( nPageNo, strWhere );
        }

        public int GetPageMax( string strWhere )
        {
            return Orm.GetPageMax( strWhere );
        }

        #endregion
    }
}
