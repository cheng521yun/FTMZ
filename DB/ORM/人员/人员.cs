using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;


namespace DB.ORM
{
    public class 人员
    {
        DA.人员 da人员 = new DA.人员();

        #region Get

        public DataTable GetBlank()
        {
            return da人员.GetBlank();
        }

        public List<Stru.人员> Get_ByWhere( string strWhere )
        {
            List<Stru.人员> lst = new List<Stru.人员>();

            DataTable dt = da人员.GetWhere( strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.人员.Dt2List( ref dt );

            return lst;
        }

        public Stru.人员 GetFirst_ByWhere( string strWhere )
        {
            Stru.人员 stru = new Stru.人员();
            List<Stru.人员> list = Get_ByWhere( strWhere );

            if ( list != null && list.Count > 0 )
                stru = list[ 0 ];

            return stru;
        }

        public Stru.人员 Get_ByID( string strID )
        {
            string strWhere = String.Format( "{0}='{1}'", Tab.人员.ID, strID );
            return GetFirst_ByWhere( strWhere );
        }

        #endregion

        #region Split to Page

        //Get one Page data from all 
        public List<Stru.人员> GetPage( int nPageNo, string strWhere )
        {
            List<Stru.人员> lst = new List<Stru.人员>();

            DataTable dt = da人员.GetPage( nPageNo, strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.人员.Dt2List( ref dt );

            return lst;
        }

        //Get Page Number  
        public int GetPageMax( string strWhere )
        {
            return da人员.GetPageMax( strWhere );
        }

        #endregion

        #region Save
        public string Save( ref DataTable dt )
        {
            string strID = da人员.Save( ref dt );
            return strID;
        }

        public string Save( Stru.人员 stru )
        {
            string strID = da人员.Save( stru );
            return strID;
        }

        public bool Save( List<Stru.人员> lst )
        {
            bool bRet = true;
            string strID;
            foreach ( Stru.人员 stru in lst )
            {
                strID = Save( stru );
                bRet &= ( strID == "" ) ? false : true;
            }
            return bRet;
        }

        #endregion

        #region Delete

        public void Delete( Stru.人员 stru )
        {
            da人员.Delete_ByID( stru.ID );
        }

        public void Delete( List<string> lstDel )
        {
            foreach ( string strID in lstDel )
                da人员.Delete_ByID( strID );
        }

        public void Delete( List<Stru.人员> lst )
        {
            foreach ( Stru.人员 stru in lst )
                da人员.Delete_ByID( stru.ID );
        }

        #endregion

        #region Fake Delete

        public void FakeDelete( Stru.人员 stru )
        {
            da人员.FakeDelete_ByID( stru.ID );
        }

        public void FakeDelete( List<string> lstDel )
        {
            foreach ( string strID in lstDel )
                da人员.FakeDelete_ByID( strID );
        }

        public void FakeDelete( List<Stru.人员> lst )
        {
            foreach ( Stru.人员 stru in lst )
                da人员.FakeDelete_ByID( stru.ID );
        }

        #endregion

        #region Update

        public void Update_ByID( string strID, string strFld, string strVal )
        {
            da人员.Update_ByID( strID, strFld, strVal );
        }

        #endregion

        #region Sum

        public int GetCount( string strWhere )
        {
            int nCount = 0;
            DataTable dt = da人员.GetCount( strWhere );

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
            DataTable dt = da人员.GetCount( strWhere );

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


