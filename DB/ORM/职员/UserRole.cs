using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;


namespace DB.ORM
{
    public class USERROLE
    {
        DA.USERROLE daUserrole = new DA.USERROLE();

        #region Get

        public DataTable GetBlank()
        {
            return daUserrole.GetBlank();
        }

        public List<Stru.USERROLE> Get_ByWhere( string strWhere )
        {
            List<Stru.USERROLE> lst = new List<Stru.USERROLE>();

            DataTable dt = daUserrole.GetWhere( strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.USERROLE.Dt2List( ref dt );

            return lst;
        }

        public Stru.USERROLE GetFirst_ByWhere( string strWhere )
        {
            Stru.USERROLE stru = new Stru.USERROLE();
            List<Stru.USERROLE> list = Get_ByWhere( strWhere );

            if ( list != null && list.Count > 0 )
                stru = list[ 0 ];

            return stru;
        }

        public Stru.USERROLE Get_ByID( string strID )
        {
            string strWhere = String.Format( "{0}='{1}'", Tab.USERROLE.ID, strID );
            return GetFirst_ByWhere( strWhere );
        }

        #endregion

        #region Split to Page

        //Get one Page data from all 
        public List<Stru.USERROLE> GetPage( int nPageNo, string strWhere )
        {
            List<Stru.USERROLE> lst = new List<Stru.USERROLE>();

            DataTable dt = daUserrole.GetPage( nPageNo, strWhere );

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            lst = Stru.USERROLE.Dt2List( ref dt );

            return lst;
        }

        //Get Page Number  
        public int GetPageMax( string strWhere )
        {
            return daUserrole.GetPageMax( strWhere );
        }

        #endregion

        #region Save
        public string Save( ref DataTable dt )
        {
            string strID = daUserrole.Save( ref dt );
            return strID;
        }

        public string Save( Stru.USERROLE stru )
        {
            string strID = daUserrole.Save( stru );
            return strID;
        }

        public bool Save( List<Stru.USERROLE> lst )
        {
            bool bRet = true;
            string strID;
            foreach ( Stru.USERROLE stru in lst )
            {
                strID = Save( stru );
                bRet &= ( strID == "" ) ? false : true;
            }
            return bRet;
        }

        #endregion

        #region Delete

        public void Delete( Stru.USERROLE stru )
        {
            daUserrole.Delete_ByID( stru.ID );
        }

        public void Delete( List<string> lstDel )
        {
            foreach ( string strID in lstDel )
                daUserrole.Delete_ByID( strID );
        }

        public void Delete( List<Stru.USERROLE> lst )
        {
            foreach ( Stru.USERROLE stru in lst )
                daUserrole.Delete_ByID( stru.ID );
        }

        #endregion

        //#region Fake Delete

        //public void FakeDelete( Stru.USERROLE stru )
        //{
        //    daUserrole.FakeDelete_ByID( stru.ID );
        //}

        //public void FakeDelete( List<string> lstDel )
        //{
        //    foreach ( string strID in lstDel )
        //        daUserrole.FakeDelete_ByID( strID );
        //}

        //public void FakeDelete( List<Stru.USERROLE> lst )
        //{
        //    foreach ( Stru.USERROLE stru in lst )
        //        daUserrole.FakeDelete_ByID( stru.ID );
        //}

        //#endregion

        #region Update

        public void Update_ByID( string strID, string strFld, string strVal )
        {
            daUserrole.Update_ByID( strID, strFld, strVal );
        }

        #endregion

        #region Sum

        public int GetCount( string strWhere )
        {
            int nCount = 0;
            DataTable dt = daUserrole.GetCount( strWhere );

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
            DataTable dt = daUserrole.GetCount( strWhere );

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


