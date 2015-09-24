using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buss.事务科
{
    public class 专项救助_低保边缘户
    {
        DB.Orm.事务科.专项救助_低保边缘户 Orm = new DB.Orm.事务科.专项救助_低保边缘户();

        public bool Save(DB.Stru.事务科.专项救助_低保边缘户 stru)
        {
            string strID =  Orm.Save(stru);
            stru.ID = strID;

            return ! String.IsNullOrEmpty(strID);
        }

        public bool Delete(DB.Stru.事务科.专项救助_低保边缘户 stru)
        {
            if ( stru.IsNotValid() )
                return false;

            Orm.Delete( stru );

            return true;
        }

        #region Page

        public List<DB.Stru.事务科.专项救助_低保边缘户> GetPage(int nPageNo, string strWhere)
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
