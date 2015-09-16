


using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.事务科
{
    public class 专项救助_疾病救助
    {
        string _ID = String.Empty;
        string _所属街道 = String.Empty;
        string _姓名 = String.Empty;
        string _性别 = String.Empty;
        string _联系电话 = String.Empty;
        string _救助原因 = String.Empty;
        string _金额 = String.Empty;
        string _救助时间 = String.Empty;
        string _类别 = String.Empty;
        string _备注 = String.Empty;

        public 专项救助_疾病救助()
        {
            Init();
        }

        #region Prop

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string 所属街道
        {
            set { _所属街道 = value; }
            get { return _所属街道; }
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

        public string 联系电话
        {
            set { _联系电话 = value; }
            get { return _联系电话; }
        }

        public string 救助原因
        {
            set { _救助原因 = value; }
            get { return _救助原因; }
        }

        public string 金额
        {
            set { _金额 = value; }
            get { return _金额; }
        }

        public string 救助时间
        {
            set { _救助时间 = value; }
            get { return _救助时间; }
        }
        public DateTime dat救助时间
        {
            set { _救助时间 = value.ToString( "yyyy-MM-dd HH:mm:ss" ); }
            get { return FF.Fun.MyConvert.Str2Date( _救助时间 ); }
        }
        public string 救助时间Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _救助时间 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 类别
        {
            set { _类别 = value; }
            get { return _类别; }
        }

        public string 备注
        {
            set { _备注 = value; }
            get { return _备注; }
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
            所属街道 = String.Empty;
            姓名 = String.Empty;
            性别 = String.Empty;
            联系电话 = String.Empty;
            救助原因 = String.Empty;
            金额 = String.Empty;
            救助时间 = String.Empty;
            类别 = String.Empty;
            备注 = String.Empty;

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

            ID = dr[ DB.Tab.事务科.专项救助_疾病救助.ID ].ToString().Trim();
            所属街道 = dr[ DB.Tab.事务科.专项救助_疾病救助.所属街道 ].ToString().Trim();
            姓名 = dr[ DB.Tab.事务科.专项救助_疾病救助.姓名 ].ToString().Trim();
            性别 = dr[ DB.Tab.事务科.专项救助_疾病救助.性别 ].ToString().Trim();
            联系电话 = dr[ DB.Tab.事务科.专项救助_疾病救助.联系电话 ].ToString().Trim();
            救助原因 = dr[ DB.Tab.事务科.专项救助_疾病救助.救助原因 ].ToString().Trim();
            金额 = dr[ DB.Tab.事务科.专项救助_疾病救助.金额 ].ToString().Trim();
            救助时间 = dr[ DB.Tab.事务科.专项救助_疾病救助.救助时间 ].ToString().Trim();
            类别 = dr[ DB.Tab.事务科.专项救助_疾病救助.类别 ].ToString().Trim();
            备注 = dr[ DB.Tab.事务科.专项救助_疾病救助.备注 ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.事务科.专项救助_疾病救助> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.事务科.专项救助_疾病救助> lst = new List<DB.Stru.事务科.专项救助_疾病救助>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.事务科.专项救助_疾病救助 stru = new DB.Stru.事务科.专项救助_疾病救助();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.事务科.专项救助_疾病救助> lst )
        {
            DB.Orm.事务科.专项救助_疾病救助 orm = new DB.Orm.事务科.专项救助_疾病救助();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.事务科.专项救助_疾病救助 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.事务科.专项救助_疾病救助 StruFromList_ByID( ref List<DB.Stru.事务科.专项救助_疾病救助> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.事务科.专项救助_疾病救助 stru in list )
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
                dr[ DB.Tab.事务科.专项救助_疾病救助.ID ] = ID;

            CheckData();

            dr[ DB.Tab.事务科.专项救助_疾病救助.所属街道 ] = 所属街道;
            dr[ DB.Tab.事务科.专项救助_疾病救助.姓名 ] = 姓名;
            dr[ DB.Tab.事务科.专项救助_疾病救助.性别 ] = 性别;
            dr[ DB.Tab.事务科.专项救助_疾病救助.联系电话 ] = 联系电话;
            dr[ DB.Tab.事务科.专项救助_疾病救助.救助原因 ] = 救助原因;
            dr[ DB.Tab.事务科.专项救助_疾病救助.金额 ] = 金额;
            if ( 救助时间 != String.Empty )
                dr[ DB.Tab.事务科.专项救助_疾病救助.救助时间 ] = 救助时间;
            dr[ DB.Tab.事务科.专项救助_疾病救助.类别 ] = 类别;
            dr[ DB.Tab.事务科.专项救助_疾病救助.备注 ] = 备注;
        }

        public void CopyFrom( DB.Stru.事务科.专项救助_疾病救助 struFrom )
        {
            ID = struFrom.ID;
            所属街道 = struFrom.所属街道;
            姓名 = struFrom.姓名;
            性别 = struFrom.性别;
            联系电话 = struFrom.联系电话;
            救助原因 = struFrom.救助原因;
            金额 = struFrom.金额;
            救助时间 = struFrom.救助时间;
            类别 = struFrom.类别;
            备注 = struFrom.备注;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.事务科.专项救助_疾病救助 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( 所属街道.Trim() != struOrg.所属街道.Trim() )
                ary.Add( String.Format( "[所属街道]: {0} => {1}", struOrg.所属街道, 所属街道 ) );

            if ( 姓名.Trim() != struOrg.姓名.Trim() )
                ary.Add( String.Format( "[姓名]: {0} => {1}", struOrg.姓名, 姓名 ) );

            if ( 性别.Trim() != struOrg.性别.Trim() )
                ary.Add( String.Format( "[性别]: {0} => {1}", struOrg.性别, 性别 ) );

            if ( 联系电话.Trim() != struOrg.联系电话.Trim() )
                ary.Add( String.Format( "[联系电话]: {0} => {1}", struOrg.联系电话, 联系电话 ) );

            if ( 救助原因.Trim() != struOrg.救助原因.Trim() )
                ary.Add( String.Format( "[救助原因]: {0} => {1}", struOrg.救助原因, 救助原因 ) );

            if ( 金额.Trim() != struOrg.金额.Trim() )
                ary.Add( String.Format( "[金额]: {0} => {1}", struOrg.金额, 金额 ) );

            if ( 救助时间.Trim() != struOrg.救助时间.Trim() )
                ary.Add( String.Format( "[救助时间]: {0} => {1}", struOrg.救助时间, 救助时间 ) );

            if ( 类别.Trim() != struOrg.类别.Trim() )
                ary.Add( String.Format( "[类别]: {0} => {1}", struOrg.类别, 类别 ) );

            if ( 备注.Trim() != struOrg.备注.Trim() )
                ary.Add( String.Format( "[备注]: {0} => {1}", struOrg.备注, 备注 ) );


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}