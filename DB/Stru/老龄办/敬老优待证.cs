

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.老龄办
{
    public class 敬老优待证
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Crerator = String.Empty;
        string _人员编码 = String.Empty;
        string _姓名 = String.Empty;
        string _身份证号码 = String.Empty;
        string _性别 = String.Empty;
        string _出生日期 = String.Empty;
        string _电话 = String.Empty;
        string _街道 = String.Empty;
        string _单位或住址 = String.Empty;
        string _证件编号 = String.Empty;
        string _优待证类别 = String.Empty;
        string _照片回执号 = String.Empty;
        string _DelFlag = String.Empty;

        public 敬老优待证()
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

        public string Crerator
        {
            set { _Crerator = value; }
            get { return _Crerator; }
        }

        public string 人员编码
        {
            set { _人员编码 = value; }
            get { return _人员编码; }
        }

        public string 姓名
        {
            set { _姓名 = value; }
            get { return _姓名; }
        }

        public string 身份证号码
        {
            set { _身份证号码 = value; }
            get { return _身份证号码; }
        }

        public string 性别
        {
            set { _性别 = value; }
            get { return _性别; }
        }

        public string 出生日期
        {
            set { _出生日期 = value; }
            get { return _出生日期; }
        }
        public string 出生日期Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _出生日期 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 电话
        {
            set { _电话 = value; }
            get { return _电话; }
        }

        public string 街道
        {
            set { _街道 = value; }
            get { return _街道; }
        }

        public string 单位或住址
        {
            set { _单位或住址 = value; }
            get { return _单位或住址; }
        }

        public string 证件编号
        {
            set { _证件编号 = value; }
            get { return _证件编号; }
        }

        public string 优待证类别
        {
            set { _优待证类别 = value; }
            get { return _优待证类别; }
        }

        public string 照片回执号
        {
            set { _照片回执号 = value; }
            get { return _照片回执号; }
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
            Crerator = String.Empty;
            人员编码 = String.Empty;
            姓名 = String.Empty;
            身份证号码 = String.Empty;
            性别 = String.Empty;
            出生日期 = String.Empty;
            电话 = String.Empty;
            街道 = String.Empty;
            单位或住址 = String.Empty;
            证件编号 = String.Empty;
            优待证类别 = String.Empty;
            照片回执号 = String.Empty;
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

            ID = dr[ DB.Tab.老龄办.敬老优待证.ID ].ToString().Trim();
            CreateDate = dr[ DB.Tab.老龄办.敬老优待证.CreateDate ].ToString().Trim();
            Crerator = dr[ DB.Tab.老龄办.敬老优待证.Crerator ].ToString().Trim();
            人员编码 = dr[ DB.Tab.老龄办.敬老优待证.人员编码 ].ToString().Trim();
            姓名 = dr[ DB.Tab.老龄办.敬老优待证.姓名 ].ToString().Trim();
            身份证号码 = dr[ DB.Tab.老龄办.敬老优待证.身份证号码 ].ToString().Trim();
            性别 = dr[ DB.Tab.老龄办.敬老优待证.性别 ].ToString().Trim();
            出生日期 = dr[ DB.Tab.老龄办.敬老优待证.出生日期 ].ToString().Trim();
            电话 = dr[ DB.Tab.老龄办.敬老优待证.电话 ].ToString().Trim();
            街道 = dr[ DB.Tab.老龄办.敬老优待证.街道 ].ToString().Trim();
            单位或住址 = dr[ DB.Tab.老龄办.敬老优待证.单位或住址 ].ToString().Trim();
            证件编号 = dr[ DB.Tab.老龄办.敬老优待证.证件编号 ].ToString().Trim();
            优待证类别 = dr[ DB.Tab.老龄办.敬老优待证.优待证类别 ].ToString().Trim();
            照片回执号 = dr[ DB.Tab.老龄办.敬老优待证.照片回执号 ].ToString().Trim();
            DelFlag = dr[ DB.Tab.老龄办.敬老优待证.DelFlag ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.老龄办.敬老优待证> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.老龄办.敬老优待证> lst = new List<DB.Stru.老龄办.敬老优待证>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.老龄办.敬老优待证 stru = new DB.Stru.老龄办.敬老优待证();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.老龄办.敬老优待证> lst )
        {
            DB.Orm.老龄办.敬老优待证 orm = new DB.Orm.老龄办.敬老优待证();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.老龄办.敬老优待证 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.老龄办.敬老优待证 StruFromList_ByID( ref List<DB.Stru.老龄办.敬老优待证> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.老龄办.敬老优待证 stru in list )
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
                dr[ DB.Tab.老龄办.敬老优待证.ID ] = ID;

            CheckData();

            if ( CreateDate != String.Empty )
                dr[ DB.Tab.老龄办.敬老优待证.CreateDate ] = CreateDate;
            dr[ DB.Tab.老龄办.敬老优待证.Crerator ] = Crerator;
            dr[ DB.Tab.老龄办.敬老优待证.人员编码 ] = 人员编码;
            dr[ DB.Tab.老龄办.敬老优待证.姓名 ] = 姓名;
            dr[ DB.Tab.老龄办.敬老优待证.身份证号码 ] = 身份证号码;
            dr[ DB.Tab.老龄办.敬老优待证.性别 ] = 性别;
            if ( 出生日期 != String.Empty )
                dr[ DB.Tab.老龄办.敬老优待证.出生日期 ] = 出生日期;
            dr[ DB.Tab.老龄办.敬老优待证.电话 ] = 电话;
            dr[ DB.Tab.老龄办.敬老优待证.街道 ] = 街道;
            dr[ DB.Tab.老龄办.敬老优待证.单位或住址 ] = 单位或住址;
            dr[ DB.Tab.老龄办.敬老优待证.证件编号 ] = 证件编号;
            dr[ DB.Tab.老龄办.敬老优待证.优待证类别 ] = 优待证类别;
            dr[ DB.Tab.老龄办.敬老优待证.照片回执号 ] = 照片回执号;
            dr[ DB.Tab.老龄办.敬老优待证.DelFlag ] = DelFlag;
        }

        public void CopyFrom( DB.Stru.老龄办.敬老优待证 struFrom )
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Crerator = struFrom.Crerator;
            人员编码 = struFrom.人员编码;
            姓名 = struFrom.姓名;
            身份证号码 = struFrom.身份证号码;
            性别 = struFrom.性别;
            出生日期 = struFrom.出生日期;
            电话 = struFrom.电话;
            街道 = struFrom.街道;
            单位或住址 = struFrom.单位或住址;
            证件编号 = struFrom.证件编号;
            优待证类别 = struFrom.优待证类别;
            照片回执号 = struFrom.照片回执号;
            DelFlag = struFrom.DelFlag;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.老龄办.敬老优待证 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
                ary.Add( String.Format( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate ) );

            if ( Crerator.Trim() != struOrg.Crerator.Trim() )
                ary.Add( String.Format( "[Crerator]: {0} => {1}", struOrg.Crerator, Crerator ) );

            if ( 人员编码.Trim() != struOrg.人员编码.Trim() )
                ary.Add( String.Format( "[人员编码]: {0} => {1}", struOrg.人员编码, 人员编码 ) );

            if ( 姓名.Trim() != struOrg.姓名.Trim() )
                ary.Add( String.Format( "[姓名]: {0} => {1}", struOrg.姓名, 姓名 ) );

            if ( 身份证号码.Trim() != struOrg.身份证号码.Trim() )
                ary.Add( String.Format( "[身份证号码]: {0} => {1}", struOrg.身份证号码, 身份证号码 ) );

            if ( 性别.Trim() != struOrg.性别.Trim() )
                ary.Add( String.Format( "[性别]: {0} => {1}", struOrg.性别, 性别 ) );

            if ( 出生日期.Trim() != struOrg.出生日期.Trim() )
                ary.Add( String.Format( "[出生日期]: {0} => {1}", struOrg.出生日期, 出生日期 ) );

            if ( 电话.Trim() != struOrg.电话.Trim() )
                ary.Add( String.Format( "[电话]: {0} => {1}", struOrg.电话, 电话 ) );

            if ( 街道.Trim() != struOrg.街道.Trim() )
                ary.Add( String.Format( "[街道]: {0} => {1}", struOrg.街道, 街道 ) );

            if ( 单位或住址.Trim() != struOrg.单位或住址.Trim() )
                ary.Add( String.Format( "[单位或住址]: {0} => {1}", struOrg.单位或住址, 单位或住址 ) );

            if ( 证件编号.Trim() != struOrg.证件编号.Trim() )
                ary.Add( String.Format( "[证件编号]: {0} => {1}", struOrg.证件编号, 证件编号 ) );

            if ( 优待证类别.Trim() != struOrg.优待证类别.Trim() )
                ary.Add( String.Format( "[优待证类别]: {0} => {1}", struOrg.优待证类别, 优待证类别 ) );

            if ( 照片回执号.Trim() != struOrg.照片回执号.Trim() )
                ary.Add( String.Format( "[照片回执号]: {0} => {1}", struOrg.照片回执号, 照片回执号 ) );

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