using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru
{
    public class USERROLE
    {
        string _ID = String.Empty;
        string _UserID = String.Empty;
        string _RoleID = String.Empty;

        public USERROLE()
        {
            Init();
        }

        #region Prop

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string UserID
        {
            set { _UserID = value; }
            get { return _UserID; }
        }

        public string RoleID
        {
            set { _RoleID = value; }
            get { return _RoleID; }
        }


        #endregion

        //Will Manual Input Code
        //Default Value, 
        void Init()
        {
        }

        void Clear()
        {
            ID = String.Empty;
            UserID = String.Empty;
            RoleID = String.Empty;

            Init();
        }

        public bool IsValid()
        {
            return ( ID.Trim() == String.Empty ) ? false : true;
        }

        public bool IsNotValid()
        {
            return !IsValid();
        }

        public bool Dr2Stru( DataRow dr )
        {
            Clear();

            if ( dr == null )
                return false;

            ID = dr[ Tab.USERROLE.ID ].ToString().Trim();
            UserID = dr[ Tab.USERROLE.UserID ].ToString().Trim();
            RoleID = dr[ Tab.USERROLE.RoleID ].ToString().Trim();

            return true;
        }

        public static List<Stru.USERROLE> Dt2List( ref DataTable dt )
        {
            List<Stru.USERROLE> lst = new List<USERROLE>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                Stru.USERROLE stru = new USERROLE();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<Stru.USERROLE> lst )
        {
            ORM.USERROLE orm = new ORM.USERROLE();
            DataTable dt = orm.GetBlank();

            foreach ( Stru.USERROLE o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static Stru.USERROLE StruFromList_ByID( ref List<Stru.USERROLE> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( Stru.USERROLE stru in list )
            {
                if ( stru.ID == strID )
                    return stru;
            }
            return null;
        }

        //Will Manual Input Code
        //Check Special Field Data can save into DataBase
        private void CheckData()
        {
            //if ( CreateDate == String.Empty )
            //    CreateDate = DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" );
        }

        public void Stru2Dr( ref DataRow dr )
        {
            if ( ID.Trim() != String.Empty )
                dr[ Tab.USERROLE.ID ] = ID;

            CheckData();

            dr[ Tab.USERROLE.UserID ] = UserID;
            dr[ Tab.USERROLE.RoleID ] = RoleID;
        }

        public void CopyFrom( USERROLE struFrom )
        {
            ID = struFrom.ID;
            UserID = struFrom.UserID;
            RoleID = struFrom.RoleID;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( USERROLE struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( UserID.Trim() != struOrg.UserID.Trim() )
                ary.Add( String.Format( "[UserID]: {0} => {1}", struOrg.UserID, UserID ) );

            if ( RoleID.Trim() != struOrg.RoleID.Trim() )
                ary.Add( String.Format( "[RoleID]: {0} => {1}", struOrg.RoleID, RoleID ) );


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

        /// <summary>
        /// Get Struc main Content
        /// </summary>
        /// <returns></returns>
        public string GetContentStr()
        {
            if ( ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            ary.Add( String.Format( "[ID] : {0} ", ID ) );
            ary.Add( String.Format( "[UserID] : {0} ", UserID ) );
            ary.Add( String.Format( "[RoleID] : {0} ", RoleID ) );

            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
    }
}