
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.优抚科
{
    public class 抚恤标准
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _优抚对象 = String.Empty;
        string _类别1 = String.Empty;
        string _类别2 = String.Empty;
        string _标准 = String.Empty;

        public 抚恤标准()
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

        public string 优抚对象
        {
            set { _优抚对象 = value; }
            get { return _优抚对象; }
        }

        public string 类别1
        {
            set { _类别1 = value; }
            get { return _类别1; }
        }

        public string 类别2
        {
            set { _类别2 = value; }
            get { return _类别2; }
        }

        public string 标准
        {
            set { _标准 = value; }
            get { return _标准; }
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
            类别1 = String.Empty;
            类别2 = String.Empty;
            标准 = String.Empty;

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

            ID = dr[ DB.Tab.优抚科.抚恤标准.ID ].ToString().Trim();
            CreateDate = dr[ DB.Tab.优抚科.抚恤标准.CreateDate ].ToString().Trim();
            Creator = dr[ DB.Tab.优抚科.抚恤标准.Creator ].ToString().Trim();
            优抚对象 = dr[ DB.Tab.优抚科.抚恤标准.优抚对象 ].ToString().Trim();
            类别1 = dr[ DB.Tab.优抚科.抚恤标准.类别1 ].ToString().Trim();
            类别2 = dr[ DB.Tab.优抚科.抚恤标准.类别2 ].ToString().Trim();
            标准 = dr[ DB.Tab.优抚科.抚恤标准.标准 ].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.优抚科.抚恤标准> Dt2List( ref DataTable dt )
        {
            List<DB.Stru.优抚科.抚恤标准> lst = new List<DB.Stru.优抚科.抚恤标准>();

            if ( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach ( DataRow dr in dt.Rows )
            {
                DB.Stru.优抚科.抚恤标准 stru = new DB.Stru.优抚科.抚恤标准();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public static DataTable List2Dt( ref List<DB.Stru.优抚科.抚恤标准> lst )
        {
            DB.Orm.优抚科.抚恤标准 orm = new DB.Orm.优抚科.抚恤标准();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.优抚科.抚恤标准 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr( ref dr );
            }

            return dt;
        }

        public static DB.Stru.优抚科.抚恤标准 StruFromList_ByID( ref List<DB.Stru.优抚科.抚恤标准> list, string strID )
        {
            if ( strID.Trim() == String.Empty )
                return null;

            foreach ( DB.Stru.优抚科.抚恤标准 stru in list )
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
                dr[ DB.Tab.优抚科.抚恤标准.ID ] = ID;

            CheckData();

            dr[ DB.Tab.优抚科.抚恤标准.CreateDate ] = CreateDate;
            dr[ DB.Tab.优抚科.抚恤标准.Creator ] = Creator;
            dr[ DB.Tab.优抚科.抚恤标准.优抚对象 ] = 优抚对象;
            dr[ DB.Tab.优抚科.抚恤标准.类别1 ] = 类别1;
            dr[ DB.Tab.优抚科.抚恤标准.类别2 ] = 类别2;
            dr[ DB.Tab.优抚科.抚恤标准.标准 ] = 标准;
        }

        public void CopyFrom( DB.Stru.优抚科.抚恤标准 struFrom )
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            优抚对象 = struFrom.优抚对象;
            类别1 = struFrom.类别1;
            类别2 = struFrom.类别2;
            标准 = struFrom.标准;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr( DB.Stru.优抚科.抚恤标准 struOrg )
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

            if ( 类别1.Trim() != struOrg.类别1.Trim() )
                ary.Add( String.Format( "[类别1]: {0} => {1}", struOrg.类别1, 类别1 ) );

            if ( 类别2.Trim() != struOrg.类别2.Trim() )
                ary.Add( String.Format( "[类别2]: {0} => {1}", struOrg.类别2, 类别2 ) );

            if ( 标准.Trim() != struOrg.标准.Trim() )
                ary.Add( String.Format( "[标准]: {0} => {1}", struOrg.标准, 标准 ) );


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}