using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buss.福利中心
{
    public class 老人入住管理
    {
        DB.Orm.福利中心.老人入住管理 Orm = new DB.Orm.福利中心.老人入住管理();

        public bool Save( DB.Stru.福利中心.老人入住管理 stru )
        {
            string strID =  Orm.Save(stru);
            stru.ID = strID;

            return ! String.IsNullOrEmpty(strID);
        }

        public bool Delete( DB.Stru.福利中心.老人入住管理 stru )
        {
            if ( stru.IsNotValid() )
                return false;

            Orm.Delete( stru );

            return true;
        }

        #region Page

        public List<DB.Stru.福利中心.老人入住管理> GetPage( int nPageNo, string strWhere )
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
