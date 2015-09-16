using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;


namespace DB.ORM
{
    public class LOG
    {
        DA.LOG daLog = new DA.LOG();

        #region Get

        public DataTable GetBlank()
        {
            return daLog.GetBlank();
        }

        public List<Stru.LOG> Get_ByWhere( string strWhere )
        {
            List<Stru.LOG> lst = new List<Stru.LOG>();

            DataTable dt = daLog.GetWhere( strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.LOG.Dt2List( ref dt );

            return lst;
        }

        public Stru.LOG GetFirst_ByWhere( string strWhere )
        {
            Stru.LOG stru = new Stru.LOG();
            List<Stru.LOG> list = Get_ByWhere( strWhere );

            if ( list != null && list.Count > 0 )
                stru = list[ 0 ];

            return stru;
        }

        public Stru.LOG Get_ByID( string strID )
        {
            string strWhere = String.Format( "{0}='{1}'", Tab.LOG.ID, strID );
            return GetFirst_ByWhere( strWhere );
        }

        #endregion

        #region Split to Page

        //Get one Page data from all 
        public List<Stru.LOG> GetPage( int nPageNo, string strWhere )
        {
            List<Stru.LOG> lst = new List<Stru.LOG>();

            DataTable dt = daLog.GetPage( nPageNo, strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.LOG.Dt2List( ref dt );

            return lst;
        }

        //Get Page Number  
        public int GetPageMax( string strWhere )
        {
            return daLog.GetPageMax( strWhere );
        }

        #endregion

        #region Save
        public string Save( ref DataTable dt )
        {
            string strID = daLog.Save( ref dt );
            return strID;
        }

        public string Save( Stru.LOG stru )
        {
            string strID = daLog.Save( stru );
            return strID;
        }

        public bool Save( List<Stru.LOG> lst )
        {
            bool bRet = true;
            string strID;
            foreach ( Stru.LOG stru in lst )
            {
                strID = Save( stru );
                bRet &= ( strID == "" ) ? false : true;
            }
            return bRet;
        }

        #endregion

        #region Delete

        public void Delete( Stru.LOG stru )
        {
            daLog.Delete_ByID( stru.ID );
        }

        public void Delete( List<string> lstDel )
        {
            foreach ( string strID in lstDel )
                daLog.Delete_ByID( strID );
        }

        public void Delete( List<Stru.LOG> lst )
        {
            foreach ( Stru.LOG stru in lst )
                daLog.Delete_ByID( stru.ID );
        }

        #endregion



        #region Update

        public void Update_ByID( string strID, string strFld, string strVal )
        {
            daLog.Update_ByID( strID, strFld, strVal );
        }

        #endregion

        #region Sum

        public int GetCount( string strWhere )
        {
            int nCount = 0;
            DataTable dt = daLog.GetCount( strWhere );

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
            DataTable dt = daLog.GetCount( strWhere );

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


