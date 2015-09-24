





using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.福利中心
{
    public class 老人退住管理
    {
		string _ID = String.Empty ; 
		string _CreateDate = String.Empty ; 
		string _Creator = String.Empty ; 
		string _姓名 = String.Empty ; 
		string _性别 = String.Empty ; 
		string _身份证 = String.Empty ; 
		string _入住时间 = String.Empty ; 
		string _申请时间 = String.Empty ; 
		string _入住级别 = String.Empty ; 
		string _退住级别 = String.Empty ; 
		
		public 老人退住管理()
		{
			Init();
		}
		
		#region Prop 
		
		public string ID
		{
			set { _ID = value ; }
			get { return _ID  ; }
		}
		
		public string CreateDate
		{
			set { _CreateDate = value ; }
			get { return _CreateDate  ; }
		}
		public DateTime datCreateDate
        {
            set { _CreateDate = value.ToString("yyyy-MM-dd HH:mm:ss") ; }
            get { return FF.Fun.MyConvert.Str2Date( _CreateDate ); }
        }
		public string CreateDateStr
		{
			get { return FF.Fun.MyConvert.Str2Date(_CreateDate).ToString("yyyy-MM-dd"); }
		}
		
		public string Creator
		{
			set { _Creator = value ; }
			get { return _Creator  ; }
		}
		
		public string 姓名
		{
			set { _姓名 = value ; }
			get { return _姓名  ; }
		}
		
		public string 性别
		{
			set { _性别 = value ; }
			get { return _性别  ; }
		}
		
		public string 身份证
		{
			set { _身份证 = value ; }
			get { return _身份证  ; }
		}
		
		public string 入住时间
		{
			set { _入住时间 = value ; }
			get { return _入住时间  ; }
		}
		
		public string 申请时间
		{
			set { _申请时间 = value ; }
			get { return _申请时间  ; }
		}
		
		public string 入住级别
		{
			set { _入住级别 = value ; }
			get { return _入住级别  ; }
		}
		
		public string 退住级别
		{
			set { _退住级别 = value ; }
			get { return _退住级别  ; }
		}
		
	
		#endregion
		
		//Will Manual Input Code
		//Default Value, 
		void Init ()
		{
		}
				
		void Clear()
		{
			ID = String.Empty ; 
			CreateDate = String.Empty ; 
			Creator = String.Empty ; 
			姓名 = String.Empty ; 
			性别 = String.Empty ; 
			身份证 = String.Empty ; 
			入住时间 = String.Empty ; 
			申请时间 = String.Empty ; 
			入住级别 = String.Empty ; 
			退住级别 = String.Empty ; 
			
			Init ();
		}

        public bool IsValid()
        {
            return ( ID.Trim() == String.Empty ) ? false : true;
        }
		
        public bool IsNotValid()
        {
            return ! IsValid() ;
        }
		
		public bool Dr2Stru(DataRow dr)
		{
			Clear();
		
			if (dr == null)
				return false;
		
			ID = dr[DB.Tab.福利中心.老人退住管理.ID].ToString().Trim();
			CreateDate = dr[DB.Tab.福利中心.老人退住管理.CreateDate].ToString().Trim();
			Creator = dr[DB.Tab.福利中心.老人退住管理.Creator].ToString().Trim();
			姓名 = dr[DB.Tab.福利中心.老人退住管理.姓名].ToString().Trim();
			性别 = dr[DB.Tab.福利中心.老人退住管理.性别].ToString().Trim();
			身份证 = dr[DB.Tab.福利中心.老人退住管理.身份证].ToString().Trim();
			入住时间 = dr[DB.Tab.福利中心.老人退住管理.入住时间].ToString().Trim();
			申请时间 = dr[DB.Tab.福利中心.老人退住管理.申请时间].ToString().Trim();
			入住级别 = dr[DB.Tab.福利中心.老人退住管理.入住级别].ToString().Trim();
			退住级别 = dr[DB.Tab.福利中心.老人退住管理.退住级别].ToString().Trim();
		
			return true;
		}

		public static List<DB.Stru.福利中心.老人退住管理> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.福利中心.老人退住管理> lst = new List<DB.Stru.福利中心.老人退住管理>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.福利中心.老人退住管理 stru = new DB.Stru.福利中心.老人退住管理();
                stru.Dr2Stru ( dr );
                lst.Add ( stru );
            }

            return lst;
        }
		
		public static DataTable List2Dt ( ref List<DB.Stru.福利中心.老人退住管理> lst )
        {
            DB.Orm.福利中心.老人退住管理 orm = new DB.Orm.福利中心.老人退住管理 ();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.福利中心.老人退住管理 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }
		
        public static DB.Stru.福利中心.老人退住管理 StruFromList_ByID ( ref List<DB.Stru.福利中心.老人退住管理> list, string strID )
        {
		    if ( strID.Trim() == String.Empty )
                return null;
				
            foreach ( DB.Stru.福利中心.老人退住管理 stru in list )
            {
                if( stru.ID == strID )
                    return stru;
            }
            return null;
        }

		//Will Manual Input Code
		//Check Special Field Data can save into DataBase
        private void CheckData()
        {
			if ( CreateDate == String.Empty )
                CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");	
				
        }
		
		public void Stru2Dr( ref DataRow dr)
        {
            if ( ID.Trim() != String.Empty )
                dr[DB.Tab.福利中心.老人退住管理.ID] = ID;
				
			CheckData();
			
			if ( CreateDate != String.Empty )
			dr[DB.Tab.福利中心.老人退住管理.CreateDate] = CreateDate;
			dr[DB.Tab.福利中心.老人退住管理.Creator] = Creator;
			dr[DB.Tab.福利中心.老人退住管理.姓名] = 姓名;
			dr[DB.Tab.福利中心.老人退住管理.性别] = 性别;
			dr[DB.Tab.福利中心.老人退住管理.身份证] = 身份证;
			dr[DB.Tab.福利中心.老人退住管理.入住时间] = 入住时间;
			dr[DB.Tab.福利中心.老人退住管理.申请时间] = 申请时间;
			dr[DB.Tab.福利中心.老人退住管理.入住级别] = 入住级别;
			dr[DB.Tab.福利中心.老人退住管理.退住级别] = 退住级别;
        }
		
		public void CopyFrom( DB.Stru.福利中心.老人退住管理 struFrom )
        {
			ID = struFrom.ID;
			CreateDate = struFrom.CreateDate;
			Creator = struFrom.Creator;
			姓名 = struFrom.姓名;
			性别 = struFrom.性别;
			身份证 = struFrom.身份证;
			入住时间 = struFrom.入住时间;
			申请时间 = struFrom.申请时间;
			入住级别 = struFrom.入住级别;
			退住级别 = struFrom.退住级别;
        }
		
		/// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
		public string GetLogStr ( DB.Stru.福利中心.老人退住管理 struOrg )
        {
			if ( struOrg.ID == String.Empty ) 
				return String.Empty; 
		
            string strRet = String.Empty;
            ArrayList ary = new ArrayList ();
			
			if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
				ary.Add ( String.Format ( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate) ) ;

			if ( Creator.Trim() != struOrg.Creator.Trim() )
				ary.Add ( String.Format ( "[Creator]: {0} => {1}", struOrg.Creator, Creator) ) ;

			if ( 姓名.Trim() != struOrg.姓名.Trim() )
				ary.Add ( String.Format ( "[姓名]: {0} => {1}", struOrg.姓名, 姓名) ) ;

			if ( 性别.Trim() != struOrg.性别.Trim() )
				ary.Add ( String.Format ( "[性别]: {0} => {1}", struOrg.性别, 性别) ) ;

			if ( 身份证.Trim() != struOrg.身份证.Trim() )
				ary.Add ( String.Format ( "[身份证]: {0} => {1}", struOrg.身份证, 身份证) ) ;

			if ( 入住时间.Trim() != struOrg.入住时间.Trim() )
				ary.Add ( String.Format ( "[入住时间]: {0} => {1}", struOrg.入住时间, 入住时间) ) ;

			if ( 申请时间.Trim() != struOrg.申请时间.Trim() )
				ary.Add ( String.Format ( "[申请时间]: {0} => {1}", struOrg.申请时间, 申请时间) ) ;

			if ( 入住级别.Trim() != struOrg.入住级别.Trim() )
				ary.Add ( String.Format ( "[入住级别]: {0} => {1}", struOrg.入住级别, 入住级别) ) ;

			if ( 退住级别.Trim() != struOrg.退住级别.Trim() )
				ary.Add ( String.Format ( "[退住级别]: {0} => {1}", struOrg.退住级别, 退住级别) ) ;


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
		
	}
}