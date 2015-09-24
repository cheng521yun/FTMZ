





using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.福利中心
{
    public class 老人入住管理_担保人
    {
		string _ID = String.Empty ; 
		string _父ID = String.Empty ; 
		string _CreateDate = String.Empty ; 
		string _Creator = String.Empty ; 
		string _姓名 = String.Empty ; 
		string _关系 = String.Empty ; 
		string _地址或工作单位 = String.Empty ; 
		string _联系电话 = String.Empty ; 
		
		public 老人入住管理_担保人()
		{
			Init();
		}
		
		#region Prop 
		
		public string ID
		{
			set { _ID = value ; }
			get { return _ID  ; }
		}
		
		public string 父ID
		{
			set { _父ID = value ; }
			get { return _父ID  ; }
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
		
		public string 关系
		{
			set { _关系 = value ; }
			get { return _关系  ; }
		}
		
		public string 地址或工作单位
		{
			set { _地址或工作单位 = value ; }
			get { return _地址或工作单位  ; }
		}
		
		public string 联系电话
		{
			set { _联系电话 = value ; }
			get { return _联系电话  ; }
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
			父ID = String.Empty ; 
			CreateDate = String.Empty ; 
			Creator = String.Empty ; 
			姓名 = String.Empty ; 
			关系 = String.Empty ; 
			地址或工作单位 = String.Empty ; 
			联系电话 = String.Empty ; 
			
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
		
			ID = dr[DB.Tab.福利中心.老人入住管理_担保人.ID].ToString().Trim();
			父ID = dr[DB.Tab.福利中心.老人入住管理_担保人.父ID].ToString().Trim();
			CreateDate = dr[DB.Tab.福利中心.老人入住管理_担保人.CreateDate].ToString().Trim();
			Creator = dr[DB.Tab.福利中心.老人入住管理_担保人.Creator].ToString().Trim();
			姓名 = dr[DB.Tab.福利中心.老人入住管理_担保人.姓名].ToString().Trim();
			关系 = dr[DB.Tab.福利中心.老人入住管理_担保人.关系].ToString().Trim();
			地址或工作单位 = dr[DB.Tab.福利中心.老人入住管理_担保人.地址或工作单位].ToString().Trim();
			联系电话 = dr[DB.Tab.福利中心.老人入住管理_担保人.联系电话].ToString().Trim();
		
			return true;
		}

		public static List<DB.Stru.福利中心.老人入住管理_担保人> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.福利中心.老人入住管理_担保人> lst = new List<DB.Stru.福利中心.老人入住管理_担保人>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.福利中心.老人入住管理_担保人 stru = new DB.Stru.福利中心.老人入住管理_担保人();
                stru.Dr2Stru ( dr );
                lst.Add ( stru );
            }

            return lst;
        }
		
		public static DataTable List2Dt ( ref List<DB.Stru.福利中心.老人入住管理_担保人> lst )
        {
            DB.Orm.福利中心.老人入住管理_担保人 orm = new DB.Orm.福利中心.老人入住管理_担保人 ();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.福利中心.老人入住管理_担保人 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }
		
        public static DB.Stru.福利中心.老人入住管理_担保人 StruFromList_ByID ( ref List<DB.Stru.福利中心.老人入住管理_担保人> list, string strID )
        {
		    if ( strID.Trim() == String.Empty )
                return null;
				
            foreach ( DB.Stru.福利中心.老人入住管理_担保人 stru in list )
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
                dr[DB.Tab.福利中心.老人入住管理_担保人.ID] = ID;
				
			CheckData();
			
			dr[DB.Tab.福利中心.老人入住管理_担保人.父ID] = 父ID;
			if ( CreateDate != String.Empty )
			dr[DB.Tab.福利中心.老人入住管理_担保人.CreateDate] = CreateDate;
			dr[DB.Tab.福利中心.老人入住管理_担保人.Creator] = Creator;
			dr[DB.Tab.福利中心.老人入住管理_担保人.姓名] = 姓名;
			dr[DB.Tab.福利中心.老人入住管理_担保人.关系] = 关系;
			dr[DB.Tab.福利中心.老人入住管理_担保人.地址或工作单位] = 地址或工作单位;
			dr[DB.Tab.福利中心.老人入住管理_担保人.联系电话] = 联系电话;
        }
		
		public void CopyFrom( DB.Stru.福利中心.老人入住管理_担保人 struFrom )
        {
			ID = struFrom.ID;
			父ID = struFrom.父ID;
			CreateDate = struFrom.CreateDate;
			Creator = struFrom.Creator;
			姓名 = struFrom.姓名;
			关系 = struFrom.关系;
			地址或工作单位 = struFrom.地址或工作单位;
			联系电话 = struFrom.联系电话;
        }
		
		/// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
		public string GetLogStr ( DB.Stru.福利中心.老人入住管理_担保人 struOrg )
        {
			if ( struOrg.ID == String.Empty ) 
				return String.Empty; 
		
            string strRet = String.Empty;
            ArrayList ary = new ArrayList ();
			
			if ( 父ID.Trim() != struOrg.父ID.Trim() )
				ary.Add ( String.Format ( "[父ID]: {0} => {1}", struOrg.父ID, 父ID) ) ;

			if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
				ary.Add ( String.Format ( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate) ) ;

			if ( Creator.Trim() != struOrg.Creator.Trim() )
				ary.Add ( String.Format ( "[Creator]: {0} => {1}", struOrg.Creator, Creator) ) ;

			if ( 姓名.Trim() != struOrg.姓名.Trim() )
				ary.Add ( String.Format ( "[姓名]: {0} => {1}", struOrg.姓名, 姓名) ) ;

			if ( 关系.Trim() != struOrg.关系.Trim() )
				ary.Add ( String.Format ( "[关系]: {0} => {1}", struOrg.关系, 关系) ) ;

			if ( 地址或工作单位.Trim() != struOrg.地址或工作单位.Trim() )
				ary.Add ( String.Format ( "[地址或工作单位]: {0} => {1}", struOrg.地址或工作单位, 地址或工作单位) ) ;

			if ( 联系电话.Trim() != struOrg.联系电话.Trim() )
				ary.Add ( String.Format ( "[联系电话]: {0} => {1}", struOrg.联系电话, 联系电话) ) ;


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
		
	}
}