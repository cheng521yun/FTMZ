using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru
{
    public class vewUSER
    {
        string _ID = String.Empty;
        string _Code = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _Name = String.Empty;
        string _Password = String.Empty;
        string _Grander = String.Empty;
        string _Status = String.Empty;
        string _RoleName = String.Empty;
        string _Depart = String.Empty;

        public vewUSER()
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

        public string CreateDate
        {
            set { _CreateDate = value; }
            get { return _CreateDate; }
        }

        public string Creator
        {
            set { _Creator = value; }
            get { return _Creator; }
        }

        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }

        public string Password
        {
            set { _Password = value; }
            get { return _Password; }
        }

        public string Grander
        {
            set { _Grander = value; }
            get { return _Grander; }
        }

        public string Status
        {
            set { _Status = value; }
            get { return _Status; }
        }

        public string RoleName
        {
            set { _RoleName = value; }
            get { return _RoleName; }
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
            CreateDate = String.Empty;
            Creator = String.Empty;
            Name = String.Empty;
            Password = String.Empty;
            Grander = String.Empty;
            Status = String.Empty;
            RoleName = String.Empty;
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

            ID = dr[ Tab.vewUSER.ID ].ToString().Trim();
            Code = dr[ Tab.vewUSER.Code ].ToString().Trim();
            CreateDate = dr[ Tab.vewUSER.CreateDate ].ToString().Trim();
            Creator = dr[ Tab.vewUSER.Creator ].ToString().Trim();
            Name = dr[ Tab.vewUSER.Name ].ToString().Trim();
            Password = dr[ Tab.vewUSER.Password ].ToString().Trim();
            Grander = dr[ Tab.vewUSER.Grander ].ToString().Trim();
            Status = dr[ Tab.vewUSER.Status ].ToString().Trim();
            RoleName = dr[ Tab.vewUSER.RoleName ].ToString().Trim();
            Depart = dr[ Tab.vewUSER.Depart ].ToString().Trim();

            return true;
        }

        public static List<Stru.vewUSER> Dt2List( ref DataTable dt )
        {
            List<Stru.vewUSER> lst = new List<vewUSER>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                Stru.vewUSER stru = new vewUSER();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<Stru.vewUSER> lst )
        {
            ORM.vewUSER orm = new ORM.vewUSER();
            DataTable dt = orm.GetBlank();

            foreach ( Stru.vewUSER o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static Stru.vewUSER StruFromList_ByID( ref List<Stru.vewUSER> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( Stru.vewUSER stru in list )
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
            if ( CreateDate == String.Empty )
                CreateDate = DateTime.Now.ToString( "yyyy-MM-dd HH:mm:ss" );
        }

        public void Stru2Dr( ref DataRow dr )
        {
            if ( ID.Trim() != String.Empty )
                dr[ Tab.vewUSER.ID ] = ID;

            CheckData();

            dr[ Tab.vewUSER.Code ] = Code;
            dr[ Tab.vewUSER.CreateDate ] = CreateDate;
            dr[ Tab.vewUSER.Creator ] = Creator;
            dr[ Tab.vewUSER.Name ] = Name;
            dr[ Tab.vewUSER.Password ] = Password;
            dr[ Tab.vewUSER.Grander ] = Grander;
            dr[ Tab.vewUSER.Status ] = Status;
            dr[ Tab.vewUSER.RoleName ] = RoleName;
            dr[ Tab.vewUSER.Depart ] = Depart;
        }

        public void CopyFrom( vewUSER struFrom )
        {
            ID = struFrom.ID;
            Code = struFrom.Code;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            Name = struFrom.Name;
            Password = struFrom.Password;
            Grander = struFrom.Grander;
            Status = struFrom.Status;
            RoleName = struFrom.RoleName;
            Depart = struFrom.Depart;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( vewUSER struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( Code.Trim() != struOrg.Code.Trim() )
                ary.Add( String.Format( "[Code]: {0} => {1}", struOrg.Code, Code ) );

            if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
                ary.Add( String.Format( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate ) );

            if ( Creator.Trim() != struOrg.Creator.Trim() )
                ary.Add( String.Format( "[Creator]: {0} => {1}", struOrg.Creator, Creator ) );

            if ( Name.Trim() != struOrg.Name.Trim() )
                ary.Add( String.Format( "[Name]: {0} => {1}", struOrg.Name, Name ) );

            if ( Password.Trim() != struOrg.Password.Trim() )
                ary.Add( String.Format( "[Password]: {0} => {1}", struOrg.Password, Password ) );

            if ( Grander.Trim() != struOrg.Grander.Trim() )
                ary.Add( String.Format( "[Grander]: {0} => {1}", struOrg.Grander, Grander ) );

            if ( Status.Trim() != struOrg.Status.Trim() )
                ary.Add( String.Format( "[Status]: {0} => {1}", struOrg.Status, Status ) );

            if ( RoleName.Trim() != struOrg.RoleName.Trim() )
                ary.Add( String.Format( "[RoleName]: {0} => {1}", struOrg.RoleName, RoleName ) );

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
            ary.Add( String.Format( "[CreateDate] : {0} ", CreateDate ) );
            ary.Add( String.Format( "[Creator] : {0} ", Creator ) );
            ary.Add( String.Format( "[Name] : {0} ", Name ) );
            ary.Add( String.Format( "[Password] : {0} ", Password ) );
            ary.Add( String.Format( "[Grander] : {0} ", Grander ) );
            ary.Add( String.Format( "[Status] : {0} ", Status ) );
            ary.Add( String.Format( "[RoleName] : {0} ", RoleName ) );
            ary.Add( String.Format( "[Depart] : {0} ", Depart ) );

            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
    }
}