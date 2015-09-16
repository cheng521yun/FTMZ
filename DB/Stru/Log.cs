using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru
{
    public class LOG
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _Type = String.Empty;
        string _Action = String.Empty;
        string _Param = String.Empty;
        string _Remark = String.Empty;

        public LOG()
        {
            Init();
        }

        #region Prop

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
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

        public string Type
        {
            set { _Type = value; }
            get { return _Type; }
        }

        public string Action
        {
            set { _Action = value; }
            get { return _Action; }
        }

        public string Param
        {
            set { _Param = value; }
            get { return _Param; }
        }

        public string Remark
        {
            set { _Remark = value; }
            get { return _Remark; }
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
            CreateDate = String.Empty;
            Creator = String.Empty;
            Type = String.Empty;
            Action = String.Empty;
            Param = String.Empty;
            Remark = String.Empty;

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

            ID = dr[ Tab.LOG.ID ].ToString().Trim();
            CreateDate = dr[ Tab.LOG.CreateDate ].ToString().Trim();
            Creator = dr[ Tab.LOG.Creator ].ToString().Trim();
            Type = dr[ Tab.LOG.Type ].ToString().Trim();
            Action = dr[ Tab.LOG.Action ].ToString().Trim();
            Param = dr[ Tab.LOG.Param ].ToString().Trim();
            Remark = dr[ Tab.LOG.Remark ].ToString().Trim();

            return true;
        }

        public static List<Stru.LOG> Dt2List( ref DataTable dt )
        {
            List<Stru.LOG> lst = new List<LOG>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                Stru.LOG stru = new LOG();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<Stru.LOG> lst )
        {
            ORM.LOG orm = new ORM.LOG();
            DataTable dt = orm.GetBlank();

            foreach ( Stru.LOG o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static Stru.LOG StruFromList_ByID( ref List<Stru.LOG> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( Stru.LOG stru in list )
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
                dr[ Tab.LOG.ID ] = ID;

            CheckData();

            dr[ Tab.LOG.CreateDate ] = CreateDate;
            dr[ Tab.LOG.Creator ] = Creator;
            dr[ Tab.LOG.Type ] = Type;
            dr[ Tab.LOG.Action ] = Action;
            dr[ Tab.LOG.Param ] = Param;
            dr[ Tab.LOG.Remark ] = Remark;
        }

        public void CopyFrom( LOG struFrom )
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            Type = struFrom.Type;
            Action = struFrom.Action;
            Param = struFrom.Param;
            Remark = struFrom.Remark;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( LOG struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
                ary.Add( String.Format( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate ) );

            if ( Creator.Trim() != struOrg.Creator.Trim() )
                ary.Add( String.Format( "[Creator]: {0} => {1}", struOrg.Creator, Creator ) );

            if ( Type.Trim() != struOrg.Type.Trim() )
                ary.Add( String.Format( "[Type]: {0} => {1}", struOrg.Type, Type ) );

            if ( Action.Trim() != struOrg.Action.Trim() )
                ary.Add( String.Format( "[Action]: {0} => {1}", struOrg.Action, Action ) );

            if ( Param.Trim() != struOrg.Param.Trim() )
                ary.Add( String.Format( "[Param]: {0} => {1}", struOrg.Param, Param ) );

            if ( Remark.Trim() != struOrg.Remark.Trim() )
                ary.Add( String.Format( "[Remark]: {0} => {1}", struOrg.Remark, Remark ) );


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
            ary.Add( String.Format( "[CreateDate] : {0} ", CreateDate ) );
            ary.Add( String.Format( "[Creator] : {0} ", Creator ) );
            ary.Add( String.Format( "[Type] : {0} ", Type ) );
            ary.Add( String.Format( "[Action] : {0} ", Action ) );
            ary.Add( String.Format( "[Param] : {0} ", Param ) );
            ary.Add( String.Format( "[Remark] : {0} ", Remark ) );

            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
    }
}