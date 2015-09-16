using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;


namespace DB.ORM
{
    public class ROLE
    {
        DA.ROLE daRole = new DA.ROLE();

        #region Get

        public DataTable GetBlank()
        {
            return daRole.GetBlank();
        }

        public List<Stru.ROLE> Get_ByWhere( string strWhere )
        {
            List<Stru.ROLE> lst = new List<Stru.ROLE>();

            DataTable dt = daRole.GetWhere( strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.ROLE.Dt2List( ref dt );

            return lst;
        }

        public Stru.ROLE GetFirst_ByWhere( string strWhere )
        {
            Stru.ROLE stru = new Stru.ROLE();
            List<Stru.ROLE> list = Get_ByWhere( strWhere );

            if ( list != null && list.Count > 0 )
                stru = list[ 0 ];

            return stru;
        }

        public Stru.ROLE Get_ByID( string strID )
        {
            string strWhere = String.Format( "{0}='{1}'", Tab.ROLE.ID, strID );
            return GetFirst_ByWhere( strWhere );
        }

        #endregion

        #region Split to Page

        //Get one Page data from all 
        public List<Stru.ROLE> GetPage( int nPageNo, string strWhere )
        {
            List<Stru.ROLE> lst = new List<Stru.ROLE>();

            DataTable dt = daRole.GetPage( nPageNo, strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.ROLE.Dt2List( ref dt );

            return lst;
        }

        //Get Page Number  
        public int GetPageMax( string strWhere )
        {
            return daRole.GetPageMax( strWhere );
        }

        #endregion

        #region Save
        public string Save( ref DataTable dt )
        {
            string strID = daRole.Save( ref dt );
            return strID;
        }

        public string Save( Stru.ROLE stru )
        {
            string strID = daRole.Save( stru );
            return strID;
        }

        public bool Save( List<Stru.ROLE> lst )
        {
            bool bRet = true;
            string strID;
            foreach ( Stru.ROLE stru in lst )
            {
                strID = Save( stru );
                bRet &= ( strID == "" ) ? false : true;
            }
            return bRet;
        }

        #endregion

        #region Delete

        public void Delete( Stru.ROLE stru )
        {
            daRole.Delete_ByID( stru.ID );
        }

        public void Delete( List<string> lstDel )
        {
            foreach ( string strID in lstDel )
                daRole.Delete_ByID( strID );
        }

        public void Delete( List<Stru.ROLE> lst )
        {
            foreach ( Stru.ROLE stru in lst )
                daRole.Delete_ByID( stru.ID );
        }

        #endregion

        //#region Fake Delete

        //public void FakeDelete( Stru.ROLE stru )
        //{
        //    daRole.FakeDelete_ByID( stru.ID );
        //}

        //public void FakeDelete( List<string> lstDel )
        //{
        //    foreach ( string strID in lstDel )
        //        daRole.FakeDelete_ByID( strID );
        //}

        //public void FakeDelete( List<Stru.ROLE> lst )
        //{
        //    foreach ( Stru.ROLE stru in lst )
        //        daRole.FakeDelete_ByID( stru.ID );
        //}

        //#endregion

        #region Update

        public void Update_ByID( string strID, string strFld, string strVal )
        {
            daRole.Update_ByID( strID, strFld, strVal );
        }

        #endregion

        #region Sum

        public int GetCount( string strWhere )
        {
            int nCount = 0;
            DataTable dt = daRole.GetCount( strWhere );

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
            DataTable dt = daRole.GetCount( strWhere );

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


