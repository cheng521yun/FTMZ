using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru
{
    public class USER
    {
        string _ID = String.Empty;
        string _Code = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _Name = String.Empty;
        string _Password = String.Empty;
        string _Grander = String.Empty;
        string _Status = String.Empty;

        public USER()
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

            ID = dr[ Tab.USER.ID ].ToString().Trim();
            Code = dr[ Tab.USER.Code ].ToString().Trim();
            CreateDate = dr[ Tab.USER.CreateDate ].ToString().Trim();
            Creator = dr[ Tab.USER.Creator ].ToString().Trim();
            Name = dr[ Tab.USER.Name ].ToString().Trim();
            Password = dr[ Tab.USER.Password ].ToString().Trim();
            Grander = dr[ Tab.USER.Grander ].ToString().Trim();
            Status = dr[ Tab.USER.Status ].ToString().Trim();

            return true;
        }

        public static List<Stru.USER> Dt2List( ref DataTable dt )
        {
            List<Stru.USER> lst = new List<USER>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                Stru.USER stru = new USER();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<Stru.USER> lst )
        {
            ORM.USER orm = new ORM.USER();
            DataTable dt = orm.GetBlank();

            foreach ( Stru.USER o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static Stru.USER StruFromList_ByID( ref List<Stru.USER> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( Stru.USER stru in list )
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
                dr[ Tab.USER.ID ] = ID;

            CheckData();

            dr[ Tab.USER.Code ] = Code;
            dr[ Tab.USER.CreateDate ] = CreateDate;
            dr[ Tab.USER.Creator ] = Creator;
            dr[ Tab.USER.Name ] = Name;
            dr[ Tab.USER.Password ] = Password;
            dr[ Tab.USER.Grander ] = Grander;
            dr[ Tab.USER.Status ] = Status;
        }

        public void CopyFrom( USER struFrom )
        {
            ID = struFrom.ID;
            Code = struFrom.Code;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            Name = struFrom.Name;
            Password = struFrom.Password;
            Grander = struFrom.Grander;
            Status = struFrom.Status;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( USER struOrg )
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

            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
    }
}