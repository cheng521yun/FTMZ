
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.优抚科
{
    public class 伤残物品登记
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _物品分类 = String.Empty;
        string _子分类 = String.Empty;
        string _物品名称 = String.Empty;
        string _物品数量 = String.Empty;
        string _使用期限 = String.Empty;
        string _物品描述 = String.Empty;
        string _DelFlag = String.Empty;

        public 伤残物品登记()
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

        public string 物品分类
        {
            set { _物品分类 = value; }
            get { return _物品分类; }
        }

        public string 子分类
        {
            set { _子分类 = value; }
            get { return _子分类; }
        }

        public string 物品名称
        {
            set { _物品名称 = value; }
            get { return _物品名称; }
        }

        public string 物品数量
        {
            set { _物品数量 = value; }
            get { return _物品数量; }
        }

        public string 使用期限
        {
            set { _使用期限 = value; }
            get { return _使用期限; }
        }

        public string 物品描述
        {
            set { _物品描述 = value; }
            get { return _物品描述; }
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
            物品分类 = String.Empty;
            子分类 = String.Empty;
            物品名称 = String.Empty;
            物品数量 = String.Empty;
            使用期限 = String.Empty;
            物品描述 = String.Empty;
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

            ID = dr[ DB.Tab.优抚科.伤残物品登记.ID ].ToString().Trim();
            CreateDate = dr[ DB.Tab.优抚科.伤残物品登记.CreateDate ].ToString().Trim();
            Creator = dr[ DB.Tab.优抚科.伤残物品登记.Creator ].ToString().Trim();
            物品分类 = dr[ DB.Tab.优抚科.伤残物品登记.物品分类 ].ToString().Trim();
            子分类 = dr[ DB.Tab.优抚科.伤残物品登记.子分类 ].ToString().Trim();
            物品名称 = dr[ DB.Tab.优抚科.伤残物品登记.物品名称 ].ToString().Trim();
            物品数量 = dr[ DB.Tab.优抚科.伤残物品登记.物品数量 ].ToString().Trim();
            使用期限 = dr[ DB.Tab.优抚科.伤残物品登记.使用期限 ].ToString().Trim();
            物品描述 = dr[ DB.Tab.优抚科.伤残物品登记.物品描述 ].ToString().Trim();
            DelFlag = dr[ DB.Tab.优抚科.伤残物品登记.DelFlag ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.优抚科.伤残物品登记> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.优抚科.伤残物品登记> lst = new List<DB.Stru.优抚科.伤残物品登记>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.优抚科.伤残物品登记 stru = new DB.Stru.优抚科.伤残物品登记();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.优抚科.伤残物品登记> lst )
        {
            DB.Orm.优抚科.伤残物品登记 orm = new DB.Orm.优抚科.伤残物品登记();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.优抚科.伤残物品登记 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.优抚科.伤残物品登记 StruFromList_ByID( ref List<DB.Stru.优抚科.伤残物品登记> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.优抚科.伤残物品登记 stru in list )
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
                dr[ DB.Tab.优抚科.伤残物品登记.ID ] = ID;

            CheckData();

            if ( CreateDate != String.Empty )
                dr[ DB.Tab.优抚科.伤残物品登记.CreateDate ] = CreateDate;
            dr[ DB.Tab.优抚科.伤残物品登记.Creator ] = Creator;
            dr[ DB.Tab.优抚科.伤残物品登记.物品分类 ] = 物品分类;
            dr[ DB.Tab.优抚科.伤残物品登记.子分类 ] = 子分类;
            dr[ DB.Tab.优抚科.伤残物品登记.物品名称 ] = 物品名称;
            dr[ DB.Tab.优抚科.伤残物品登记.物品数量 ] = 物品数量;
            dr[ DB.Tab.优抚科.伤残物品登记.使用期限 ] = 使用期限;
            dr[ DB.Tab.优抚科.伤残物品登记.物品描述 ] = 物品描述;
            dr[ DB.Tab.优抚科.伤残物品登记.DelFlag ] = DelFlag;
        }

        public void CopyFrom( DB.Stru.优抚科.伤残物品登记 struFrom )
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            物品分类 = struFrom.物品分类;
            子分类 = struFrom.子分类;
            物品名称 = struFrom.物品名称;
            物品数量 = struFrom.物品数量;
            使用期限 = struFrom.使用期限;
            物品描述 = struFrom.物品描述;
            DelFlag = struFrom.DelFlag;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.优抚科.伤残物品登记 struOrg )
        {
            if ( struOrg.ID == String.Empty )
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
                ary.Add( String.Format( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate ) );

            if ( Creator.Trim() != struOrg.Creator.Trim() )
                ary.Add( String.Format( "[Creator]: {0} => {1}", struOrg.Creator, Creator ) );

            if ( 物品分类.Trim() != struOrg.物品分类.Trim() )
                ary.Add( String.Format( "[物品分类]: {0} => {1}", struOrg.物品分类, 物品分类 ) );

            if ( 子分类.Trim() != struOrg.子分类.Trim() )
                ary.Add( String.Format( "[子分类]: {0} => {1}", struOrg.子分类, 子分类 ) );

            if ( 物品名称.Trim() != struOrg.物品名称.Trim() )
                ary.Add( String.Format( "[物品名称]: {0} => {1}", struOrg.物品名称, 物品名称 ) );

            if ( 物品数量.Trim() != struOrg.物品数量.Trim() )
                ary.Add( String.Format( "[物品数量]: {0} => {1}", struOrg.物品数量, 物品数量 ) );

            if ( 使用期限.Trim() != struOrg.使用期限.Trim() )
                ary.Add( String.Format( "[使用期限]: {0} => {1}", struOrg.使用期限, 使用期限 ) );

            if ( 物品描述.Trim() != struOrg.物品描述.Trim() )
                ary.Add( String.Format( "[物品描述]: {0} => {1}", struOrg.物品描述, 物品描述 ) );

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