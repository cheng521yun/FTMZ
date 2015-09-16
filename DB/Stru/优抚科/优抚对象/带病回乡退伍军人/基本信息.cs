
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.优抚科.优抚对象.带病回乡退伍军人
{
    public class 基本信息
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _优抚对象 = String.Empty;
        string _优抚对象类别 = String.Empty;
        string _行政区划 = String.Empty;
        string _姓名 = String.Empty;
        string _身份证号码 = String.Empty;
        string _出生日期 = String.Empty;
        string _性别 = String.Empty;
        string _民族 = String.Empty;
        string _婚姻状况 = String.Empty;
        string _是否精神病 = String.Empty;
        string _入伍时间 = String.Empty;
        string _退伍时间 = String.Empty;
        string _劳动能力 = String.Empty;
        string _生活能力 = String.Empty;
        string _就业情况 = String.Empty;
        string _户口类别 = String.Empty;
        string _户口簿住址类别 = String.Empty;
        string _联系电话 = String.Empty;
        string _工作单位 = String.Empty;
        string _户口簿住址 = String.Empty;
        string _实际居住地址 = String.Empty;
        string _优抚对象状态 = String.Empty;
        string _开始待遇年度 = String.Empty;
        string _停止待遇年度 = String.Empty;
        string _录入时间 = String.Empty;
        string _录入人 = String.Empty;
        string _负责人 = String.Empty;
        string _DelFlag = String.Empty;

        public 基本信息()
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

        public string 优抚对象
        {
            set { _优抚对象 = value; }
            get { return _优抚对象; }
        }

        public string 优抚对象类别
        {
            set { _优抚对象类别 = value; }
            get { return _优抚对象类别; }
        }

        public string 行政区划
        {
            set { _行政区划 = value; }
            get { return _行政区划; }
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

        public string 出生日期
        {
            set { _出生日期 = value; }
            get { return _出生日期; }
        }
        public string 出生日期Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _出生日期 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 性别
        {
            set { _性别 = value; }
            get { return _性别; }
        }

        public string 民族
        {
            set { _民族 = value; }
            get { return _民族; }
        }

        public string 婚姻状况
        {
            set { _婚姻状况 = value; }
            get { return _婚姻状况; }
        }

        public string 是否精神病
        {
            set { _是否精神病 = value; }
            get { return _是否精神病; }
        }

        public string 入伍时间
        {
            set { _入伍时间 = value; }
            get { return _入伍时间; }
        }
        public string 入伍时间Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _入伍时间 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 退伍时间
        {
            set { _退伍时间 = value; }
            get { return _退伍时间; }
        }
        public string 退伍时间Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _退伍时间 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 劳动能力
        {
            set { _劳动能力 = value; }
            get { return _劳动能力; }
        }

        public string 生活能力
        {
            set { _生活能力 = value; }
            get { return _生活能力; }
        }

        public string 就业情况
        {
            set { _就业情况 = value; }
            get { return _就业情况; }
        }

        public string 户口类别
        {
            set { _户口类别 = value; }
            get { return _户口类别; }
        }

        public string 户口簿住址类别
        {
            set { _户口簿住址类别 = value; }
            get { return _户口簿住址类别; }
        }

        public string 联系电话
        {
            set { _联系电话 = value; }
            get { return _联系电话; }
        }

        public string 工作单位
        {
            set { _工作单位 = value; }
            get { return _工作单位; }
        }

        public string 户口簿住址
        {
            set { _户口簿住址 = value; }
            get { return _户口簿住址; }
        }

        public string 实际居住地址
        {
            set { _实际居住地址 = value; }
            get { return _实际居住地址; }
        }

        public string 优抚对象状态
        {
            set { _优抚对象状态 = value; }
            get { return _优抚对象状态; }
        }

        public string 开始待遇年度
        {
            set { _开始待遇年度 = value; }
            get { return _开始待遇年度; }
        }
        public string 开始待遇年度Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _开始待遇年度 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 停止待遇年度
        {
            set { _停止待遇年度 = value; }
            get { return _停止待遇年度; }
        }
        public string 停止待遇年度Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _停止待遇年度 ).ToString( "yyyy-MM-dd" ); }
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
            优抚对象 = String.Empty;
            优抚对象类别 = String.Empty;
            行政区划 = String.Empty;
            姓名 = String.Empty;
            身份证号码 = String.Empty;
            出生日期 = String.Empty;
            性别 = String.Empty;
            民族 = String.Empty;
            婚姻状况 = String.Empty;
            是否精神病 = String.Empty;
            入伍时间 = String.Empty;
            退伍时间 = String.Empty;
            劳动能力 = String.Empty;
            生活能力 = String.Empty;
            就业情况 = String.Empty;
            户口类别 = String.Empty;
            户口簿住址类别 = String.Empty;
            联系电话 = String.Empty;
            工作单位 = String.Empty;
            户口簿住址 = String.Empty;
            实际居住地址 = String.Empty;
            优抚对象状态 = String.Empty;
            开始待遇年度 = String.Empty;
            停止待遇年度 = String.Empty;
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

            ID = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.ID ].ToString().Trim();
            CreateDate = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.CreateDate ].ToString().Trim();
            Creator = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.Creator ].ToString().Trim();
            优抚对象 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.优抚对象 ].ToString().Trim();
            优抚对象类别 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.优抚对象类别 ].ToString().Trim();
            行政区划 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.行政区划 ].ToString().Trim();
            姓名 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.姓名 ].ToString().Trim();
            身份证号码 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.身份证号码 ].ToString().Trim();
            出生日期 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.出生日期 ].ToString().Trim();
            性别 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.性别 ].ToString().Trim();
            民族 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.民族 ].ToString().Trim();
            婚姻状况 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.婚姻状况 ].ToString().Trim();
            是否精神病 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.是否精神病 ].ToString().Trim();
            入伍时间 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.入伍时间 ].ToString().Trim();
            退伍时间 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.退伍时间 ].ToString().Trim();
            劳动能力 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.劳动能力 ].ToString().Trim();
            生活能力 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.生活能力 ].ToString().Trim();
            就业情况 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.就业情况 ].ToString().Trim();
            户口类别 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.户口类别 ].ToString().Trim();
            户口簿住址类别 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.户口簿住址类别 ].ToString().Trim();
            联系电话 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.联系电话 ].ToString().Trim();
            工作单位 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.工作单位 ].ToString().Trim();
            户口簿住址 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.户口簿住址 ].ToString().Trim();
            实际居住地址 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.实际居住地址 ].ToString().Trim();
            优抚对象状态 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.优抚对象状态 ].ToString().Trim();
            开始待遇年度 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.开始待遇年度 ].ToString().Trim();
            停止待遇年度 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.停止待遇年度 ].ToString().Trim();
            录入时间 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.录入时间 ].ToString().Trim();
            录入人 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.录入人 ].ToString().Trim();
            负责人 = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.负责人 ].ToString().Trim();
            DelFlag = dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.DelFlag ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息> lst = new List<DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息 stru = new DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息> lst )
        {
            DB.Orm.优抚科.优抚对象.带病回乡退伍军人.基本信息 orm = new DB.Orm.优抚科.优抚对象.带病回乡退伍军人.基本信息();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息 StruFromList_ByID( ref List<DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息 stru in list )
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
                dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.ID ] = ID;

            CheckData();

            if ( CreateDate != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.CreateDate ] = CreateDate;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.Creator ] = Creator;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.优抚对象 ] = 优抚对象;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.优抚对象类别 ] = 优抚对象类别;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.行政区划 ] = 行政区划;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.姓名 ] = 姓名;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.身份证号码 ] = 身份证号码;
            if ( 出生日期 != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.出生日期 ] = 出生日期;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.性别 ] = 性别;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.民族 ] = 民族;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.婚姻状况 ] = 婚姻状况;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.是否精神病 ] = 是否精神病;
            if ( 入伍时间 != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.入伍时间 ] = 入伍时间;
            if ( 退伍时间 != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.退伍时间 ] = 退伍时间;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.劳动能力 ] = 劳动能力;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.生活能力 ] = 生活能力;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.就业情况 ] = 就业情况;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.户口类别 ] = 户口类别;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.户口簿住址类别 ] = 户口簿住址类别;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.联系电话 ] = 联系电话;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.工作单位 ] = 工作单位;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.户口簿住址 ] = 户口簿住址;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.实际居住地址 ] = 实际居住地址;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.优抚对象状态 ] = 优抚对象状态;
            if ( 开始待遇年度 != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.开始待遇年度 ] = 开始待遇年度;
            if ( 停止待遇年度 != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.停止待遇年度 ] = 停止待遇年度;
            if ( 录入时间 != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.录入时间 ] = 录入时间;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.录入人 ] = 录入人;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.负责人 ] = 负责人;
            dr[ DB.Tab.优抚科.优抚对象.带病回乡退伍军人.基本信息.DelFlag ] = DelFlag;
        }

        public void CopyFrom( DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息 struFrom )
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            优抚对象 = struFrom.优抚对象;
            优抚对象类别 = struFrom.优抚对象类别;
            行政区划 = struFrom.行政区划;
            姓名 = struFrom.姓名;
            身份证号码 = struFrom.身份证号码;
            出生日期 = struFrom.出生日期;
            性别 = struFrom.性别;
            民族 = struFrom.民族;
            婚姻状况 = struFrom.婚姻状况;
            是否精神病 = struFrom.是否精神病;
            入伍时间 = struFrom.入伍时间;
            退伍时间 = struFrom.退伍时间;
            劳动能力 = struFrom.劳动能力;
            生活能力 = struFrom.生活能力;
            就业情况 = struFrom.就业情况;
            户口类别 = struFrom.户口类别;
            户口簿住址类别 = struFrom.户口簿住址类别;
            联系电话 = struFrom.联系电话;
            工作单位 = struFrom.工作单位;
            户口簿住址 = struFrom.户口簿住址;
            实际居住地址 = struFrom.实际居住地址;
            优抚对象状态 = struFrom.优抚对象状态;
            开始待遇年度 = struFrom.开始待遇年度;
            停止待遇年度 = struFrom.停止待遇年度;
            录入时间 = struFrom.录入时间;
            录入人 = struFrom.录入人;
            负责人 = struFrom.负责人;
            DelFlag = struFrom.DelFlag;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.优抚科.优抚对象.带病回乡退伍军人.基本信息 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
                ary.Add( String.Format( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate ) );

            if ( Creator.Trim() != struOrg.Creator.Trim() )
                ary.Add( String.Format( "[Creator]: {0} => {1}", struOrg.Creator, Creator ) );

            if ( 优抚对象.Trim() != struOrg.优抚对象.Trim() )
                ary.Add( String.Format( "[优抚对象]: {0} => {1}", struOrg.优抚对象, 优抚对象 ) );

            if ( 优抚对象类别.Trim() != struOrg.优抚对象类别.Trim() )
                ary.Add( String.Format( "[优抚对象类别]: {0} => {1}", struOrg.优抚对象类别, 优抚对象类别 ) );

            if ( 行政区划.Trim() != struOrg.行政区划.Trim() )
                ary.Add( String.Format( "[行政区划]: {0} => {1}", struOrg.行政区划, 行政区划 ) );

            if ( 姓名.Trim() != struOrg.姓名.Trim() )
                ary.Add( String.Format( "[姓名]: {0} => {1}", struOrg.姓名, 姓名 ) );

            if ( 身份证号码.Trim() != struOrg.身份证号码.Trim() )
                ary.Add( String.Format( "[身份证号码]: {0} => {1}", struOrg.身份证号码, 身份证号码 ) );

            if ( 出生日期.Trim() != struOrg.出生日期.Trim() )
                ary.Add( String.Format( "[出生日期]: {0} => {1}", struOrg.出生日期, 出生日期 ) );

            if ( 性别.Trim() != struOrg.性别.Trim() )
                ary.Add( String.Format( "[性别]: {0} => {1}", struOrg.性别, 性别 ) );

            if ( 民族.Trim() != struOrg.民族.Trim() )
                ary.Add( String.Format( "[民族]: {0} => {1}", struOrg.民族, 民族 ) );

            if ( 婚姻状况.Trim() != struOrg.婚姻状况.Trim() )
                ary.Add( String.Format( "[婚姻状况]: {0} => {1}", struOrg.婚姻状况, 婚姻状况 ) );

            if ( 是否精神病.Trim() != struOrg.是否精神病.Trim() )
                ary.Add( String.Format( "[是否精神病]: {0} => {1}", struOrg.是否精神病, 是否精神病 ) );

            if ( 入伍时间.Trim() != struOrg.入伍时间.Trim() )
                ary.Add( String.Format( "[入伍时间]: {0} => {1}", struOrg.入伍时间, 入伍时间 ) );

            if ( 退伍时间.Trim() != struOrg.退伍时间.Trim() )
                ary.Add( String.Format( "[退伍时间]: {0} => {1}", struOrg.退伍时间, 退伍时间 ) );

            if ( 劳动能力.Trim() != struOrg.劳动能力.Trim() )
                ary.Add( String.Format( "[劳动能力]: {0} => {1}", struOrg.劳动能力, 劳动能力 ) );

            if ( 生活能力.Trim() != struOrg.生活能力.Trim() )
                ary.Add( String.Format( "[生活能力]: {0} => {1}", struOrg.生活能力, 生活能力 ) );

            if ( 就业情况.Trim() != struOrg.就业情况.Trim() )
                ary.Add( String.Format( "[就业情况]: {0} => {1}", struOrg.就业情况, 就业情况 ) );

            if ( 户口类别.Trim() != struOrg.户口类别.Trim() )
                ary.Add( String.Format( "[户口类别]: {0} => {1}", struOrg.户口类别, 户口类别 ) );

            if ( 户口簿住址类别.Trim() != struOrg.户口簿住址类别.Trim() )
                ary.Add( String.Format( "[户口簿住址类别]: {0} => {1}", struOrg.户口簿住址类别, 户口簿住址类别 ) );

            if ( 联系电话.Trim() != struOrg.联系电话.Trim() )
                ary.Add( String.Format( "[联系电话]: {0} => {1}", struOrg.联系电话, 联系电话 ) );

            if ( 工作单位.Trim() != struOrg.工作单位.Trim() )
                ary.Add( String.Format( "[工作单位]: {0} => {1}", struOrg.工作单位, 工作单位 ) );

            if ( 户口簿住址.Trim() != struOrg.户口簿住址.Trim() )
                ary.Add( String.Format( "[户口簿住址]: {0} => {1}", struOrg.户口簿住址, 户口簿住址 ) );

            if ( 实际居住地址.Trim() != struOrg.实际居住地址.Trim() )
                ary.Add( String.Format( "[实际居住地址]: {0} => {1}", struOrg.实际居住地址, 实际居住地址 ) );

            if ( 优抚对象状态.Trim() != struOrg.优抚对象状态.Trim() )
                ary.Add( String.Format( "[优抚对象状态]: {0} => {1}", struOrg.优抚对象状态, 优抚对象状态 ) );

            if ( 开始待遇年度.Trim() != struOrg.开始待遇年度.Trim() )
                ary.Add( String.Format( "[开始待遇年度]: {0} => {1}", struOrg.开始待遇年度, 开始待遇年度 ) );

            if ( 停止待遇年度.Trim() != struOrg.停止待遇年度.Trim() )
                ary.Add( String.Format( "[停止待遇年度]: {0} => {1}", struOrg.停止待遇年度, 停止待遇年度 ) );

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