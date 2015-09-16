using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buss.User
{
    public class USER
    {
        DB.ORM.USER ormUser = new DB.ORM.USER();
        DB.ORM.vewUSER ormvewUser = new DB.ORM.vewUSER();
        DB.ORM.ROLE ormRole = new DB.ORM.ROLE();

        public DB.Stru.USER Check( string strName, string strPassword, ref bool bCheckResult )
        {
            string strWhere = String.Format( "{0}='{1}' and {2}='{3}' ", DB.Tab.USER.Name, strName, DB.Tab.USER.Password, strPassword );
            DB.Stru.USER stru = ormUser.GetFirst_ByWhere( strWhere );

            bCheckResult = stru.IsValid();

            return stru;
        }

        public bool isExsit( string strName )
        {
            string strWhere = String.Format( "{0}='{1}' ", DB.Tab.USER.Name, strName );
            DB.Stru.USER stru = ormUser.GetFirst_ByWhere( strWhere );

            bool bExsit = stru.IsValid();
            return bExsit;
        }


        public DB.Stru.USER GetEx_ByUserName(string strUser)
        {
            string strWhere = String.Format( "{0}='{1}'", DB.Tab.USER.Name, strUser );
            DB.Stru.USER struUser = ormUser.GetFirst_ByWhere( strWhere );

            strWhere = String.Format( "( id in ( select RoleID as ID from UserRole where UserID ='{0}' ) )", struUser.ID );
            List<DB.Stru.ROLE> lstRole = ormRole.Get_ByWhere(strWhere);

            struUser.lstRole = lstRole;
            return struUser;
        }

        public List<DB.Stru.USER> GetWhere( string strWhere )
        {
            return ormUser.Get_ByWhere( strWhere );
        }

        public List<DB.Stru.USER> GetPage( int nPageNo, string strWhere )
        {
            return ormUser.GetPage( nPageNo, strWhere );
        }

        public int GetPageMax( string strWhere )
        {
            return ormUser.GetPageMax( strWhere );
        }

        public bool Save( DB.Stru.USER struUser )
        {
            string strID = ormUser.Save(struUser);
            return ! String.IsNullOrEmpty(strID);
        }

        public void Delete( DB.Stru.USER struUser )
        {
             ormUser.Delete( struUser );
        }
    }
}
