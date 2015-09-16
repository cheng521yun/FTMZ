
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.优抚科.优抚对象.三属
{
    public class 类别信息
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _优抚对象ID = String.Empty;
        string _是否属于孤儿 = String.Empty;
        string _是否属于孤老 = String.Empty;
        string _是否残疾 = String.Empty;
        string _是否正在上学 = String.Empty;
        string _录入时间 = String.Empty;
        string _录入人 = String.Empty;
        string _负责人 = String.Empty;
        string _DelFlag = String.Empty;

        public 类别信息()
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

        public string 是否属于孤儿
        {
            set { _是否属于孤儿 = value; }
            get { return _是否属于孤儿; }
        }

        public string 是否属于孤老
        {
            set { _是否属于孤老 = value; }
            get { return _是否属于孤老; }
        }

        public string 是否残疾
        {
            set { _是否残疾 = value; }
            get { return _是否残疾; }
        }

        public string 是否正在上学
        {
            set { _是否正在上学 = value; }
            get { return _是否正在上学; }
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
            是否属于孤儿 = String.Empty;
            是否属于孤老 = String.Empty;
            是否残疾 = String.Empty;
            是否正在上学 = String.Empty;
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

            ID = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.ID ].ToString().Trim();
            CreateDate = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.CreateDate ].ToString().Trim();
            Creator = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.Creator ].ToString().Trim();
            优抚对象ID = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.优抚对象ID ].ToString().Trim();
            是否属于孤儿 = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.是否属于孤儿 ].ToString().Trim();
            是否属于孤老 = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.是否属于孤老 ].ToString().Trim();
            是否残疾 = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.是否残疾 ].ToString().Trim();
            是否正在上学 = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.是否正在上学 ].ToString().Trim();
            录入时间 = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.录入时间 ].ToString().Trim();
            录入人 = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.录入人 ].ToString().Trim();
            负责人 = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.负责人 ].ToString().Trim();
            DelFlag = dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.DelFlag ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.优抚科.优抚对象.三属.类别信息> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.优抚科.优抚对象.三属.类别信息> lst = new List<DB.Stru.优抚科.优抚对象.三属.类别信息>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.优抚科.优抚对象.三属.类别信息 stru = new DB.Stru.优抚科.优抚对象.三属.类别信息();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.优抚科.优抚对象.三属.类别信息> lst )
        {
            DB.Orm.优抚科.优抚对象.三属.类别信息 orm = new DB.Orm.优抚科.优抚对象.三属.类别信息();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.优抚科.优抚对象.三属.类别信息 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.优抚科.优抚对象.三属.类别信息 StruFromList_ByID( ref List<DB.Stru.优抚科.优抚对象.三属.类别信息> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.优抚科.优抚对象.三属.类别信息 stru in list )
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
                dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.ID ] = ID;

            CheckData();

            if ( CreateDate != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.CreateDate ] = CreateDate;
            dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.Creator ] = Creator;
            dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.优抚对象ID ] = 优抚对象ID;
            dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.是否属于孤儿 ] = 是否属于孤儿;
            dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.是否属于孤老 ] = 是否属于孤老;
            dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.是否残疾 ] = 是否残疾;
            dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.是否正在上学 ] = 是否正在上学;
            if ( 录入时间 != String.Empty )
                dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.录入时间 ] = 录入时间;
            dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.录入人 ] = 录入人;
            dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.负责人 ] = 负责人;
            dr[ DB.Tab.优抚科.优抚对象.三属.类别信息.DelFlag ] = DelFlag;
        }

        public void CopyFrom( DB.Stru.优抚科.优抚对象.三属.类别信息 struFrom )
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            优抚对象ID = struFrom.优抚对象ID;
            是否属于孤儿 = struFrom.是否属于孤儿;
            是否属于孤老 = struFrom.是否属于孤老;
            是否残疾 = struFrom.是否残疾;
            是否正在上学 = struFrom.是否正在上学;
            录入时间 = struFrom.录入时间;
            录入人 = struFrom.录入人;
            负责人 = struFrom.负责人;
            DelFlag = struFrom.DelFlag;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.优抚科.优抚对象.三属.类别信息 struOrg )
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

            if ( 是否属于孤儿.Trim() != struOrg.是否属于孤儿.Trim() )
                ary.Add( String.Format( "[是否属于孤儿]: {0} => {1}", struOrg.是否属于孤儿, 是否属于孤儿 ) );

            if ( 是否属于孤老.Trim() != struOrg.是否属于孤老.Trim() )
                ary.Add( String.Format( "[是否属于孤老]: {0} => {1}", struOrg.是否属于孤老, 是否属于孤老 ) );

            if ( 是否残疾.Trim() != struOrg.是否残疾.Trim() )
                ary.Add( String.Format( "[是否残疾]: {0} => {1}", struOrg.是否残疾, 是否残疾 ) );

            if ( 是否正在上学.Trim() != struOrg.是否正在上学.Trim() )
                ary.Add( String.Format( "[是否正在上学]: {0} => {1}", struOrg.是否正在上学, 是否正在上学 ) );

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