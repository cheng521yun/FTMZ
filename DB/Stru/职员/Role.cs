using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru
{
    public class ROLE
    {
        string _ID = String.Empty;
        string _Code = String.Empty;
        string _RoleName = String.Empty;
        string _Remark = String.Empty;
        string _Depart = String.Empty;

        public ROLE()
        {
            Init();
        }

        #region Prop

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string Code
        {
            set { _Code = value; }
            get { return _Code; }
        }

        public string RoleName
        {
            set { _RoleName = value; }
            get { return _RoleName; }
        }

        public string Remark
        {
            set { _Remark = value; }
            get { return _Remark; }
        }

        public string Depart
        {
            set { _Depart = value; }
            get { return _Depart; }
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
            Code = String.Empty;
            RoleName = String.Empty;
            Remark = String.Empty;
            Depart = String.Empty;

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

            ID = dr[ Tab.ROLE.ID ].ToString().Trim();
            Code = dr[ Tab.ROLE.Code ].ToString().Trim();
            RoleName = dr[ Tab.ROLE.RoleName ].ToString().Trim();
            Remark = dr[ Tab.ROLE.Remark ].ToString().Trim();
            Depart = dr[ Tab.ROLE.Depart ].ToString().Trim();

            return true;
        }

        public static List<Stru.ROLE> Dt2List( ref DataTable dt )
        {
            List<Stru.ROLE> lst = new List<ROLE>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                Stru.ROLE stru = new ROLE();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<Stru.ROLE> lst )
        {
            ORM.ROLE orm = new ORM.ROLE();
            DataTable dt = orm.GetBlank();

            foreach ( Stru.ROLE o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static Stru.ROLE StruFromList_ByID( ref List<Stru.ROLE> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( Stru.ROLE stru in list )
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
                dr[ Tab.ROLE.ID ] = ID;

            CheckData();

            dr[ Tab.ROLE.Code ] = Code;
            dr[ Tab.ROLE.RoleName ] = RoleName;
            dr[ Tab.ROLE.Remark ] = Remark;
            dr[ Tab.ROLE.Depart ] = Depart;
        }

        public void CopyFrom( ROLE struFrom )
        {
            ID = struFrom.ID;
            Code = struFrom.Code;
            RoleName = struFrom.RoleName;
            Remark = struFrom.Remark;
            Depart = struFrom.Depart;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( ROLE struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( Code.Trim() != struOrg.Code.Trim() )
                ary.Add( String.Format( "[Code]: {0} => {1}", struOrg.Code, Code ) );

            if ( RoleName.Trim() != struOrg.RoleName.Trim() )
                ary.Add( String.Format( "[RoleName]: {0} => {1}", struOrg.RoleName, RoleName ) );

            if ( Remark.Trim() != struOrg.Remark.Trim() )
                ary.Add( String.Format( "[Remark]: {0} => {1}", struOrg.Remark, Remark ) );

            if ( Depart.Trim() != struOrg.Depart.Trim() )
                ary.Add( String.Format( "[Depart]: {0} => {1}", struOrg.Depart, Depart ) );


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
            ary.Add( String.Format( "[Code] : {0} ", Code ) );
            ary.Add( String.Format( "[RoleName] : {0} ", RoleName ) );
            ary.Add( String.Format( "[Remark] : {0} ", Remark ) );
            ary.Add( String.Format( "[Depart] : {0} ", Depart ) );

            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
    }
}