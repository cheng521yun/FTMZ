
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.优抚科.优抚对象.参战涉核人员
{
    public class 生活费来源
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _优抚对象ID = String.Empty;
        string _定期生活补助金 = String.Empty;
        string _优待金 = String.Empty;
        string _最低生活保障金 = String.Empty;
        string _工资 = String.Empty;
        string _养老金 = String.Empty;
        string _离退休费 = String.Empty;
        string _一次性抚恤金 = String.Empty;
        string _特别抚恤金 = String.Empty;
        string _其他 = String.Empty;
        string _开户银行账号 = String.Empty;
        string _开户银行名称 = String.Empty;
        string _开户银行地址 = String.Empty;
        string _录入时间 = String.Empty;
        string _录入人 = String.Empty;
        string _负责人 = String.Empty;
        string _DelFlag = String.Empty;

        public 生活费来源()
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
        public string CreateDateStr
        {
            get { return FF.Fun.MyConvert.Str2Date( _CreateDate ).ToString( "yyyy-MM-dd" ); }
        }

        public string Creator
        {
            set { _Creator = value; }
            get { return _Creator; }
        }

        public string 优抚对象ID
        {
            set { _优抚对象ID = value; }
            get { return _优抚对象ID; }
        }

        public string 定期生活补助金
        {
            set { _定期生活补助金 = value; }
            get { return _定期生活补助金; }
        }

        public string 优待金
        {
            set { _优待金 = value; }
            get { return _优待金; }
        }

        public string 最低生活保障金
        {
            set { _最低生活保障金 = value; }
            get { return _最低生活保障金; }
        }

        public string 工资
        {
            set { _工资 = value; }
            get { return _工资; }
        }

        public string 养老金
        {
            set { _养老金 = value; }
            get { return _养老金; }
        }

        public string 离退休费
        {
            set { _离退休费 = value; }
            get { return _离退休费; }
        }

        public string 一次性抚恤金
        {
            set { _一次性抚恤金 = value; }
            get { return _一次性抚恤金; }
        }

        public string 特别抚恤金
        {
            set { _特别抚恤金 = value; }
            get { return _特别抚恤金; }
        }

        public string 其他
        {
            set { _其他 = value; }
            get { return _其他; }
        }

        public string 开户银行账号
        {
            set { _开户银行账号 = value; }
            get { return _开户银行账号; }
        }

        public string 开户银行名称
        {
            set { _开户银行名称 = value; }
            get { return _开户银行名称; }
        }

        public string 开户银行地址
        {
            set { _开户银行地址 = value; }
            get { return _开户银行地址; }
        }

        public string 录入时间
        {
            set { _录入时间 = value; }
            get { return _录入时间; }
        }
        public string 录入时间Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _录入时间 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 录入人
        {
            set { _录入人 = value; }
            get { return _录入人; }
        }

        public string 负责人
        {
            set { _负责人 = value; }
            get { return _负责人; }
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
            优抚对象ID = String.Empty;
            定期生活补助金 = String.Empty;
            优待金 = String.Empty;
            最低生活保障金 = String.Empty;
            工资 = String.Empty;
            养老金 = String.Empty;
            离退休费 = String.Empty;
            一次性抚恤金 = String.Empty;
            特别抚恤金 = String.Empty;
            其他 = String.Empty;
            开户银行账号 = String.Empty;
            开户银行名称 = String.Empty;
            开户银行地址 = String.Empty;
            录入时间 = String.Empty;
            录入人 = String.Empty;
            负责人 = String.Empty;
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

            ID = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.ID ].ToString().Trim();
            CreateDate = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.CreateDate ].ToString().Trim();
            Creator = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.Creator ].ToString().Trim();
            优抚对象ID = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.优抚对象ID ].ToString().Trim();
            定期生活补助金 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.定期生活补助金 ].ToString().Trim();
            优待金 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.优待金 ].ToString().Trim();
            最低生活保障金 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.最低生活保障金 ].ToString().Trim();
            工资 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.工资 ].ToString().Trim();
            养老金 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.养老金 ].ToString().Trim();
            离退休费 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.离退休费 ].ToString().Trim();
            一次性抚恤金 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.一次性抚恤金 ].ToString().Trim();
            特别抚恤金 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.特别抚恤金 ].ToString().Trim();
            其他 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.其他 ].ToString().Trim();
            开户银行账号 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.开户银行账号 ].ToString().Trim();
            开户银行名称 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.开户银行名称 ].ToString().Trim();
            开户银行地址 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.开户银行地址 ].ToString().Trim();
            录入时间 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.录入时间 ].ToString().Trim();
            录入人 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.录入人 ].ToString().Trim();
            负责人 = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.负责人 ].ToString().Trim();
            DelFlag = dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.DelFlag ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源> lst = new List<DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源 stru = new DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源> lst )
        {
            DB.Orm.优抚科.优抚对象.参战涉核人员.生活费来源 orm = new DB.Orm.优抚科.优抚对象.参战涉核人员.生活费来源();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源 StruFromList_ByID( ref List<DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源 stru in list )
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
                dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.ID ] = ID;

            CheckData();

            if ( CreateDate != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.CreateDate ] = CreateDate;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.Creator ] = Creator;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.优抚对象ID ] = 优抚对象ID;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.定期生活补助金 ] = 定期生活补助金;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.优待金 ] = 优待金;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.最低生活保障金 ] = 最低生活保障金;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.工资 ] = 工资;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.养老金 ] = 养老金;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.离退休费 ] = 离退休费;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.一次性抚恤金 ] = 一次性抚恤金;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.特别抚恤金 ] = 特别抚恤金;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.其他 ] = 其他;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.开户银行账号 ] = 开户银行账号;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.开户银行名称 ] = 开户银行名称;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.开户银行地址 ] = 开户银行地址;
            if ( 录入时间 != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.录入时间 ] = 录入时间;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.录入人 ] = 录入人;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.负责人 ] = 负责人;
            dr[ DB.Tab.优抚科.优抚对象.参战涉核人员.生活费来源.DelFlag ] = DelFlag;
        }

        public void CopyFrom( DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源 struFrom )
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            优抚对象ID = struFrom.优抚对象ID;
            定期生活补助金 = struFrom.定期生活补助金;
            优待金 = struFrom.优待金;
            最低生活保障金 = struFrom.最低生活保障金;
            工资 = struFrom.工资;
            养老金 = struFrom.养老金;
            离退休费 = struFrom.离退休费;
            一次性抚恤金 = struFrom.一次性抚恤金;
            特别抚恤金 = struFrom.特别抚恤金;
            其他 = struFrom.其他;
            开户银行账号 = struFrom.开户银行账号;
            开户银行名称 = struFrom.开户银行名称;
            开户银行地址 = struFrom.开户银行地址;
            录入时间 = struFrom.录入时间;
            录入人 = struFrom.录入人;
            负责人 = struFrom.负责人;
            DelFlag = struFrom.DelFlag;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.优抚科.优抚对象.参战涉核人员.生活费来源 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
                ary.Add( String.Format( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate ) );

            if ( Creator.Trim() != struOrg.Creator.Trim() )
                ary.Add( String.Format( "[Creator]: {0} => {1}", struOrg.Creator, Creator ) );

            if ( 优抚对象ID.Trim() != struOrg.优抚对象ID.Trim() )
                ary.Add( String.Format( "[优抚对象ID]: {0} => {1}", struOrg.优抚对象ID, 优抚对象ID ) );

            if ( 定期生活补助金.Trim() != struOrg.定期生活补助金.Trim() )
                ary.Add( String.Format( "[定期生活补助金]: {0} => {1}", struOrg.定期生活补助金, 定期生活补助金 ) );

            if ( 优待金.Trim() != struOrg.优待金.Trim() )
                ary.Add( String.Format( "[优待金]: {0} => {1}", struOrg.优待金, 优待金 ) );

            if ( 最低生活保障金.Trim() != struOrg.最低生活保障金.Trim() )
                ary.Add( String.Format( "[最低生活保障金]: {0} => {1}", struOrg.最低生活保障金, 最低生活保障金 ) );

            if ( 工资.Trim() != struOrg.工资.Trim() )
                ary.Add( String.Format( "[工资]: {0} => {1}", struOrg.工资, 工资 ) );

            if ( 养老金.Trim() != struOrg.养老金.Trim() )
                ary.Add( String.Format( "[养老金]: {0} => {1}", struOrg.养老金, 养老金 ) );

            if ( 离退休费.Trim() != struOrg.离退休费.Trim() )
                ary.Add( String.Format( "[离退休费]: {0} => {1}", struOrg.离退休费, 离退休费 ) );

            if ( 一次性抚恤金.Trim() != struOrg.一次性抚恤金.Trim() )
                ary.Add( String.Format( "[一次性抚恤金]: {0} => {1}", struOrg.一次性抚恤金, 一次性抚恤金 ) );

            if ( 特别抚恤金.Trim() != struOrg.特别抚恤金.Trim() )
                ary.Add( String.Format( "[特别抚恤金]: {0} => {1}", struOrg.特别抚恤金, 特别抚恤金 ) );

            if ( 其他.Trim() != struOrg.其他.Trim() )
                ary.Add( String.Format( "[其他]: {0} => {1}", struOrg.其他, 其他 ) );

            if ( 开户银行账号.Trim() != struOrg.开户银行账号.Trim() )
                ary.Add( String.Format( "[开户银行账号]: {0} => {1}", struOrg.开户银行账号, 开户银行账号 ) );

            if ( 开户银行名称.Trim() != struOrg.开户银行名称.Trim() )
                ary.Add( String.Format( "[开户银行名称]: {0} => {1}", struOrg.开户银行名称, 开户银行名称 ) );

            if ( 开户银行地址.Trim() != struOrg.开户银行地址.Trim() )
                ary.Add( String.Format( "[开户银行地址]: {0} => {1}", struOrg.开户银行地址, 开户银行地址 ) );

            if ( 录入时间.Trim() != struOrg.录入时间.Trim() )
                ary.Add( String.Format( "[录入时间]: {0} => {1}", struOrg.录入时间, 录入时间 ) );

            if ( 录入人.Trim() != struOrg.录入人.Trim() )
                ary.Add( String.Format( "[录入人]: {0} => {1}", struOrg.录入人, 录入人 ) );

            if ( 负责人.Trim() != struOrg.负责人.Trim() )
                ary.Add( String.Format( "[负责人]: {0} => {1}", struOrg.负责人, 负责人 ) );

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