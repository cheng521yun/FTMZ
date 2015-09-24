





using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.福利中心
{
    public class 老人费用登记管理
    {
		string _ID = String.Empty ; 
		string _CreateDate = String.Empty ; 
		string _Creator = String.Empty ; 
		string _用户代码 = String.Empty ; 
		string _老人名称 = String.Empty ; 
		string _银行账号 = String.Empty ; 
		string _养老服务费 = String.Empty ; 
		string _老人伙食费 = String.Empty ; 
		string _老人药费 = String.Empty ; 
		string _老人电费 = String.Empty ; 
		string _应收金额 = String.Empty ; 
		string _时间 = String.Empty ; 
		
		public 老人费用登记管理()
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
		
		public string 用户代码
		{
			set { _用户代码 = value ; }
			get { return _用户代码  ; }
		}
		
		public string 老人名称
		{
			set { _老人名称 = value ; }
			get { return _老人名称  ; }
		}
		
		public string 银行账号
		{
			set { _银行账号 = value ; }
			get { return _银行账号  ; }
		}
		
		public string 养老服务费
		{
			set { _养老服务费 = value ; }
			get { return _养老服务费  ; }
		}
		
		public string 老人伙食费
		{
			set { _老人伙食费 = value ; }
			get { return _老人伙食费  ; }
		}
		
		public string 老人药费
		{
			set { _老人药费 = value ; }
			get { return _老人药费  ; }
		}
		
		public string 老人电费
		{
			set { _老人电费 = value ; }
			get { return _老人电费  ; }
		}
		
		public string 应收金额
		{
			set { _应收金额 = value ; }
			get { return _应收金额  ; }
		}
		
		public string 时间
		{
			set { _时间 = value ; }
			get { return _时间  ; }
		}
		public DateTime dat时间
        {
            set { _时间 = value.ToString("yyyy-MM-dd HH:mm:ss") ; }
            get { return FF.Fun.MyConvert.Str2Date( _时间 ); }
        }
		public string 时间Str
		{
			get { return FF.Fun.MyConvert.Str2Date(_时间).ToString("yyyy-MM-dd"); }
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
			用户代码 = String.Empty ; 
			老人名称 = String.Empty ; 
			银行账号 = String.Empty ; 
			养老服务费 = String.Empty ; 
			老人伙食费 = String.Empty ; 
			老人药费 = String.Empty ; 
			老人电费 = String.Empty ; 
			应收金额 = String.Empty ; 
			时间 = String.Empty ; 
			
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
		
			ID = dr[DB.Tab.福利中心.老人费用登记管理.ID].ToString().Trim();
			CreateDate = dr[DB.Tab.福利中心.老人费用登记管理.CreateDate].ToString().Trim();
			Creator = dr[DB.Tab.福利中心.老人费用登记管理.Creator].ToString().Trim();
			用户代码 = dr[DB.Tab.福利中心.老人费用登记管理.用户代码].ToString().Trim();
			老人名称 = dr[DB.Tab.福利中心.老人费用登记管理.老人名称].ToString().Trim();
			银行账号 = dr[DB.Tab.福利中心.老人费用登记管理.银行账号].ToString().Trim();
			养老服务费 = dr[DB.Tab.福利中心.老人费用登记管理.养老服务费].ToString().Trim();
			老人伙食费 = dr[DB.Tab.福利中心.老人费用登记管理.老人伙食费].ToString().Trim();
			老人药费 = dr[DB.Tab.福利中心.老人费用登记管理.老人药费].ToString().Trim();
			老人电费 = dr[DB.Tab.福利中心.老人费用登记管理.老人电费].ToString().Trim();
			应收金额 = dr[DB.Tab.福利中心.老人费用登记管理.应收金额].ToString().Trim();
			时间 = dr[DB.Tab.福利中心.老人费用登记管理.时间].ToString().Trim();
		
			return true;
		}

		public static List<DB.Stru.福利中心.老人费用登记管理> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.福利中心.老人费用登记管理> lst = new List<DB.Stru.福利中心.老人费用登记管理>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.福利中心.老人费用登记管理 stru = new DB.Stru.福利中心.老人费用登记管理();
                stru.Dr2Stru ( dr );
                lst.Add ( stru );
            }

            return lst;
        }
		
		public static DataTable List2Dt ( ref List<DB.Stru.福利中心.老人费用登记管理> lst )
        {
            DB.Orm.福利中心.老人费用登记管理 orm = new DB.Orm.福利中心.老人费用登记管理 ();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.福利中心.老人费用登记管理 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }
		
        public static DB.Stru.福利中心.老人费用登记管理 StruFromList_ByID ( ref List<DB.Stru.福利中心.老人费用登记管理> list, string strID )
        {
		    if ( strID.Trim() == String.Empty )
                return null;
				
            foreach ( DB.Stru.福利中心.老人费用登记管理 stru in list )
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
                dr[DB.Tab.福利中心.老人费用登记管理.ID] = ID;
				
			CheckData();
			
			if ( CreateDate != String.Empty )
			dr[DB.Tab.福利中心.老人费用登记管理.CreateDate] = CreateDate;
			dr[DB.Tab.福利中心.老人费用登记管理.Creator] = Creator;
			dr[DB.Tab.福利中心.老人费用登记管理.用户代码] = 用户代码;
			dr[DB.Tab.福利中心.老人费用登记管理.老人名称] = 老人名称;
			dr[DB.Tab.福利中心.老人费用登记管理.银行账号] = 银行账号;
			dr[DB.Tab.福利中心.老人费用登记管理.养老服务费] = 养老服务费;
			dr[DB.Tab.福利中心.老人费用登记管理.老人伙食费] = 老人伙食费;
			dr[DB.Tab.福利中心.老人费用登记管理.老人药费] = 老人药费;
			dr[DB.Tab.福利中心.老人费用登记管理.老人电费] = 老人电费;
			dr[DB.Tab.福利中心.老人费用登记管理.应收金额] = 应收金额;
			if ( 时间 != String.Empty )
			dr[DB.Tab.福利中心.老人费用登记管理.时间] = 时间;
        }
		
		public void CopyFrom( DB.Stru.福利中心.老人费用登记管理 struFrom )
        {
			ID = struFrom.ID;
			CreateDate = struFrom.CreateDate;
			Creator = struFrom.Creator;
			用户代码 = struFrom.用户代码;
			老人名称 = struFrom.老人名称;
			银行账号 = struFrom.银行账号;
			养老服务费 = struFrom.养老服务费;
			老人伙食费 = struFrom.老人伙食费;
			老人药费 = struFrom.老人药费;
			老人电费 = struFrom.老人电费;
			应收金额 = struFrom.应收金额;
			时间 = struFrom.时间;
        }
		
		/// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
		public string GetLogStr ( DB.Stru.福利中心.老人费用登记管理 struOrg )
        {
			if ( struOrg.ID == String.Empty ) 
				return String.Empty; 
		
            string strRet = String.Empty;
            ArrayList ary = new ArrayList ();
			
			if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
				ary.Add ( String.Format ( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate) ) ;

			if ( Creator.Trim() != struOrg.Creator.Trim() )
				ary.Add ( String.Format ( "[Creator]: {0} => {1}", struOrg.Creator, Creator) ) ;

			if ( 用户代码.Trim() != struOrg.用户代码.Trim() )
				ary.Add ( String.Format ( "[用户代码]: {0} => {1}", struOrg.用户代码, 用户代码) ) ;

			if ( 老人名称.Trim() != struOrg.老人名称.Trim() )
				ary.Add ( String.Format ( "[老人名称]: {0} => {1}", struOrg.老人名称, 老人名称) ) ;

			if ( 银行账号.Trim() != struOrg.银行账号.Trim() )
				ary.Add ( String.Format ( "[银行账号]: {0} => {1}", struOrg.银行账号, 银行账号) ) ;

			if ( 养老服务费.Trim() != struOrg.养老服务费.Trim() )
				ary.Add ( String.Format ( "[养老服务费]: {0} => {1}", struOrg.养老服务费, 养老服务费) ) ;

			if ( 老人伙食费.Trim() != struOrg.老人伙食费.Trim() )
				ary.Add ( String.Format ( "[老人伙食费]: {0} => {1}", struOrg.老人伙食费, 老人伙食费) ) ;

			if ( 老人药费.Trim() != struOrg.老人药费.Trim() )
				ary.Add ( String.Format ( "[老人药费]: {0} => {1}", struOrg.老人药费, 老人药费) ) ;

			if ( 老人电费.Trim() != struOrg.老人电费.Trim() )
				ary.Add ( String.Format ( "[老人电费]: {0} => {1}", struOrg.老人电费, 老人电费) ) ;

			if ( 应收金额.Trim() != struOrg.应收金额.Trim() )
				ary.Add ( String.Format ( "[应收金额]: {0} => {1}", struOrg.应收金额, 应收金额) ) ;

			if ( 时间.Trim() != struOrg.时间.Trim() )
				ary.Add ( String.Format ( "[时间]: {0} => {1}", struOrg.时间, 时间) ) ;


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
		
	}
}