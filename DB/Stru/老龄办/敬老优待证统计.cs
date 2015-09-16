


using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.老龄办
{
    public partial class 敬老优待证统计
    {
        string _ID = String.Empty;
        string _统计月份 = String.Empty;
        string _街道 = String.Empty;
        string _蓝证 = String.Empty;
        string _黄证 = String.Empty;
        string _免费乘车证 = String.Empty;
        string _合计 = String.Empty;

        public 敬老优待证统计()
        {
            Init();
        }

        #region Prop

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string 统计月份
        {
            set { _统计月份 = value; }
            get { return _统计月份; }
        }
        public string 统计月份Str
        {
            get { return FF.Fun.MyConvert.Str2Date( _统计月份 ).ToString( "yyyy-MM-dd" ); }
        }

        public string 街道
        {
            set { _街道 = value; }
            get { return _街道; }
        }

        public string 蓝证
        {
            set { _蓝证 = value; }
            get { return _蓝证; }
        }

        public string 黄证
        {
            set { _黄证 = value; }
            get { return _黄证; }
        }

        public string 免费乘车证
        {
            set { _免费乘车证 = value; }
            get { return _免费乘车证; }
        }

        public string 合计
        {
            set { _合计 = value; }
            get { return _合计; }
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
            统计月份 = String.Empty;
            街道 = String.Empty;
            蓝证 = String.Empty;
            黄证 = String.Empty;
            免费乘车证 = String.Empty;
            合计 = String.Empty;

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

            ID = dr[ DB.Tab.老龄办.敬老优待证统计.ID ].ToString().Trim();
            统计月份 = dr[ DB.Tab.老龄办.敬老优待证统计.统计月份 ].ToString().Trim();
            街道 = dr[ DB.Tab.老龄办.敬老优待证统计.街道 ].ToString().Trim();
            蓝证 = dr[ DB.Tab.老龄办.敬老优待证统计.蓝证 ].ToString().Trim();
            黄证 = dr[ DB.Tab.老龄办.敬老优待证统计.黄证 ].ToString().Trim();
            免费乘车证 = dr[ DB.Tab.老龄办.敬老优待证统计.免费乘车证 ].ToString().Trim();
            合计 = dr[ DB.Tab.老龄办.敬老优待证统计.合计 ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.老龄办.敬老优待证统计> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.老龄办.敬老优待证统计> lst = new List<DB.Stru.老龄办.敬老优待证统计>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.老龄办.敬老优待证统计 stru = new DB.Stru.老龄办.敬老优待证统计();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.老龄办.敬老优待证统计> lst )
        {
            DB.Orm.老龄办.敬老优待证统计 orm = new DB.Orm.老龄办.敬老优待证统计();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.老龄办.敬老优待证统计 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.老龄办.敬老优待证统计 StruFromList_ByID( ref List<DB.Stru.老龄办.敬老优待证统计> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.老龄办.敬老优待证统计 stru in list )
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

        }

        public void Stru2Dr( ref DataRow dr )
        {
            if ( ID.Trim() != String.Empty )
                dr[ DB.Tab.老龄办.敬老优待证统计.ID ] = ID;

            CheckData();

            if ( 统计月份 != String.Empty )
                dr[ DB.Tab.老龄办.敬老优待证统计.统计月份 ] = 统计月份;
            dr[ DB.Tab.老龄办.敬老优待证统计.街道 ] = 街道;
            dr[ DB.Tab.老龄办.敬老优待证统计.蓝证 ] = 蓝证;
            dr[ DB.Tab.老龄办.敬老优待证统计.黄证 ] = 黄证;
            dr[ DB.Tab.老龄办.敬老优待证统计.免费乘车证 ] = 免费乘车证;
            dr[ DB.Tab.老龄办.敬老优待证统计.合计 ] = 合计;
        }

        public void CopyFrom( DB.Stru.老龄办.敬老优待证统计 struFrom )
        {
            ID = struFrom.ID;
            统计月份 = struFrom.统计月份;
            街道 = struFrom.街道;
            蓝证 = struFrom.蓝证;
            黄证 = struFrom.黄证;
            免费乘车证 = struFrom.免费乘车证;
            合计 = struFrom.合计;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.老龄办.敬老优待证统计 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( 统计月份.Trim() != struOrg.统计月份.Trim() )
                ary.Add( String.Format( "[统计月份]: {0} => {1}", struOrg.统计月份, 统计月份 ) );

            if ( 街道.Trim() != struOrg.街道.Trim() )
                ary.Add( String.Format( "[街道]: {0} => {1}", struOrg.街道, 街道 ) );

            if ( 蓝证.Trim() != struOrg.蓝证.Trim() )
                ary.Add( String.Format( "[蓝证]: {0} => {1}", struOrg.蓝证, 蓝证 ) );

            if ( 黄证.Trim() != struOrg.黄证.Trim() )
                ary.Add( String.Format( "[黄证]: {0} => {1}", struOrg.黄证, 黄证 ) );

            if ( 免费乘车证.Trim() != struOrg.免费乘车证.Trim() )
                ary.Add( String.Format( "[免费乘车证]: {0} => {1}", struOrg.免费乘车证, 免费乘车证 ) );

            if ( 合计.Trim() != struOrg.合计.Trim() )
                ary.Add( String.Format( "[合计]: {0} => {1}", struOrg.合计, 合计 ) );


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}