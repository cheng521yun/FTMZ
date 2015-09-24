using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buss.基层科
{
    public class 民主管理信息管理
    {

        DB.Orm.基层科.民主管理信息管理 Orm = new DB.Orm.基层科.民主管理信息管理();

        public DB.Stru.基层科.民主管理信息管理 Save(DB.Stru.基层科.民主管理信息管理 stru)
        {
            string strID = Orm.Save( stru );
            stru.ID = strID;

            return stru;
        }

        public DB.Stru.基层科.民主管理信息管理 Delete(DB.Stru.基层科.民主管理信息管理 stru)
        {
            Orm.Delete( stru );
            stru.ID = String.Empty;

            return stru;
        }

        #region Page

        public List<DB.Stru.基层科.民主管理信息管理> GetPage(int nPageNo, string strWhere)
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
