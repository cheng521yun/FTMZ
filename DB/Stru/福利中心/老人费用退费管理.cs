





using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.福利中心
{
    public class 老人费用退费管理
    {
		string _ID = String.Empty ; 
		string _CreateDate = String.Empty ; 
		string _Creator = String.Empty ; 
		string _姓名 = String.Empty ; 
		string _入住押金 = String.Empty ; 
		string _医疗保证金 = String.Empty ; 
		string _老人服务费 = String.Empty ; 
		string _伙食费 = String.Empty ; 
		string _药费 = String.Empty ; 
		string _电费 = String.Empty ; 
		string _银行账号 = String.Empty ; 
		string _备注 = String.Empty ; 
		string _时间 = String.Empty ; 
		
		public 老人费用退费管理()
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
		
		public string 入住押金
		{
			set { _入住押金 = value ; }
			get { return _入住押金  ; }
		}
		
		public string 医疗保证金
		{
			set { _医疗保证金 = value ; }
			get { return _医疗保证金  ; }
		}
		
		public string 老人服务费
		{
			set { _老人服务费 = value ; }
			get { return _老人服务费  ; }
		}
		
		public string 伙食费
		{
			set { _伙食费 = value ; }
			get { return _伙食费  ; }
		}
		
		public string 药费
		{
			set { _药费 = value ; }
			get { return _药费  ; }
		}
		
		public string 电费
		{
			set { _电费 = value ; }
			get { return _电费  ; }
		}
		
		public string 银行账号
		{
			set { _银行账号 = value ; }
			get { return _银行账号  ; }
		}
		
		public string 备注
		{
			set { _备注 = value ; }
			get { return _备注  ; }
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
			姓名 = String.Empty ; 
			入住押金 = String.Empty ; 
			医疗保证金 = String.Empty ; 
			老人服务费 = String.Empty ; 
			伙食费 = String.Empty ; 
			药费 = String.Empty ; 
			电费 = String.Empty ; 
			银行账号 = String.Empty ; 
			备注 = String.Empty ; 
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
		
			ID = dr[DB.Tab.福利中心.老人费用退费管理.ID].ToString().Trim();
			CreateDate = dr[DB.Tab.福利中心.老人费用退费管理.CreateDate].ToString().Trim();
			Creator = dr[DB.Tab.福利中心.老人费用退费管理.Creator].ToString().Trim();
			姓名 = dr[DB.Tab.福利中心.老人费用退费管理.姓名].ToString().Trim();
			入住押金 = dr[DB.Tab.福利中心.老人费用退费管理.入住押金].ToString().Trim();
			医疗保证金 = dr[DB.Tab.福利中心.老人费用退费管理.医疗保证金].ToString().Trim();
			老人服务费 = dr[DB.Tab.福利中心.老人费用退费管理.老人服务费].ToString().Trim();
			伙食费 = dr[DB.Tab.福利中心.老人费用退费管理.伙食费].ToString().Trim();
			药费 = dr[DB.Tab.福利中心.老人费用退费管理.药费].ToString().Trim();
			电费 = dr[DB.Tab.福利中心.老人费用退费管理.电费].ToString().Trim();
			银行账号 = dr[DB.Tab.福利中心.老人费用退费管理.银行账号].ToString().Trim();
			备注 = dr[DB.Tab.福利中心.老人费用退费管理.备注].ToString().Trim();
			时间 = dr[DB.Tab.福利中心.老人费用退费管理.时间].ToString().Trim();
		
			return true;
		}

		public static List<DB.Stru.福利中心.老人费用退费管理> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.福利中心.老人费用退费管理> lst = new List<DB.Stru.福利中心.老人费用退费管理>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.福利中心.老人费用退费管理 stru = new DB.Stru.福利中心.老人费用退费管理();
                stru.Dr2Stru ( dr );
                lst.Add ( stru );
            }

            return lst;
        }
		
		public static DataTable List2Dt ( ref List<DB.Stru.福利中心.老人费用退费管理> lst )
        {
            DB.Orm.福利中心.老人费用退费管理 orm = new DB.Orm.福利中心.老人费用退费管理 ();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.福利中心.老人费用退费管理 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }
		
        public static DB.Stru.福利中心.老人费用退费管理 StruFromList_ByID ( ref List<DB.Stru.福利中心.老人费用退费管理> list, string strID )
        {
		    if ( strID.Trim() == String.Empty )
                return null;
				
            foreach ( DB.Stru.福利中心.老人费用退费管理 stru in list )
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
                dr[DB.Tab.福利中心.老人费用退费管理.ID] = ID;
				
			CheckData();
			
			if ( CreateDate != String.Empty )
			dr[DB.Tab.福利中心.老人费用退费管理.CreateDate] = CreateDate;
			dr[DB.Tab.福利中心.老人费用退费管理.Creator] = Creator;
			dr[DB.Tab.福利中心.老人费用退费管理.姓名] = 姓名;
			dr[DB.Tab.福利中心.老人费用退费管理.入住押金] = 入住押金;
			dr[DB.Tab.福利中心.老人费用退费管理.医疗保证金] = 医疗保证金;
			dr[DB.Tab.福利中心.老人费用退费管理.老人服务费] = 老人服务费;
			dr[DB.Tab.福利中心.老人费用退费管理.伙食费] = 伙食费;
			dr[DB.Tab.福利中心.老人费用退费管理.药费] = 药费;
			dr[DB.Tab.福利中心.老人费用退费管理.电费] = 电费;
			dr[DB.Tab.福利中心.老人费用退费管理.银行账号] = 银行账号;
			dr[DB.Tab.福利中心.老人费用退费管理.备注] = 备注;
			if ( 时间 != String.Empty )
			dr[DB.Tab.福利中心.老人费用退费管理.时间] = 时间;
        }
		
		public void CopyFrom( DB.Stru.福利中心.老人费用退费管理 struFrom )
        {
			ID = struFrom.ID;
			CreateDate = struFrom.CreateDate;
			Creator = struFrom.Creator;
			姓名 = struFrom.姓名;
			入住押金 = struFrom.入住押金;
			医疗保证金 = struFrom.医疗保证金;
			老人服务费 = struFrom.老人服务费;
			伙食费 = struFrom.伙食费;
			药费 = struFrom.药费;
			电费 = struFrom.电费;
			银行账号 = struFrom.银行账号;
			备注 = struFrom.备注;
			时间 = struFrom.时间;
        }
		
		/// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
		public string GetLogStr ( DB.Stru.福利中心.老人费用退费管理 struOrg )
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

			if ( 入住押金.Trim() != struOrg.入住押金.Trim() )
				ary.Add ( String.Format ( "[入住押金]: {0} => {1}", struOrg.入住押金, 入住押金) ) ;

			if ( 医疗保证金.Trim() != struOrg.医疗保证金.Trim() )
				ary.Add ( String.Format ( "[医疗保证金]: {0} => {1}", struOrg.医疗保证金, 医疗保证金) ) ;

			if ( 老人服务费.Trim() != struOrg.老人服务费.Trim() )
				ary.Add ( String.Format ( "[老人服务费]: {0} => {1}", struOrg.老人服务费, 老人服务费) ) ;

			if ( 伙食费.Trim() != struOrg.伙食费.Trim() )
				ary.Add ( String.Format ( "[伙食费]: {0} => {1}", struOrg.伙食费, 伙食费) ) ;

			if ( 药费.Trim() != struOrg.药费.Trim() )
				ary.Add ( String.Format ( "[药费]: {0} => {1}", struOrg.药费, 药费) ) ;

			if ( 电费.Trim() != struOrg.电费.Trim() )
				ary.Add ( String.Format ( "[电费]: {0} => {1}", struOrg.电费, 电费) ) ;

			if ( 银行账号.Trim() != struOrg.银行账号.Trim() )
				ary.Add ( String.Format ( "[银行账号]: {0} => {1}", struOrg.银行账号, 银行账号) ) ;

			if ( 备注.Trim() != struOrg.备注.Trim() )
				ary.Add ( String.Format ( "[备注]: {0} => {1}", struOrg.备注, 备注) ) ;

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