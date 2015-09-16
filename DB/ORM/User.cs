using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;


namespace DB.ORM
{
    public class USER
    {
        DA.USER daUser = new DA.USER();

        #region Get

        public DataTable GetBlank()
        {
            return daUser.GetBlank();
        }

        public List<Stru.USER> Get_ByWhere( string strWhere )
        {
            List<Stru.USER> lst = new List<Stru.USER>();

            DataTable dt = daUser.GetWhere( strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.USER.Dt2List( ref dt );

            return lst;
        }

        public Stru.USER GetFirst_ByWhere( string strWhere )
        {
            Stru.USER stru = new Stru.USER();
            List<Stru.USER> list = Get_ByWhere( strWhere );

            if ( list != null && list.Count > 0 )
                stru = list[ 0 ];

            return stru;
        }

        public Stru.USER Get_ByID( string strID )
        {
            string strWhere = String.Format( "{0}='{1}'", Tab.USER.ID, strID );
            return GetFirst_ByWhere( strWhere );
        }

        #endregion

        #region Split to Page

        //Get one Page data from all 
        public List<Stru.USER> GetPage( int nPageNo, string strWhere )
        {
            List<Stru.USER> lst = new List<Stru.USER>();

            DataTable dt = daUser.GetPage( nPageNo, strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.USER.Dt2List( ref dt );

            return lst;
        }

        //Get Page Number  
        public int GetPageMax( string strWhere )
        {
            return daUser.GetPageMax( strWhere );
        }

        #endregion

        #region Save
        public string Save( ref DataTable dt )
        {
            string strID = daUser.Save( ref dt );
            return strID;
        }

        public string Save( Stru.USER stru )
        {
            string strID = daUser.Save( stru );
            return strID;
        }

        public bool Save( List<Stru.USER> lst )
        {
            bool bRet = true;
            string strID;
            foreach ( Stru.USER stru in lst )
            {
                strID = Save( stru );
                bRet &= ( strID == "" ) ? false : true;
            }
            return bRet;
        }

        #endregion

        #region Delete

        public void Delete( Stru.USER stru )
        {
            daUser.Delete_ByID( stru.ID );
        }

        public void Delete( List<string> lstDel )
        {
            foreach ( string strID in lstDel )
                daUser.Delete_ByID( strID );
        }

        public void Delete( List<Stru.USER> lst )
        {
            foreach ( Stru.USER stru in lst )
                daUser.Delete_ByID( stru.ID );
        }

        #endregion


        #region Update

        public void Update_ByID( string strID, string strFld, string strVal )
        {
            daUser.Update_ByID( strID, strFld, strVal );
        }

        #endregion

        #region Sum

        public int GetCount( string strWhere )
        {
            int nCount = 0;
            DataTable dt = daUser.GetCount( strWhere );

            if ( SQL.IsValid( ref dt ) )
            {
                string strCount = dt.Rows[ 0 ][ 0 ].ToString();
                nCount = FF.Fun.MyConvert.Str2Int( strCount );
            }

            return nCount;
        }

        public int GetSum( string strWhere )
        {
            int nCount = 0;
            DataTable dt = daUser.GetCount( strWhere );

            if ( SQL.IsValid( ref dt ) )
            {
                string strCount = dt.Rows[ 0 ][ 0 ].ToString();
                nCount = FF.Fun.MyConvert.Str2Int( strCount );
            }

            return nCount;
        }

        #endregion
    }


}


