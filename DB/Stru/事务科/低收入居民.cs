


using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.事务科
{
    public class 低收入居民
    {
        string _ID = String.Empty;
        string _类别 = String.Empty;
        string _户主姓名 = String.Empty;
        string _性别 = String.Empty;
        string _年龄 = String.Empty;
        string _身份证 = String.Empty;
        string _通讯住址 = String.Empty;
        string _所属社区 = String.Empty;
        string _电话号码 = String.Empty;
        string _银行帐号 = String.Empty;

        public 低收入居民()
        {
            Init();
        }

        #region Prop

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string 类别
        {
            set { _类别 = value; }
            get { return _类别; }
        }

        public string 户主姓名
        {
            set { _户主姓名 = value; }
            get { return _户主姓名; }
        }

        public string 性别
        {
            set { _性别 = value; }
            get { return _性别; }
        }

        public string 性别Str
        {
            get { return FF.Str.Helper.GetSexStr(性别); }
        }

        public string 年龄
        {
            set { _年龄 = value; }
            get { return _年龄; }
        }

        public string 身份证
        {
            set { _身份证 = value; }
            get { return _身份证; }
        }

        public string 通讯住址
        {
            set { _通讯住址 = value; }
            get { return _通讯住址; }
        }

        public string 所属社区
        {
            set { _所属社区 = value; }
            get { return _所属社区; }
        }

        public string 电话号码
        {
            set { _电话号码 = value; }
            get { return _电话号码; }
        }

        public string 银行帐号
        {
            set { _银行帐号 = value; }
            get { return _银行帐号; }
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
            类别 = String.Empty;
            户主姓名 = String.Empty;
            性别 = String.Empty;
            年龄 = String.Empty;
            身份证 = String.Empty;
            通讯住址 = String.Empty;
            所属社区 = String.Empty;
            电话号码 = String.Empty;
            银行帐号 = String.Empty;

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

            ID = dr[ DB.Tab.事务科.低收入居民.ID ].ToString().Trim();
            类别 = dr[ DB.Tab.事务科.低收入居民.类别 ].ToString().Trim();
            户主姓名 = dr[ DB.Tab.事务科.低收入居民.户主姓名 ].ToString().Trim();
            性别 = dr[ DB.Tab.事务科.低收入居民.性别 ].ToString().Trim();
            年龄 = dr[ DB.Tab.事务科.低收入居民.年龄 ].ToString().Trim();
            身份证 = dr[ DB.Tab.事务科.低收入居民.身份证 ].ToString().Trim();
            通讯住址 = dr[ DB.Tab.事务科.低收入居民.通讯住址 ].ToString().Trim();
            所属社区 = dr[ DB.Tab.事务科.低收入居民.所属社区 ].ToString().Trim();
            电话号码 = dr[ DB.Tab.事务科.低收入居民.电话号码 ].ToString().Trim();
            银行帐号 = dr[ DB.Tab.事务科.低收入居民.银行帐号 ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.事务科.低收入居民> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.事务科.低收入居民> lst = new List<DB.Stru.事务科.低收入居民>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.事务科.低收入居民 stru = new DB.Stru.事务科.低收入居民();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.事务科.低收入居民> lst )
        {
            DB.Orm.事务科.低收入居民 orm = new DB.Orm.事务科.低收入居民();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.事务科.低收入居民 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.事务科.低收入居民 StruFromList_ByID( ref List<DB.Stru.事务科.低收入居民> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.事务科.低收入居民 stru in list )
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
            if (年龄 == "")
                年龄 = "0";
        }

        public void Stru2Dr( ref DataRow dr )
        {
            if ( ID.Trim() != String.Empty )
                dr[ DB.Tab.事务科.低收入居民.ID ] = ID;

            CheckData();

            dr[ DB.Tab.事务科.低收入居民.类别 ] = 类别;
            dr[ DB.Tab.事务科.低收入居民.户主姓名 ] = 户主姓名;
            dr[ DB.Tab.事务科.低收入居民.性别 ] = 性别;
            dr[ DB.Tab.事务科.低收入居民.年龄 ] = 年龄;
            dr[ DB.Tab.事务科.低收入居民.身份证 ] = 身份证;
            dr[ DB.Tab.事务科.低收入居民.通讯住址 ] = 通讯住址;
            dr[ DB.Tab.事务科.低收入居民.所属社区 ] = 所属社区;
            dr[ DB.Tab.事务科.低收入居民.电话号码 ] = 电话号码;
            dr[ DB.Tab.事务科.低收入居民.银行帐号 ] = 银行帐号;
        }

        public void CopyFrom( DB.Stru.事务科.低收入居民 struFrom )
        {
            ID = struFrom.ID;
            类别 = struFrom.类别;
            户主姓名 = struFrom.户主姓名;
            性别 = struFrom.性别;
            年龄 = struFrom.年龄;
            身份证 = struFrom.身份证;
            通讯住址 = struFrom.通讯住址;
            所属社区 = struFrom.所属社区;
            电话号码 = struFrom.电话号码;
            银行帐号 = struFrom.银行帐号;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.事务科.低收入居民 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( 类别.Trim() != struOrg.类别.Trim() )
                ary.Add( String.Format( "[类别]: {0} => {1}", struOrg.类别, 类别 ) );

            if ( 户主姓名.Trim() != struOrg.户主姓名.Trim() )
                ary.Add( String.Format( "[户主姓名]: {0} => {1}", struOrg.户主姓名, 户主姓名 ) );

            if ( 性别.Trim() != struOrg.性别.Trim() )
                ary.Add( String.Format( "[性别]: {0} => {1}", struOrg.性别, 性别 ) );

            if ( 年龄.Trim() != struOrg.年龄.Trim() )
                ary.Add( String.Format( "[年龄]: {0} => {1}", struOrg.年龄, 年龄 ) );

            if ( 身份证.Trim() != struOrg.身份证.Trim() )
                ary.Add( String.Format( "[身份证]: {0} => {1}", struOrg.身份证, 身份证 ) );

            if ( 通讯住址.Trim() != struOrg.通讯住址.Trim() )
                ary.Add( String.Format( "[通讯住址]: {0} => {1}", struOrg.通讯住址, 通讯住址 ) );

            if ( 所属社区.Trim() != struOrg.所属社区.Trim() )
                ary.Add( String.Format( "[所属社区]: {0} => {1}", struOrg.所属社区, 所属社区 ) );

            if ( 电话号码.Trim() != struOrg.电话号码.Trim() )
                ary.Add( String.Format( "[电话号码]: {0} => {1}", struOrg.电话号码, 电话号码 ) );

            if ( 银行帐号.Trim() != struOrg.银行帐号.Trim() )
                ary.Add( String.Format( "[银行帐号]: {0} => {1}", struOrg.银行帐号, 银行帐号 ) );


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}