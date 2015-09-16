using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DB.Orm.老龄办;
using FrontFlag;
using 敬老优待证统计 = DB.Stru.老龄办.敬老优待证统计;

namespace Buss.老龄办
{
    public class 优待证
    {
        DB.Orm.老龄办.敬老优待证 Orm = new 敬老优待证();

        public DB.Stru.老龄办.敬老优待证 Save(DB.Stru.老龄办.敬老优待证 stru)
        {
            string strID = Orm.Save(stru);
            stru.ID = strID;

            return stru ;
        }

        public DB.Stru.老龄办.敬老优待证 Delete( DB.Stru.老龄办.敬老优待证 stru )
        {
            Orm.Delete( stru );
            stru.ID = String.Empty ;

            return stru;
        }

        #region Page

        public List<DB.Stru.老龄办.敬老优待证> GetPage( int nPageNo, string strWhere )
        {
            return Orm.GetPage( nPageNo, strWhere );
        }

        public int GetPageMax( string strWhere )
        {
            return Orm.GetPageMax( strWhere );
        }

        #endregion

        #region 统计

        public List<DB.Stru.老龄办.敬老优待证统计> Get_统计()
        {
            DB.ORM.老龄办.敬老优待证统计 orm = new DB.ORM.老龄办.敬老优待证统计();

            List<DB.Stru.老龄办.敬老优待证统计> lst = orm.Get_统计( string.Empty );

            return lst;
        }

        #endregion
    }
}
