using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buss.老龄办
{
    public class 停发老龄津贴
    {
        DB.Orm.老龄办.停发老龄津贴 Orm = new DB.Orm.老龄办.停发老龄津贴();

        public DB.Stru.老龄办.停发老龄津贴 Save( DB.Stru.老龄办.停发老龄津贴 stru )
        {
            string strID = Orm.Save( stru );
            stru.ID = strID;

            return stru;
        }

        public DB.Stru.老龄办.停发老龄津贴 Delete( DB.Stru.老龄办.停发老龄津贴 stru )
        {
            Orm.Delete( stru );
            stru.ID = String.Empty;

            return stru;
        }

        #region Page

        public List<DB.Stru.老龄办.停发老龄津贴> GetPage( int nPageNo, string strWhere )
        {
            return Orm.GetPage( nPageNo, strWhere );
        }

        public int GetPageMax( string strWhere )
        {
            return Orm.GetPageMax( strWhere );
        }

        #endregion

        #region Fun

        public DB.Stru.老龄办.停发老龄津贴 From发放老龄津贴( DB.Stru.老龄办.发放老龄津贴 stru发放 )
        {
            DB.Stru.老龄办.停发老龄津贴 stru停发 = new DB.Stru.老龄办.停发老龄津贴();

            stru停发.姓名 = stru发放.姓名;
            stru停发.身份证 = stru发放.身份证;

            return stru停发;
        }

        #endregion
    }
}
