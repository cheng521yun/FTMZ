using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;


namespace DB.ORM
{
    public class vewUSER
    {
        DA.vewUSER Vewuser = new DA.vewUSER();

        #region Get

        public DataTable GetBlank()
        {
            return Vewuser.GetBlank();
        }

        public List<Stru.vewUSER> Get_ByWhere( string strWhere )
        {
            List<Stru.vewUSER> lst = new List<Stru.vewUSER>();

            DataTable dt = Vewuser.GetWhere( strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.vewUSER.Dt2List( ref dt );

            return lst;
        }

        public Stru.vewUSER GetFirst_ByWhere( string strWhere )
        {
            Stru.vewUSER stru = new Stru.vewUSER();
            List<Stru.vewUSER> list = Get_ByWhere( strWhere );

            if ( list != null && list.Count > 0 )
                stru = list[ 0 ];

            return stru;
        }

        public Stru.vewUSER Get_ByID( string strID )
        {
            string strWhere = String.Format( "{0}='{1}'", Tab.vewUSER.ID, strID );
            return GetFirst_ByWhere( strWhere );
        }

        #endregion

        #region Split to Page

        //Get one Page data from all 
        public List<Stru.vewUSER> GetPage( int nPageNo, string strWhere )
        {
            List<Stru.vewUSER> lst = new List<Stru.vewUSER>();

            DataTable dt = Vewuser.GetPage( nPageNo, strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.vewUSER.Dt2List( ref dt );

            return lst;
        }

        //Get Page Number  
        public int GetPageMax( string strWhere )
        {
            return Vewuser.GetPageMax( strWhere );
        }

        #endregion

        #region Save
        public string Save( ref DataTable dt )
        {
            string strID = Vewuser.Save( ref dt );
            return strID;
        }

        public string Save( Stru.vewUSER stru )
        {
            string strID = Vewuser.Save( stru );
            return strID;
        }

        public bool Save( List<Stru.vewUSER> lst )
        {
            bool bRet = true;
            string strID;
            foreach ( Stru.vewUSER stru in lst )
            {
                strID = Save( stru );
                bRet &= ( strID == "" ) ? false : true;
            }
            return bRet;
        }

        #endregion

        #region Delete

        public void Delete( Stru.vewUSER stru )
        {
            Vewuser.Delete_ByID( stru.ID );
        }

        public void Delete( List<string> lstDel )
        {
            foreach ( string strID in lstDel )
                Vewuser.Delete_ByID( strID );
        }

        public void Delete( List<Stru.vewUSER> lst )
        {
            foreach ( Stru.vewUSER stru in lst )
                Vewuser.Delete_ByID( stru.ID );
        }

        #endregion

        //#region Fake Delete

        //public void FakeDelete( Stru.vewUSER stru )
        //{
        //    Vewuser.FakeDelete_ByID( stru.ID );
        //}

        //public void FakeDelete( List<string> lstDel )
        //{
        //    foreach ( string strID in lstDel )
        //        Vewuser.FakeDelete_ByID( strID );
        //}

        //public void FakeDelete( List<Stru.vewUSER> lst )
        //{
        //    foreach ( Stru.vewUSER stru in lst )
        //        Vewuser.FakeDelete_ByID( stru.ID );
        //}

        //#endregion

        #region Update

        public void Update_ByID( string strID, string strFld, string strVal )
        {
            Vewuser.Update_ByID( strID, strFld, strVal );
        }

        #endregion

        #region Sum

        public int GetCount( string strWhere )
        {
            int nCount = 0;
            DataTable dt = Vewuser.GetCount( strWhere );

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
            DataTable dt = Vewuser.GetCount( strWhere );

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


