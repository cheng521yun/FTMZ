


using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.老龄办
{
    public partial class 老龄津贴统计
    {
        string _ID = String.Empty;
        string _统计月份 = String.Empty;
        string _街道 = String.Empty;
        string _年龄段80 = String.Empty;
        string _年龄段90 = String.Empty;
        string _年龄段100 = String.Empty;
        string _本月新增 = String.Empty;
        string _本月终止 = String.Empty;
        string _本月继续 = String.Empty;
        string _备注 = String.Empty;

        public 老龄津贴统计()
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

        public string 年龄段80
        {
            set { _年龄段80 = value; }
            get { return _年龄段80; }
        }

        public string 年龄段90
        {
            set { _年龄段90 = value; }
            get { return _年龄段90; }
        }

        public string 年龄段100
        {
            set { _年龄段100 = value; }
            get { return _年龄段100; }
        }

        public string 本月新增
        {
            set { _本月新增 = value; }
            get { return _本月新增; }
        }

        public string 本月终止
        {
            set { _本月终止 = value; }
            get { return _本月终止; }
        }

        public string 本月继续
        {
            set { _本月继续 = value; }
            get { return _本月继续; }
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
            统计月份 = String.Empty;
            街道 = String.Empty;
            年龄段80 = String.Empty;
            年龄段90 = String.Empty;
            年龄段100 = String.Empty;
            本月新增 = String.Empty;
            本月终止 = String.Empty;
            本月继续 = String.Empty;
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

            ID = dr[ DB.Tab.老龄办.老龄津贴统计.ID ].ToString().Trim();
            统计月份 = dr[ DB.Tab.老龄办.老龄津贴统计.统计月份 ].ToString().Trim();
            街道 = dr[ DB.Tab.老龄办.老龄津贴统计.街道 ].ToString().Trim();
            年龄段80 = dr[ DB.Tab.老龄办.老龄津贴统计.年龄段80 ].ToString().Trim();
            年龄段90 = dr[ DB.Tab.老龄办.老龄津贴统计.年龄段90 ].ToString().Trim();
            年龄段100 = dr[ DB.Tab.老龄办.老龄津贴统计.年龄段100 ].ToString().Trim();
            本月新增 = dr[ DB.Tab.老龄办.老龄津贴统计.本月新增 ].ToString().Trim();
            本月终止 = dr[ DB.Tab.老龄办.老龄津贴统计.本月终止 ].ToString().Trim();
            本月继续 = dr[ DB.Tab.老龄办.老龄津贴统计.本月继续 ].ToString().Trim();
            备注 = dr[ DB.Tab.老龄办.老龄津贴统计.备注 ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.老龄办.老龄津贴统计> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.老龄办.老龄津贴统计> lst = new List<DB.Stru.老龄办.老龄津贴统计>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.老龄办.老龄津贴统计 stru = new DB.Stru.老龄办.老龄津贴统计();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.老龄办.老龄津贴统计> lst )
        {
            DB.Orm.老龄办.老龄津贴统计 orm = new DB.Orm.老龄办.老龄津贴统计();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.老龄办.老龄津贴统计 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.老龄办.老龄津贴统计 StruFromList_ByID( ref List<DB.Stru.老龄办.老龄津贴统计> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.老龄办.老龄津贴统计 stru in list )
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
                dr[ DB.Tab.老龄办.老龄津贴统计.ID ] = ID;

            CheckData();

            if ( 统计月份 != String.Empty )
                dr[ DB.Tab.老龄办.老龄津贴统计.统计月份 ] = 统计月份;
            dr[ DB.Tab.老龄办.老龄津贴统计.街道 ] = 街道;
            dr[ DB.Tab.老龄办.老龄津贴统计.年龄段80 ] = 年龄段80;
            dr[ DB.Tab.老龄办.老龄津贴统计.年龄段90 ] = 年龄段90;
            dr[ DB.Tab.老龄办.老龄津贴统计.年龄段100 ] = 年龄段100;
            dr[ DB.Tab.老龄办.老龄津贴统计.本月新增 ] = 本月新增;
            dr[ DB.Tab.老龄办.老龄津贴统计.本月终止 ] = 本月终止;
            dr[ DB.Tab.老龄办.老龄津贴统计.本月继续 ] = 本月继续;
            dr[ DB.Tab.老龄办.老龄津贴统计.备注 ] = 备注;
        }

        public void CopyFrom( DB.Stru.老龄办.老龄津贴统计 struFrom )
        {
            ID = struFrom.ID;
            统计月份 = struFrom.统计月份;
            街道 = struFrom.街道;
            年龄段80 = struFrom.年龄段80;
            年龄段90 = struFrom.年龄段90;
            年龄段100 = struFrom.年龄段100;
            本月新增 = struFrom.本月新增;
            本月终止 = struFrom.本月终止;
            本月继续 = struFrom.本月继续;
            备注 = struFrom.备注;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.老龄办.老龄津贴统计 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( 统计月份.Trim() != struOrg.统计月份.Trim() )
                ary.Add( String.Format( "[统计月份]: {0} => {1}", struOrg.统计月份, 统计月份 ) );

            if ( 街道.Trim() != struOrg.街道.Trim() )
                ary.Add( String.Format( "[街道]: {0} => {1}", struOrg.街道, 街道 ) );

            if ( 年龄段80.Trim() != struOrg.年龄段80.Trim() )
                ary.Add( String.Format( "[年龄段80]: {0} => {1}", struOrg.年龄段80, 年龄段80 ) );

            if ( 年龄段90.Trim() != struOrg.年龄段90.Trim() )
                ary.Add( String.Format( "[年龄段90]: {0} => {1}", struOrg.年龄段90, 年龄段90 ) );

            if ( 年龄段100.Trim() != struOrg.年龄段100.Trim() )
                ary.Add( String.Format( "[年龄段100]: {0} => {1}", struOrg.年龄段100, 年龄段100 ) );

            if ( 本月新增.Trim() != struOrg.本月新增.Trim() )
                ary.Add( String.Format( "[本月新增]: {0} => {1}", struOrg.本月新增, 本月新增 ) );

            if ( 本月终止.Trim() != struOrg.本月终止.Trim() )
                ary.Add( String.Format( "[本月终止]: {0} => {1}", struOrg.本月终止, 本月终止 ) );

            if ( 本月继续.Trim() != struOrg.本月继续.Trim() )
                ary.Add( String.Format( "[本月继续]: {0} => {1}", struOrg.本月继续, 本月继续 ) );

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