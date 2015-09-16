


using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.老龄办
{
    public partial class 发放老龄津贴
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _姓名 = String.Empty;
        string _身份证 = String.Empty;
        string _出生日期 = String.Empty;
        string _街道 = String.Empty;
        string _类别 = String.Empty;
        string _领取时间 = String.Empty;
        string _银行账号 = String.Empty;
        string _状态 = String.Empty;
        string _死亡 = String.Empty;
        string _DelFlag = String.Empty;

        public 发放老龄津贴()
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
        public DateTime datCreateDate
        {
            set { _CreateDate = value.ToString( "yyyy-MM-dd HH:mm:ss" ); }
            get { return FF.Fun.MyConvert.Str2Date( _CreateDate ); }
        }
        public string CreateDateStr
        {
            get { return FF.Fun.MyConvert.Str2Date( _CreateDate ).ToString( "yyyy-MM-dd" ); }
        }

        public string Creator
        {
            set { _Creator = value; }
            get { return _Creator; }
        }

        public string 姓名
        {
            set { _姓名 = value; }
            get { return _姓名; }
        }

        public string 身份证
        {
            set { _身份证 = value; }
            get { return _身份证; }
        }

        public string 出生日期
        {
            set { _出生日期 = value; }
            get { return _出生日期; }
        }
        public DateTime dat出生日期
        {
            set { _出生日期 = value.ToString( "yyyy-MM-dd HH:mm:ss" ); }
            get { return FF.Fun.MyConvert.Str2Date( _出生日期 ); }
        }
        public string 出生日期Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _出生日期 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 街道
        {
            set { _街道 = value; }
            get { return _街道; }
        }

        public string 类别
        {
            set { _类别 = value; }
            get { return _类别; }
        }

        public string 领取时间
        {
            set { _领取时间 = value; }
            get { return _领取时间; }
        }
        public DateTime dat领取时间
        {
            set { _领取时间 = value.ToString( "yyyy-MM-dd HH:mm:ss" ); }
            get { return FF.Fun.MyConvert.Str2Date( _领取时间 ); }
        }
        public string 领取时间Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _领取时间 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 银行账号
        {
            set { _银行账号 = value; }
            get { return _银行账号; }
        }

        public string 状态
        {
            set { _状态 = value; }
            get { return _状态; }
        }

        public string 死亡
        {
            set { _死亡 = value; }
            get { return _死亡; }
        }

        public string DelFlag
        {
            set { _DelFlag = value; }
            get { return _DelFlag; }
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
            姓名 = String.Empty;
            身份证 = String.Empty;
            出生日期 = String.Empty;
            街道 = String.Empty;
            类别 = String.Empty;
            领取时间 = String.Empty;
            银行账号 = String.Empty;
            状态 = String.Empty;
            死亡 = String.Empty;
            DelFlag = String.Empty;

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

            ID = dr[ DB.Tab.老龄办.发放老龄津贴.ID ].ToString().Trim();
            CreateDate = dr[ DB.Tab.老龄办.发放老龄津贴.CreateDate ].ToString().Trim();
            Creator = dr[ DB.Tab.老龄办.发放老龄津贴.Creator ].ToString().Trim();
            姓名 = dr[ DB.Tab.老龄办.发放老龄津贴.姓名 ].ToString().Trim();
            身份证 = dr[ DB.Tab.老龄办.发放老龄津贴.身份证 ].ToString().Trim();
            出生日期 = dr[ DB.Tab.老龄办.发放老龄津贴.出生日期 ].ToString().Trim();
            街道 = dr[ DB.Tab.老龄办.发放老龄津贴.街道 ].ToString().Trim();
            类别 = dr[ DB.Tab.老龄办.发放老龄津贴.类别 ].ToString().Trim();
            领取时间 = dr[ DB.Tab.老龄办.发放老龄津贴.领取时间 ].ToString().Trim();
            银行账号 = dr[ DB.Tab.老龄办.发放老龄津贴.银行账号 ].ToString().Trim();
            状态 = dr[ DB.Tab.老龄办.发放老龄津贴.状态 ].ToString().Trim();
            死亡 = dr[ DB.Tab.老龄办.发放老龄津贴.死亡 ].ToString().Trim();
            DelFlag = dr[ DB.Tab.老龄办.发放老龄津贴.DelFlag ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.老龄办.发放老龄津贴> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.老龄办.发放老龄津贴> lst = new List<DB.Stru.老龄办.发放老龄津贴>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.老龄办.发放老龄津贴 stru = new DB.Stru.老龄办.发放老龄津贴();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.老龄办.发放老龄津贴> lst )
        {
            DB.Orm.老龄办.发放老龄津贴 orm = new DB.Orm.老龄办.发放老龄津贴();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.老龄办.发放老龄津贴 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.老龄办.发放老龄津贴 StruFromList_ByID( ref List<DB.Stru.老龄办.发放老龄津贴> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.老龄办.发放老龄津贴 stru in list )
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

            if ( DelFlag == String.Empty )
                DelFlag = "False";
        }

        public void Stru2Dr( ref DataRow dr )
        {
            if ( ID.Trim() != String.Empty )
                dr[ DB.Tab.老龄办.发放老龄津贴.ID ] = ID;

            CheckData();

            if ( CreateDate != String.Empty )
                dr[ DB.Tab.老龄办.发放老龄津贴.CreateDate ] = CreateDate;
            dr[ DB.Tab.老龄办.发放老龄津贴.Creator ] = Creator;
            dr[ DB.Tab.老龄办.发放老龄津贴.姓名 ] = 姓名;
            dr[ DB.Tab.老龄办.发放老龄津贴.身份证 ] = 身份证;
            if ( 出生日期 != String.Empty )
                dr[ DB.Tab.老龄办.发放老龄津贴.出生日期 ] = 出生日期;
            dr[ DB.Tab.老龄办.发放老龄津贴.街道 ] = 街道;
            dr[ DB.Tab.老龄办.发放老龄津贴.类别 ] = 类别;
            if ( 领取时间 != String.Empty )
                dr[ DB.Tab.老龄办.发放老龄津贴.领取时间 ] = 领取时间;
            dr[ DB.Tab.老龄办.发放老龄津贴.银行账号 ] = 银行账号;
            dr[ DB.Tab.老龄办.发放老龄津贴.状态 ] = 状态;
            dr[ DB.Tab.老龄办.发放老龄津贴.死亡 ] = 死亡;
            dr[ DB.Tab.老龄办.发放老龄津贴.DelFlag ] = DelFlag;
        }

        public void CopyFrom( DB.Stru.老龄办.发放老龄津贴 struFrom )
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            姓名 = struFrom.姓名;
            身份证 = struFrom.身份证;
            出生日期 = struFrom.出生日期;
            街道 = struFrom.街道;
            类别 = struFrom.类别;
            领取时间 = struFrom.领取时间;
            银行账号 = struFrom.银行账号;
            状态 = struFrom.状态;
            死亡 = struFrom.死亡;
            DelFlag = struFrom.DelFlag;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.老龄办.发放老龄津贴 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
                ary.Add( String.Format( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate ) );

            if ( Creator.Trim() != struOrg.Creator.Trim() )
                ary.Add( String.Format( "[Creator]: {0} => {1}", struOrg.Creator, Creator ) );

            if ( 姓名.Trim() != struOrg.姓名.Trim() )
                ary.Add( String.Format( "[姓名]: {0} => {1}", struOrg.姓名, 姓名 ) );

            if ( 身份证.Trim() != struOrg.身份证.Trim() )
                ary.Add( String.Format( "[身份证]: {0} => {1}", struOrg.身份证, 身份证 ) );

            if ( 出生日期.Trim() != struOrg.出生日期.Trim() )
                ary.Add( String.Format( "[出生日期]: {0} => {1}", struOrg.出生日期, 出生日期 ) );

            if ( 街道.Trim() != struOrg.街道.Trim() )
                ary.Add( String.Format( "[街道]: {0} => {1}", struOrg.街道, 街道 ) );

            if ( 类别.Trim() != struOrg.类别.Trim() )
                ary.Add( String.Format( "[类别]: {0} => {1}", struOrg.类别, 类别 ) );

            if ( 领取时间.Trim() != struOrg.领取时间.Trim() )
                ary.Add( String.Format( "[领取时间]: {0} => {1}", struOrg.领取时间, 领取时间 ) );

            if ( 银行账号.Trim() != struOrg.银行账号.Trim() )
                ary.Add( String.Format( "[银行账号]: {0} => {1}", struOrg.银行账号, 银行账号 ) );

            if ( 状态.Trim() != struOrg.状态.Trim() )
                ary.Add( String.Format( "[状态]: {0} => {1}", struOrg.状态, 状态 ) );

            if ( 死亡.Trim() != struOrg.死亡.Trim() )
                ary.Add( String.Format( "[死亡]: {0} => {1}", struOrg.死亡, 死亡 ) );

            if ( DelFlag.Trim() != struOrg.DelFlag.Trim() )
                ary.Add( String.Format( "[DelFlag]: {0} => {1}", struOrg.DelFlag, DelFlag ) );


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}