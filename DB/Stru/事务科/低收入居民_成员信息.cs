


using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.事务科
{
    public class 低收入居民_成员信息
    {
        string _ID = String.Empty;
        string _父ID = String.Empty;
        string _姓名 = String.Empty;
        string _性别 = String.Empty;
        string _身份证 = String.Empty;
        string _家庭人数 = String.Empty;
        string _保障人数 = String.Empty;
        string _家庭月收入 = String.Empty;
        string _成员类型 = String.Empty;

        public 低收入居民_成员信息()
        {
            Init();
        }

        #region Prop

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string 父ID
        {
            set { _父ID = value; }
            get { return _父ID; }
        }

        public string 姓名
        {
            set { _姓名 = value; }
            get { return _姓名; }
        }

        public string 性别
        {
            set { _性别 = value; }
            get { return _性别; }
        }

        public string 身份证
        {
            set { _身份证 = value; }
            get { return _身份证; }
        }

        public string 家庭人数
        {
            set { _家庭人数 = value; }
            get { return _家庭人数; }
        }

        public string 保障人数
        {
            set { _保障人数 = value; }
            get { return _保障人数; }
        }

        public string 家庭月收入
        {
            set { _家庭月收入 = value; }
            get { return _家庭月收入; }
        }

        public string 成员类型
        {
            set { _成员类型 = value; }
            get { return _成员类型; }
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
            父ID = String.Empty;
            姓名 = String.Empty;
            性别 = String.Empty;
            身份证 = String.Empty;
            家庭人数 = String.Empty;
            保障人数 = String.Empty;
            家庭月收入 = String.Empty;
            成员类型 = String.Empty;

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

            ID = dr[ DB.Tab.事务科.低收入居民_成员信息.ID ].ToString().Trim();
            父ID = dr[ DB.Tab.事务科.低收入居民_成员信息.父ID ].ToString().Trim();
            姓名 = dr[ DB.Tab.事务科.低收入居民_成员信息.姓名 ].ToString().Trim();
            性别 = dr[ DB.Tab.事务科.低收入居民_成员信息.性别 ].ToString().Trim();
            身份证 = dr[ DB.Tab.事务科.低收入居民_成员信息.身份证 ].ToString().Trim();
            家庭人数 = dr[ DB.Tab.事务科.低收入居民_成员信息.家庭人数 ].ToString().Trim();
            保障人数 = dr[ DB.Tab.事务科.低收入居民_成员信息.保障人数 ].ToString().Trim();
            家庭月收入 = dr[ DB.Tab.事务科.低收入居民_成员信息.家庭月收入 ].ToString().Trim();
            成员类型 = dr[ DB.Tab.事务科.低收入居民_成员信息.成员类型 ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.事务科.低收入居民_成员信息> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.事务科.低收入居民_成员信息> lst = new List<DB.Stru.事务科.低收入居民_成员信息>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.事务科.低收入居民_成员信息 stru = new DB.Stru.事务科.低收入居民_成员信息();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.事务科.低收入居民_成员信息> lst )
        {
            DB.Orm.事务科.低收入居民_成员信息 orm = new DB.Orm.事务科.低收入居民_成员信息();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.事务科.低收入居民_成员信息 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.事务科.低收入居民_成员信息 StruFromList_ByID( ref List<DB.Stru.事务科.低收入居民_成员信息> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.事务科.低收入居民_成员信息 stru in list )
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
                dr[ DB.Tab.事务科.低收入居民_成员信息.ID ] = ID;

            CheckData();

            dr[ DB.Tab.事务科.低收入居民_成员信息.父ID ] = 父ID;
            dr[ DB.Tab.事务科.低收入居民_成员信息.姓名 ] = 姓名;
            dr[ DB.Tab.事务科.低收入居民_成员信息.性别 ] = 性别;
            dr[ DB.Tab.事务科.低收入居民_成员信息.身份证 ] = 身份证;
            dr[ DB.Tab.事务科.低收入居民_成员信息.家庭人数 ] = 家庭人数;
            dr[ DB.Tab.事务科.低收入居民_成员信息.保障人数 ] = 保障人数;
            dr[ DB.Tab.事务科.低收入居民_成员信息.家庭月收入 ] = 家庭月收入;
            dr[ DB.Tab.事务科.低收入居民_成员信息.成员类型 ] = 成员类型;
        }

        public void CopyFrom( DB.Stru.事务科.低收入居民_成员信息 struFrom )
        {
            ID = struFrom.ID;
            父ID = struFrom.父ID;
            姓名 = struFrom.姓名;
            性别 = struFrom.性别;
            身份证 = struFrom.身份证;
            家庭人数 = struFrom.家庭人数;
            保障人数 = struFrom.保障人数;
            家庭月收入 = struFrom.家庭月收入;
            成员类型 = struFrom.成员类型;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.事务科.低收入居民_成员信息 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( 父ID.Trim() != struOrg.父ID.Trim() )
                ary.Add( String.Format( "[父ID]: {0} => {1}", struOrg.父ID, 父ID ) );

            if ( 姓名.Trim() != struOrg.姓名.Trim() )
                ary.Add( String.Format( "[姓名]: {0} => {1}", struOrg.姓名, 姓名 ) );

            if ( 性别.Trim() != struOrg.性别.Trim() )
                ary.Add( String.Format( "[性别]: {0} => {1}", struOrg.性别, 性别 ) );

            if ( 身份证.Trim() != struOrg.身份证.Trim() )
                ary.Add( String.Format( "[身份证]: {0} => {1}", struOrg.身份证, 身份证 ) );

            if ( 家庭人数.Trim() != struOrg.家庭人数.Trim() )
                ary.Add( String.Format( "[家庭人数]: {0} => {1}", struOrg.家庭人数, 家庭人数 ) );

            if ( 保障人数.Trim() != struOrg.保障人数.Trim() )
                ary.Add( String.Format( "[保障人数]: {0} => {1}", struOrg.保障人数, 保障人数 ) );

            if ( 家庭月收入.Trim() != struOrg.家庭月收入.Trim() )
                ary.Add( String.Format( "[家庭月收入]: {0} => {1}", struOrg.家庭月收入, 家庭月收入 ) );

            if ( 成员类型.Trim() != struOrg.成员类型.Trim() )
                ary.Add( String.Format( "[成员类型]: {0} => {1}", struOrg.成员类型, 成员类型 ) );


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}