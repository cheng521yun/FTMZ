


using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.事务科
{
    public class 低收入居民_发放记录
    {
        string _ID = String.Empty;
        string _父ID = String.Empty;
        string _审批时间 = String.Empty;
        string _待遇截止日期 = String.Empty;
        string _接收人 = String.Empty;
        string _低保证号 = String.Empty;
        string _发放年月 = String.Empty;
        string _发放类型 = String.Empty;

        public 低收入居民_发放记录()
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

        public string 审批时间
        {
            set { _审批时间 = value; }
            get { return _审批时间; }
        }
        public DateTime dat审批时间
        {
            set { _审批时间 = value.ToString( "yyyy-MM-dd HH:mm:ss" ); }
            get { return FF.Fun.MyConvert.Str2Date( _审批时间 ); }
        }
        public string 审批时间Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _审批时间 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 待遇截止日期
        {
            set { _待遇截止日期 = value; }
            get { return _待遇截止日期; }
        }
        public DateTime dat待遇截止日期
        {
            set { _待遇截止日期 = value.ToString( "yyyy-MM-dd HH:mm:ss" ); }
            get { return FF.Fun.MyConvert.Str2Date( _待遇截止日期 ); }
        }
        public string 待遇截止日期Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _待遇截止日期 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 接收人
        {
            set { _接收人 = value; }
            get { return _接收人; }
        }

        public string 低保证号
        {
            set { _低保证号 = value; }
            get { return _低保证号; }
        }

        public string 发放年月
        {
            set { _发放年月 = value; }
            get { return _发放年月; }
        }

        public string 发放类型
        {
            set { _发放类型 = value; }
            get { return _发放类型; }
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
            审批时间 = String.Empty;
            待遇截止日期 = String.Empty;
            接收人 = String.Empty;
            低保证号 = String.Empty;
            发放年月 = String.Empty;
            发放类型 = String.Empty;

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

            ID = dr[ DB.Tab.事务科.低收入居民_发放记录.ID ].ToString().Trim();
            父ID = dr[ DB.Tab.事务科.低收入居民_发放记录.父ID ].ToString().Trim();
            审批时间 = dr[ DB.Tab.事务科.低收入居民_发放记录.审批时间 ].ToString().Trim();
            待遇截止日期 = dr[ DB.Tab.事务科.低收入居民_发放记录.待遇截止日期 ].ToString().Trim();
            接收人 = dr[ DB.Tab.事务科.低收入居民_发放记录.接收人 ].ToString().Trim();
            低保证号 = dr[ DB.Tab.事务科.低收入居民_发放记录.低保证号 ].ToString().Trim();
            发放年月 = dr[ DB.Tab.事务科.低收入居民_发放记录.发放年月 ].ToString().Trim();
            发放类型 = dr[ DB.Tab.事务科.低收入居民_发放记录.发放类型 ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.事务科.低收入居民_发放记录> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.事务科.低收入居民_发放记录> lst = new List<DB.Stru.事务科.低收入居民_发放记录>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.事务科.低收入居民_发放记录 stru = new DB.Stru.事务科.低收入居民_发放记录();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.事务科.低收入居民_发放记录> lst )
        {
            DB.Orm.事务科.低收入居民_发放记录 orm = new DB.Orm.事务科.低收入居民_发放记录();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.事务科.低收入居民_发放记录 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.事务科.低收入居民_发放记录 StruFromList_ByID( ref List<DB.Stru.事务科.低收入居民_发放记录> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.事务科.低收入居民_发放记录 stru in list )
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
                dr[ DB.Tab.事务科.低收入居民_发放记录.ID ] = ID;

            CheckData();

            dr[ DB.Tab.事务科.低收入居民_发放记录.父ID ] = 父ID;
            if ( 审批时间 != String.Empty )
                dr[ DB.Tab.事务科.低收入居民_发放记录.审批时间 ] = 审批时间;
            if ( 待遇截止日期 != String.Empty )
                dr[ DB.Tab.事务科.低收入居民_发放记录.待遇截止日期 ] = 待遇截止日期;
            dr[ DB.Tab.事务科.低收入居民_发放记录.接收人 ] = 接收人;
            dr[ DB.Tab.事务科.低收入居民_发放记录.低保证号 ] = 低保证号;
            dr[ DB.Tab.事务科.低收入居民_发放记录.发放年月 ] = 发放年月;
            dr[ DB.Tab.事务科.低收入居民_发放记录.发放类型 ] = 发放类型;
        }

        public void CopyFrom( DB.Stru.事务科.低收入居民_发放记录 struFrom )
        {
            ID = struFrom.ID;
            父ID = struFrom.父ID;
            审批时间 = struFrom.审批时间;
            待遇截止日期 = struFrom.待遇截止日期;
            接收人 = struFrom.接收人;
            低保证号 = struFrom.低保证号;
            发放年月 = struFrom.发放年月;
            发放类型 = struFrom.发放类型;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.事务科.低收入居民_发放记录 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( 父ID.Trim() != struOrg.父ID.Trim() )
                ary.Add( String.Format( "[父ID]: {0} => {1}", struOrg.父ID, 父ID ) );

            if ( 审批时间.Trim() != struOrg.审批时间.Trim() )
                ary.Add( String.Format( "[审批时间]: {0} => {1}", struOrg.审批时间, 审批时间 ) );

            if ( 待遇截止日期.Trim() != struOrg.待遇截止日期.Trim() )
                ary.Add( String.Format( "[待遇截止日期]: {0} => {1}", struOrg.待遇截止日期, 待遇截止日期 ) );

            if ( 接收人.Trim() != struOrg.接收人.Trim() )
                ary.Add( String.Format( "[接收人]: {0} => {1}", struOrg.接收人, 接收人 ) );

            if ( 低保证号.Trim() != struOrg.低保证号.Trim() )
                ary.Add( String.Format( "[低保证号]: {0} => {1}", struOrg.低保证号, 低保证号 ) );

            if ( 发放年月.Trim() != struOrg.发放年月.Trim() )
                ary.Add( String.Format( "[发放年月]: {0} => {1}", struOrg.发放年月, 发放年月 ) );

            if ( 发放类型.Trim() != struOrg.发放类型.Trim() )
                ary.Add( String.Format( "[发放类型]: {0} => {1}", struOrg.发放类型, 发放类型 ) );


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}