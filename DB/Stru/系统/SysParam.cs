


using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.系统
{
    public class SysParam
    {
        string _ID = String.Empty;
        string _Param = String.Empty;
        string _Value = String.Empty;

        public SysParam()
        {
            Init();
        }

        #region Prop

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string Param
        {
            set { _Param = value; }
            get { return _Param; }
        }

        public string Value
        {
            set { _Value = value; }
            get { return _Value; }
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
            Param = String.Empty;
            Value = String.Empty;

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

            ID = dr[ DB.Tab.系统.SysParam.ID ].ToString().Trim();
            Param = dr[ DB.Tab.系统.SysParam.Param ].ToString().Trim();
            Value = dr[ DB.Tab.系统.SysParam.Value ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.系统.SysParam> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.系统.SysParam> lst = new List<DB.Stru.系统.SysParam>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.系统.SysParam stru = new DB.Stru.系统.SysParam();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.系统.SysParam> lst )
        {
            DB.Orm.系统.SysParam orm = new DB.Orm.系统.SysParam();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.系统.SysParam o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.系统.SysParam StruFromList_ByID( ref List<DB.Stru.系统.SysParam> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.系统.SysParam stru in list )
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
                dr[ DB.Tab.系统.SysParam.ID ] = ID;

            CheckData();

            dr[ DB.Tab.系统.SysParam.Param ] = Param;
            dr[ DB.Tab.系统.SysParam.Value ] = Value;
        }

        public void CopyFrom( DB.Stru.系统.SysParam struFrom )
        {
            ID = struFrom.ID;
            Param = struFrom.Param;
            Value = struFrom.Value;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.系统.SysParam struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( Param.Trim() != struOrg.Param.Trim() )
                ary.Add( String.Format( "[Param]: {0} => {1}", struOrg.Param, Param ) );

            if ( Value.Trim() != struOrg.Value.Trim() )
                ary.Add( String.Format( "[Value]: {0} => {1}", struOrg.Value, Value ) );


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}