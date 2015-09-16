using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru
{
    public class 人员
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _人员编号 = String.Empty;
        string _姓名 = String.Empty;
        string _性别 = String.Empty;
        string _身份证 = String.Empty;
        string _身份证照片回执号 = String.Empty;
        string _地址 = String.Empty;
        string _电话 = String.Empty;
        string _联系手机 = String.Empty;
        string _所属街道 = String.Empty;
        string _DelFlag = String.Empty;
        

        public 人员()
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

        public string 人员编号
        {
            set { _人员编号 = value; }
            get { return _人员编号; }
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
        public string 性别Str
        {
            set { _性别 = (value == "男")? "True":"False"; }
            get { return ( _性别=="True") ? "男":"女"; }
        }

        public string 身份证
        {
            set { _身份证 = value; }
            get { return _身份证; }
        }

        public string 身份证照片回执号
        {
            set { _身份证照片回执号 = value; }
            get { return _身份证照片回执号; }
        }

        public string 地址
        {
            set { _地址 = value; }
            get { return _地址; }
        }

        public string 电话
        {
            set { _电话 = value; }
            get { return _电话; }
        }

        public string 联系手机
        {
            set { _联系手机 = value; }
            get { return _联系手机; }
        }

        public string 所属街道
        {
            set { _所属街道 = value; }
            get { return _所属街道; }
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
            人员编号 = String.Empty;
            姓名 = String.Empty;
            性别 = String.Empty;
            身份证 = String.Empty;
            身份证照片回执号 = String.Empty;
            地址 = String.Empty;
            电话 = String.Empty;
            联系手机 = String.Empty;
            所属街道 = String.Empty;
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

            ID = dr[ Tab.人员.ID ].ToString().Trim();
            CreateDate = dr[ Tab.人员.CreateDate ].ToString().Trim();
            Creator = dr[ Tab.人员.Creator ].ToString().Trim();
            人员编号 = dr[ Tab.人员.人员编号 ].ToString().Trim();
            姓名 = dr[ Tab.人员.姓名 ].ToString().Trim();
            性别 = dr[ Tab.人员.性别 ].ToString().Trim();
            身份证 = dr[ Tab.人员.身份证 ].ToString().Trim();
            身份证照片回执号 = dr[ Tab.人员.身份证照片回执号 ].ToString().Trim();
            地址 = dr[ Tab.人员.地址 ].ToString().Trim();
            电话 = dr[ Tab.人员.电话 ].ToString().Trim();
            联系手机 = dr[ Tab.人员.联系手机 ].ToString().Trim();
            所属街道 = dr[ Tab.人员.所属街道 ].ToString().Trim();
            DelFlag = dr[ Tab.人员.DelFlag ].ToString().Trim();

            return true;
        }

        public static List<Stru.人员> Dt2List( ref DataTable dt )
        {
            List<Stru.人员> lst = new List<人员>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                Stru.人员 stru = new 人员();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<Stru.人员> lst )
        {
            ORM.人员 orm = new ORM.人员();
            DataTable dt = orm.GetBlank();

            foreach ( Stru.人员 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static Stru.人员 StruFromList_ByID( ref List<Stru.人员> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( Stru.人员 stru in list )
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

            if (String.IsNullOrEmpty(性别.Trim()))
                性别 = "True";

            if ( String.IsNullOrEmpty( DelFlag.Trim() ) )
                DelFlag = "False";
        }

        public void Stru2Dr( ref DataRow dr )
        {
            if ( ID.Trim() != String.Empty )
                dr[ Tab.人员.ID ] = ID;

            CheckData();

            dr[ Tab.人员.CreateDate ] = CreateDate;
            dr[ Tab.人员.Creator ] = Creator;
            dr[ Tab.人员.人员编号 ] = 人员编号;
            dr[ Tab.人员.姓名 ] = 姓名;
            dr[ Tab.人员.性别 ] = 性别;
            dr[ Tab.人员.身份证 ] = 身份证;
            dr[ Tab.人员.身份证照片回执号 ] = 身份证照片回执号;
            dr[ Tab.人员.地址 ] = 地址;
            dr[ Tab.人员.电话 ] = 电话;
            dr[ Tab.人员.联系手机 ] = 联系手机;
            dr[ Tab.人员.所属街道 ] = 所属街道;
            dr[ Tab.人员.DelFlag ] = DelFlag;
        }

        public void CopyFrom( 人员 struFrom )
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            人员编号 = struFrom.人员编号;
            姓名 = struFrom.姓名;
            性别 = struFrom.性别;
            身份证 = struFrom.身份证;
            身份证照片回执号 = struFrom.身份证照片回执号;
            地址 = struFrom.地址;
            电话 = struFrom.电话;
            联系手机 = struFrom.联系手机;
            所属街道 = struFrom.所属街道;
            DelFlag = struFrom.DelFlag;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( 人员 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
                ary.Add( String.Format( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate ) );

            if ( Creator.Trim() != struOrg.Creator.Trim() )
                ary.Add( String.Format( "[Creator]: {0} => {1}", struOrg.Creator, Creator ) );

            if ( 人员编号.Trim() != struOrg.人员编号.Trim() )
                ary.Add( String.Format( "[人员编号]: {0} => {1}", struOrg.人员编号, 人员编号 ) );

            if ( 姓名.Trim() != struOrg.姓名.Trim() )
                ary.Add( String.Format( "[姓名]: {0} => {1}", struOrg.姓名, 姓名 ) );

            if ( 性别.Trim() != struOrg.性别.Trim() )
                ary.Add( String.Format( "[性别]: {0} => {1}", struOrg.性别, 性别 ) );

            if ( 身份证.Trim() != struOrg.身份证.Trim() )
                ary.Add( String.Format( "[身份证]: {0} => {1}", struOrg.身份证, 身份证 ) );

            if ( 身份证照片回执号.Trim() != struOrg.身份证照片回执号.Trim() )
                ary.Add( String.Format( "[身份证照片回执号]: {0} => {1}", struOrg.身份证照片回执号, 身份证照片回执号 ) );

            if ( 地址.Trim() != struOrg.地址.Trim() )
                ary.Add( String.Format( "[地址]: {0} => {1}", struOrg.地址, 地址 ) );

            if ( 电话.Trim() != struOrg.电话.Trim() )
                ary.Add( String.Format( "[电话]: {0} => {1}", struOrg.电话, 电话 ) );

            if ( 联系手机.Trim() != struOrg.联系手机.Trim() )
                ary.Add( String.Format( "[联系手机]: {0} => {1}", struOrg.联系手机, 联系手机 ) );

            if ( 所属街道.Trim() != struOrg.所属街道.Trim() )
                ary.Add( String.Format( "[所属街道]: {0} => {1}", struOrg.所属街道, 所属街道 ) );

            if ( DelFlag.Trim() != struOrg.DelFlag.Trim() )
                ary.Add( String.Format( "[DelFlag]: {0} => {1}", struOrg.DelFlag, DelFlag ) );


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
            ary.Add( String.Format( "[人员编号] : {0} ", 人员编号 ) );
            ary.Add( String.Format( "[姓名] : {0} ", 姓名 ) );
            ary.Add( String.Format( "[性别] : {0} ", 性别 ) );
            ary.Add( String.Format( "[身份证] : {0} ", 身份证 ) );
            ary.Add( String.Format( "[身份证照片回执号] : {0} ", 身份证照片回执号 ) );
            ary.Add( String.Format( "[地址] : {0} ", 地址 ) );
            ary.Add( String.Format( "[电话] : {0} ", 电话 ) );
            ary.Add( String.Format( "[联系手机] : {0} ", 联系手机 ) );
            ary.Add( String.Format( "[所属街道] : {0} ", 所属街道 ) );
            ary.Add( String.Format( "[DelFlag] : {0} ", DelFlag ) );

            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
    }
}