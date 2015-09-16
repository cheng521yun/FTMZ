
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.优抚科
{
    public class 优抚资金发放
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _优抚对象 = String.Empty;
        string _优抚类别 = String.Empty;
        string _行政区划 = String.Empty;
        string _姓名 = String.Empty;
        string _身份证号 = String.Empty;
        string _性别 = String.Empty;
        string _户口类别 = String.Empty;
        string _优抚证书编号 = String.Empty;
        string _伤残等级 = String.Empty;
        string _发放金额 = String.Empty;

        public 优抚资金发放()
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

        public string 优抚类别
        {
            set { _优抚类别 = value; }
            get { return _优抚类别; }
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

        public string 身份证号
        {
            set { _身份证号 = value; }
            get { return _身份证号; }
        }

        public string 性别
        {
            set { _性别 = value; }
            get { return _性别; }
        }

        public string 户口类别
        {
            set { _户口类别 = value; }
            get { return _户口类别; }
        }

        public string 优抚证书编号
        {
            set { _优抚证书编号 = value; }
            get { return _优抚证书编号; }
        }

        public string 伤残等级
        {
            set { _伤残等级 = value; }
            get { return _伤残等级; }
        }

        public string 发放金额
        {
            set { _发放金额 = value; }
            get { return _发放金额; }
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
            优抚类别 = String.Empty;
            行政区划 = String.Empty;
            姓名 = String.Empty;
            身份证号 = String.Empty;
            性别 = String.Empty;
            户口类别 = String.Empty;
            优抚证书编号 = String.Empty;
            伤残等级 = String.Empty;
            发放金额 = String.Empty;

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

            ID = dr[ DB.Tab.优抚科.优抚资金发放.ID ].ToString().Trim();
            CreateDate = dr[ DB.Tab.优抚科.优抚资金发放.CreateDate ].ToString().Trim();
            Creator = dr[ DB.Tab.优抚科.优抚资金发放.Creator ].ToString().Trim();
            优抚对象 = dr[ DB.Tab.优抚科.优抚资金发放.优抚对象 ].ToString().Trim();
            优抚类别 = dr[ DB.Tab.优抚科.优抚资金发放.优抚类别 ].ToString().Trim();
            行政区划 = dr[ DB.Tab.优抚科.优抚资金发放.行政区划 ].ToString().Trim();
            姓名 = dr[ DB.Tab.优抚科.优抚资金发放.姓名 ].ToString().Trim();
            身份证号 = dr[ DB.Tab.优抚科.优抚资金发放.身份证号 ].ToString().Trim();
            性别 = dr[ DB.Tab.优抚科.优抚资金发放.性别 ].ToString().Trim();
            户口类别 = dr[ DB.Tab.优抚科.优抚资金发放.户口类别 ].ToString().Trim();
            优抚证书编号 = dr[ DB.Tab.优抚科.优抚资金发放.优抚证书编号 ].ToString().Trim();
            伤残等级 = dr[ DB.Tab.优抚科.优抚资金发放.伤残等级 ].ToString().Trim();
            发放金额 = dr[ DB.Tab.优抚科.优抚资金发放.发放金额 ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.优抚科.优抚资金发放> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.优抚科.优抚资金发放> lst = new List<DB.Stru.优抚科.优抚资金发放>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.优抚科.优抚资金发放 stru = new DB.Stru.优抚科.优抚资金发放();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.优抚科.优抚资金发放> lst )
        {
            DB.Orm.优抚科.优抚资金发放 orm = new DB.Orm.优抚科.优抚资金发放();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.优抚科.优抚资金发放 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.优抚科.优抚资金发放 StruFromList_ByID( ref List<DB.Stru.优抚科.优抚资金发放> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.优抚科.优抚资金发放 stru in list )
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

            //if ( DelFlag == String.Empty )
            //    DelFlag = "False";
        }

        public void Stru2Dr( ref DataRow dr )
        {
            if ( ID.Trim() != String.Empty )
                dr[ DB.Tab.优抚科.优抚资金发放.ID ] = ID;

            CheckData();

            if ( CreateDate != String.Empty )
                dr[ DB.Tab.优抚科.优抚资金发放.CreateDate ] = CreateDate;
            dr[ DB.Tab.优抚科.优抚资金发放.Creator ] = Creator;
            dr[ DB.Tab.优抚科.优抚资金发放.优抚对象 ] = 优抚对象;
            dr[ DB.Tab.优抚科.优抚资金发放.优抚类别 ] = 优抚类别;
            dr[ DB.Tab.优抚科.优抚资金发放.行政区划 ] = 行政区划;
            dr[ DB.Tab.优抚科.优抚资金发放.姓名 ] = 姓名;
            dr[ DB.Tab.优抚科.优抚资金发放.身份证号 ] = 身份证号;
            dr[ DB.Tab.优抚科.优抚资金发放.性别 ] = 性别;
            dr[ DB.Tab.优抚科.优抚资金发放.户口类别 ] = 户口类别;
            dr[ DB.Tab.优抚科.优抚资金发放.优抚证书编号 ] = 优抚证书编号;
            dr[ DB.Tab.优抚科.优抚资金发放.伤残等级 ] = 伤残等级;
            dr[ DB.Tab.优抚科.优抚资金发放.发放金额 ] = 发放金额;
        }

        public void CopyFrom( DB.Stru.优抚科.优抚资金发放 struFrom )
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            优抚对象 = struFrom.优抚对象;
            优抚类别 = struFrom.优抚类别;
            行政区划 = struFrom.行政区划;
            姓名 = struFrom.姓名;
            身份证号 = struFrom.身份证号;
            性别 = struFrom.性别;
            户口类别 = struFrom.户口类别;
            优抚证书编号 = struFrom.优抚证书编号;
            伤残等级 = struFrom.伤残等级;
            发放金额 = struFrom.发放金额;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.优抚科.优抚资金发放 struOrg )
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

            if ( 优抚类别.Trim() != struOrg.优抚类别.Trim() )
                ary.Add( String.Format( "[优抚类别]: {0} => {1}", struOrg.优抚类别, 优抚类别 ) );

            if ( 行政区划.Trim() != struOrg.行政区划.Trim() )
                ary.Add( String.Format( "[行政区划]: {0} => {1}", struOrg.行政区划, 行政区划 ) );

            if ( 姓名.Trim() != struOrg.姓名.Trim() )
                ary.Add( String.Format( "[姓名]: {0} => {1}", struOrg.姓名, 姓名 ) );

            if ( 身份证号.Trim() != struOrg.身份证号.Trim() )
                ary.Add( String.Format( "[身份证号]: {0} => {1}", struOrg.身份证号, 身份证号 ) );

            if ( 性别.Trim() != struOrg.性别.Trim() )
                ary.Add( String.Format( "[性别]: {0} => {1}", struOrg.性别, 性别 ) );

            if ( 户口类别.Trim() != struOrg.户口类别.Trim() )
                ary.Add( String.Format( "[户口类别]: {0} => {1}", struOrg.户口类别, 户口类别 ) );

            if ( 优抚证书编号.Trim() != struOrg.优抚证书编号.Trim() )
                ary.Add( String.Format( "[优抚证书编号]: {0} => {1}", struOrg.优抚证书编号, 优抚证书编号 ) );

            if ( 伤残等级.Trim() != struOrg.伤残等级.Trim() )
                ary.Add( String.Format( "[伤残等级]: {0} => {1}", struOrg.伤残等级, 伤残等级 ) );

            if ( 发放金额.Trim() != struOrg.发放金额.Trim() )
                ary.Add( String.Format( "[发放金额]: {0} => {1}", struOrg.发放金额, 发放金额 ) );


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}