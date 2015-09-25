





using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.基层科
{
    public class 社区服务信息管理_社区公益服务
    {
		string _ID = String.Empty ; 
		string _父ID = String.Empty ; 
		string _CreateDate = String.Empty ; 
		string _Creator = String.Empty ; 
		string _所属街道1 = String.Empty ; 
		string _所属街道2 = String.Empty ; 
		string _已开展服务项目 = String.Empty ; 
		string _已开展服务社区 = String.Empty ; 
		string _未开展服务社区 = String.Empty ; 
		string _参与服务人员 = String.Empty ; 
		string _已发生费用 = String.Empty ; 
		
		public 社区服务信息管理_社区公益服务()
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
		
		public string 所属街道1
		{
			set { _所属街道1 = value ; }
			get { return _所属街道1  ; }
		}
		
		public string 所属街道2
		{
			set { _所属街道2 = value ; }
			get { return _所属街道2  ; }
		}
		
		public string 已开展服务项目
		{
			set { _已开展服务项目 = value ; }
			get { return _已开展服务项目  ; }
		}
		
		public string 已开展服务社区
		{
			set { _已开展服务社区 = value ; }
			get { return _已开展服务社区  ; }
		}
		
		public string 未开展服务社区
		{
			set { _未开展服务社区 = value ; }
			get { return _未开展服务社区  ; }
		}
		
		public string 参与服务人员
		{
			set { _参与服务人员 = value ; }
			get { return _参与服务人员  ; }
		}
		
		public string 已发生费用
		{
			set { _已发生费用 = value ; }
			get { return _已发生费用  ; }
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
			所属街道1 = String.Empty ; 
			所属街道2 = String.Empty ; 
			已开展服务项目 = String.Empty ; 
			已开展服务社区 = String.Empty ; 
			未开展服务社区 = String.Empty ; 
			参与服务人员 = String.Empty ; 
			已发生费用 = String.Empty ; 
			
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
		
			ID = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.ID].ToString().Trim();
			父ID = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.父ID].ToString().Trim();
			CreateDate = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.CreateDate].ToString().Trim();
			Creator = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.Creator].ToString().Trim();
			所属街道1 = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.所属街道1].ToString().Trim();
			所属街道2 = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.所属街道2].ToString().Trim();
			已开展服务项目 = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.已开展服务项目].ToString().Trim();
			已开展服务社区 = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.已开展服务社区].ToString().Trim();
			未开展服务社区 = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.未开展服务社区].ToString().Trim();
			参与服务人员 = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.参与服务人员].ToString().Trim();
			已发生费用 = dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.已发生费用].ToString().Trim();
		
			return true;
		}

		public static List<DB.Stru.基层科.社区服务信息管理_社区公益服务> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.基层科.社区服务信息管理_社区公益服务> lst = new List<DB.Stru.基层科.社区服务信息管理_社区公益服务>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.基层科.社区服务信息管理_社区公益服务 stru = new DB.Stru.基层科.社区服务信息管理_社区公益服务();
                stru.Dr2Stru ( dr );
                lst.Add ( stru );
            }

            return lst;
        }
		
		public static DataTable List2Dt ( ref List<DB.Stru.基层科.社区服务信息管理_社区公益服务> lst )
        {
            DB.Orm.基层科.社区服务信息管理_社区公益服务 orm = new DB.Orm.基层科.社区服务信息管理_社区公益服务 ();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.基层科.社区服务信息管理_社区公益服务 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }
		
        public static DB.Stru.基层科.社区服务信息管理_社区公益服务 StruFromList_ByID ( ref List<DB.Stru.基层科.社区服务信息管理_社区公益服务> list, string strID )
        {
		    if ( strID.Trim() == String.Empty )
                return null;
				
            foreach ( DB.Stru.基层科.社区服务信息管理_社区公益服务 stru in list )
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
                dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.ID] = ID;
				
			CheckData();

            dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.父ID] = string.IsNullOrEmpty(父ID) ? "0" : 父ID;
			if ( CreateDate != String.Empty )
			dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.CreateDate] = CreateDate;
			dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.Creator] = Creator;
			dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.所属街道1] = 所属街道1;
			dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.所属街道2] = 所属街道2;
			dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.已开展服务项目] = 已开展服务项目;
			dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.已开展服务社区] = 已开展服务社区;
			dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.未开展服务社区] = 未开展服务社区;
			dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.参与服务人员] = 参与服务人员;
			dr[DB.Tab.基层科.社区服务信息管理_社区公益服务.已发生费用] = 已发生费用;
        }
		
		public void CopyFrom( DB.Stru.基层科.社区服务信息管理_社区公益服务 struFrom )
        {
			ID = struFrom.ID;
			父ID = struFrom.父ID;
			CreateDate = struFrom.CreateDate;
			Creator = struFrom.Creator;
			所属街道1 = struFrom.所属街道1;
			所属街道2 = struFrom.所属街道2;
			已开展服务项目 = struFrom.已开展服务项目;
			已开展服务社区 = struFrom.已开展服务社区;
			未开展服务社区 = struFrom.未开展服务社区;
			参与服务人员 = struFrom.参与服务人员;
			已发生费用 = struFrom.已发生费用;
        }
		
		/// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
		public string GetLogStr ( DB.Stru.基层科.社区服务信息管理_社区公益服务 struOrg )
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

			if ( 所属街道1.Trim() != struOrg.所属街道1.Trim() )
				ary.Add ( String.Format ( "[所属街道1]: {0} => {1}", struOrg.所属街道1, 所属街道1) ) ;

			if ( 所属街道2.Trim() != struOrg.所属街道2.Trim() )
				ary.Add ( String.Format ( "[所属街道2]: {0} => {1}", struOrg.所属街道2, 所属街道2) ) ;

			if ( 已开展服务项目.Trim() != struOrg.已开展服务项目.Trim() )
				ary.Add ( String.Format ( "[已开展服务项目]: {0} => {1}", struOrg.已开展服务项目, 已开展服务项目) ) ;

			if ( 已开展服务社区.Trim() != struOrg.已开展服务社区.Trim() )
				ary.Add ( String.Format ( "[已开展服务社区]: {0} => {1}", struOrg.已开展服务社区, 已开展服务社区) ) ;

			if ( 未开展服务社区.Trim() != struOrg.未开展服务社区.Trim() )
				ary.Add ( String.Format ( "[未开展服务社区]: {0} => {1}", struOrg.未开展服务社区, 未开展服务社区) ) ;

			if ( 参与服务人员.Trim() != struOrg.参与服务人员.Trim() )
				ary.Add ( String.Format ( "[参与服务人员]: {0} => {1}", struOrg.参与服务人员, 参与服务人员) ) ;

			if ( 已发生费用.Trim() != struOrg.已发生费用.Trim() )
				ary.Add ( String.Format ( "[已发生费用]: {0} => {1}", struOrg.已发生费用, 已发生费用) ) ;


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
		
	}
}