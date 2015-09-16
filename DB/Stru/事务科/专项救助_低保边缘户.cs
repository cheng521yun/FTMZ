


using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.事务科
{
    public class 专项救助_低保边缘户
    {
        string _ID = String.Empty;
        string _所属街道 = String.Empty;
        string _姓名 = String.Empty;
        string _身份证 = String.Empty;
        string _性别 = String.Empty;
        string _联系电话 = String.Empty;
        string _家庭成员 = String.Empty;
        string _边缘证号 = String.Empty;
        string _有效期 = String.Empty;
        string _备注 = String.Empty;

        public 专项救助_低保边缘户()
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

        public string 身份证
        {
            set { _身份证 = value; }
            get { return _身份证; }
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

        public string 家庭成员
        {
            set { _家庭成员 = value; }
            get { return _家庭成员; }
        }

        public string 边缘证号
        {
            set { _边缘证号 = value; }
            get { return _边缘证号; }
        }

        public string 有效期
        {
            set { _有效期 = value; }
            get { return _有效期; }
        }
        public DateTime dat有效期
        {
            set { _有效期 = value.ToString( "yyyy-MM-dd HH:mm:ss" ); }
            get { return FF.Fun.MyConvert.Str2Date( _有效期 ); }
        }
        public string 有效期Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _有效期 ).ToString( "yyyy-MM-dd" ); }
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
            身份证 = String.Empty;
            性别 = String.Empty;
            联系电话 = String.Empty;
            家庭成员 = String.Empty;
            边缘证号 = String.Empty;
            有效期 = String.Empty;
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

            ID = dr[ DB.Tab.事务科.专项救助_低保边缘户.ID ].ToString().Trim();
            所属街道 = dr[ DB.Tab.事务科.专项救助_低保边缘户.所属街道 ].ToString().Trim();
            姓名 = dr[ DB.Tab.事务科.专项救助_低保边缘户.姓名 ].ToString().Trim();
            身份证 = dr[ DB.Tab.事务科.专项救助_低保边缘户.身份证 ].ToString().Trim();
            性别 = dr[ DB.Tab.事务科.专项救助_低保边缘户.性别 ].ToString().Trim();
            联系电话 = dr[ DB.Tab.事务科.专项救助_低保边缘户.联系电话 ].ToString().Trim();
            家庭成员 = dr[ DB.Tab.事务科.专项救助_低保边缘户.家庭成员 ].ToString().Trim();
            边缘证号 = dr[ DB.Tab.事务科.专项救助_低保边缘户.边缘证号 ].ToString().Trim();
            有效期 = dr[ DB.Tab.事务科.专项救助_低保边缘户.有效期 ].ToString().Trim();
            备注 = dr[ DB.Tab.事务科.专项救助_低保边缘户.备注 ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.事务科.专项救助_低保边缘户> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.事务科.专项救助_低保边缘户> lst = new List<DB.Stru.事务科.专项救助_低保边缘户>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.事务科.专项救助_低保边缘户 stru = new DB.Stru.事务科.专项救助_低保边缘户();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.事务科.专项救助_低保边缘户> lst )
        {
            DB.Orm.事务科.专项救助_低保边缘户 orm = new DB.Orm.事务科.专项救助_低保边缘户();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.事务科.专项救助_低保边缘户 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.事务科.专项救助_低保边缘户 StruFromList_ByID( ref List<DB.Stru.事务科.专项救助_低保边缘户> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.事务科.专项救助_低保边缘户 stru in list )
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
                dr[ DB.Tab.事务科.专项救助_低保边缘户.ID ] = ID;

            CheckData();

            dr[ DB.Tab.事务科.专项救助_低保边缘户.所属街道 ] = 所属街道;
            dr[ DB.Tab.事务科.专项救助_低保边缘户.姓名 ] = 姓名;
            dr[ DB.Tab.事务科.专项救助_低保边缘户.身份证 ] = 身份证;
            dr[ DB.Tab.事务科.专项救助_低保边缘户.性别 ] = 性别;
            dr[ DB.Tab.事务科.专项救助_低保边缘户.联系电话 ] = 联系电话;
            dr[ DB.Tab.事务科.专项救助_低保边缘户.家庭成员 ] = 家庭成员;
            dr[ DB.Tab.事务科.专项救助_低保边缘户.边缘证号 ] = 边缘证号;
            if ( 有效期 != String.Empty )
                dr[ DB.Tab.事务科.专项救助_低保边缘户.有效期 ] = 有效期;
            dr[ DB.Tab.事务科.专项救助_低保边缘户.备注 ] = 备注;
        }

        public void CopyFrom( DB.Stru.事务科.专项救助_低保边缘户 struFrom )
        {
            ID = struFrom.ID;
            所属街道 = struFrom.所属街道;
            姓名 = struFrom.姓名;
            身份证 = struFrom.身份证;
            性别 = struFrom.性别;
            联系电话 = struFrom.联系电话;
            家庭成员 = struFrom.家庭成员;
            边缘证号 = struFrom.边缘证号;
            有效期 = struFrom.有效期;
            备注 = struFrom.备注;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.事务科.专项救助_低保边缘户 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( 所属街道.Trim() != struOrg.所属街道.Trim() )
                ary.Add( String.Format( "[所属街道]: {0} => {1}", struOrg.所属街道, 所属街道 ) );

            if ( 姓名.Trim() != struOrg.姓名.Trim() )
                ary.Add( String.Format( "[姓名]: {0} => {1}", struOrg.姓名, 姓名 ) );

            if ( 身份证.Trim() != struOrg.身份证.Trim() )
                ary.Add( String.Format( "[身份证]: {0} => {1}", struOrg.身份证, 身份证 ) );

            if ( 性别.Trim() != struOrg.性别.Trim() )
                ary.Add( String.Format( "[性别]: {0} => {1}", struOrg.性别, 性别 ) );

            if ( 联系电话.Trim() != struOrg.联系电话.Trim() )
                ary.Add( String.Format( "[联系电话]: {0} => {1}", struOrg.联系电话, 联系电话 ) );

            if ( 家庭成员.Trim() != struOrg.家庭成员.Trim() )
                ary.Add( String.Format( "[家庭成员]: {0} => {1}", struOrg.家庭成员, 家庭成员 ) );

            if ( 边缘证号.Trim() != struOrg.边缘证号.Trim() )
                ary.Add( String.Format( "[边缘证号]: {0} => {1}", struOrg.边缘证号, 边缘证号 ) );

            if ( 有效期.Trim() != struOrg.有效期.Trim() )
                ary.Add( String.Format( "[有效期]: {0} => {1}", struOrg.有效期, 有效期 ) );

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