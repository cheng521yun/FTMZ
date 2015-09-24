





using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.基层科
{
    public class 社区建设信息管理
    {
		string _ID = String.Empty ; 
		string _CreateDate = String.Empty ; 
		string _Creator = String.Empty ; 
		string _所属街道1 = String.Empty ; 
		string _所属街道2 = String.Empty ; 
		string _社区 = String.Empty ; 
		string _办公房 = String.Empty ; 
		string _党员活动室 = String.Empty ; 
		string _社区警务室 = String.Empty ; 
		string _人民调解室 = String.Empty ; 
		string _社区健康服务中心 = String.Empty ; 
		string _社区图书馆 = String.Empty ; 
		string _星光老年之家 = String.Empty ; 
		string _户外文体广场 = String.Empty ; 
		
		public 社区建设信息管理()
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
		
		public string 社区
		{
			set { _社区 = value ; }
			get { return _社区  ; }
		}
		
		public string 办公房
		{
			set { _办公房 = value ; }
			get { return _办公房  ; }
		}
		
		public string 党员活动室
		{
			set { _党员活动室 = value ; }
			get { return _党员活动室  ; }
		}
		
		public string 社区警务室
		{
			set { _社区警务室 = value ; }
			get { return _社区警务室  ; }
		}
		
		public string 人民调解室
		{
			set { _人民调解室 = value ; }
			get { return _人民调解室  ; }
		}
		
		public string 社区健康服务中心
		{
			set { _社区健康服务中心 = value ; }
			get { return _社区健康服务中心  ; }
		}
		
		public string 社区图书馆
		{
			set { _社区图书馆 = value ; }
			get { return _社区图书馆  ; }
		}
		
		public string 星光老年之家
		{
			set { _星光老年之家 = value ; }
			get { return _星光老年之家  ; }
		}
		
		public string 户外文体广场
		{
			set { _户外文体广场 = value ; }
			get { return _户外文体广场  ; }
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
			所属街道1 = String.Empty ; 
			所属街道2 = String.Empty ; 
			社区 = String.Empty ; 
			办公房 = String.Empty ; 
			党员活动室 = String.Empty ; 
			社区警务室 = String.Empty ; 
			人民调解室 = String.Empty ; 
			社区健康服务中心 = String.Empty ; 
			社区图书馆 = String.Empty ; 
			星光老年之家 = String.Empty ; 
			户外文体广场 = String.Empty ; 
			
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
		
			ID = dr[DB.Tab.基层科.社区建设信息管理.ID].ToString().Trim();
			CreateDate = dr[DB.Tab.基层科.社区建设信息管理.CreateDate].ToString().Trim();
			Creator = dr[DB.Tab.基层科.社区建设信息管理.Creator].ToString().Trim();
			所属街道1 = dr[DB.Tab.基层科.社区建设信息管理.所属街道1].ToString().Trim();
			所属街道2 = dr[DB.Tab.基层科.社区建设信息管理.所属街道2].ToString().Trim();
			社区 = dr[DB.Tab.基层科.社区建设信息管理.社区].ToString().Trim();
			办公房 = dr[DB.Tab.基层科.社区建设信息管理.办公房].ToString().Trim();
			党员活动室 = dr[DB.Tab.基层科.社区建设信息管理.党员活动室].ToString().Trim();
			社区警务室 = dr[DB.Tab.基层科.社区建设信息管理.社区警务室].ToString().Trim();
			人民调解室 = dr[DB.Tab.基层科.社区建设信息管理.人民调解室].ToString().Trim();
			社区健康服务中心 = dr[DB.Tab.基层科.社区建设信息管理.社区健康服务中心].ToString().Trim();
			社区图书馆 = dr[DB.Tab.基层科.社区建设信息管理.社区图书馆].ToString().Trim();
			星光老年之家 = dr[DB.Tab.基层科.社区建设信息管理.星光老年之家].ToString().Trim();
			户外文体广场 = dr[DB.Tab.基层科.社区建设信息管理.户外文体广场].ToString().Trim();
		
			return true;
		}

		public static List<DB.Stru.基层科.社区建设信息管理> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.基层科.社区建设信息管理> lst = new List<DB.Stru.基层科.社区建设信息管理>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.基层科.社区建设信息管理 stru = new DB.Stru.基层科.社区建设信息管理();
                stru.Dr2Stru ( dr );
                lst.Add ( stru );
            }

            return lst;
        }
		
		public static DataTable List2Dt ( ref List<DB.Stru.基层科.社区建设信息管理> lst )
        {
            DB.Orm.基层科.社区建设信息管理 orm = new DB.Orm.基层科.社区建设信息管理 ();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.基层科.社区建设信息管理 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }
		
        public static DB.Stru.基层科.社区建设信息管理 StruFromList_ByID ( ref List<DB.Stru.基层科.社区建设信息管理> list, string strID )
        {
		    if ( strID.Trim() == String.Empty )
                return null;
				
            foreach ( DB.Stru.基层科.社区建设信息管理 stru in list )
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
                dr[DB.Tab.基层科.社区建设信息管理.ID] = ID;
				
			CheckData();
			
			if ( CreateDate != String.Empty )
			dr[DB.Tab.基层科.社区建设信息管理.CreateDate] = CreateDate;
			dr[DB.Tab.基层科.社区建设信息管理.Creator] = Creator;
			dr[DB.Tab.基层科.社区建设信息管理.所属街道1] = 所属街道1;
			dr[DB.Tab.基层科.社区建设信息管理.所属街道2] = 所属街道2;
			dr[DB.Tab.基层科.社区建设信息管理.社区] = 社区;
			dr[DB.Tab.基层科.社区建设信息管理.办公房] = 办公房;
			dr[DB.Tab.基层科.社区建设信息管理.党员活动室] = 党员活动室;
			dr[DB.Tab.基层科.社区建设信息管理.社区警务室] = 社区警务室;
			dr[DB.Tab.基层科.社区建设信息管理.人民调解室] = 人民调解室;
			dr[DB.Tab.基层科.社区建设信息管理.社区健康服务中心] = 社区健康服务中心;
			dr[DB.Tab.基层科.社区建设信息管理.社区图书馆] = 社区图书馆;
			dr[DB.Tab.基层科.社区建设信息管理.星光老年之家] = 星光老年之家;
			dr[DB.Tab.基层科.社区建设信息管理.户外文体广场] = 户外文体广场;
        }
		
		public void CopyFrom( DB.Stru.基层科.社区建设信息管理 struFrom )
        {
			ID = struFrom.ID;
			CreateDate = struFrom.CreateDate;
			Creator = struFrom.Creator;
			所属街道1 = struFrom.所属街道1;
			所属街道2 = struFrom.所属街道2;
			社区 = struFrom.社区;
			办公房 = struFrom.办公房;
			党员活动室 = struFrom.党员活动室;
			社区警务室 = struFrom.社区警务室;
			人民调解室 = struFrom.人民调解室;
			社区健康服务中心 = struFrom.社区健康服务中心;
			社区图书馆 = struFrom.社区图书馆;
			星光老年之家 = struFrom.星光老年之家;
			户外文体广场 = struFrom.户外文体广场;
        }
		
		/// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
		public string GetLogStr ( DB.Stru.基层科.社区建设信息管理 struOrg )
        {
			if ( struOrg.ID == String.Empty ) 
				return String.Empty; 
		
            string strRet = String.Empty;
            ArrayList ary = new ArrayList ();
			
			if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
				ary.Add ( String.Format ( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate) ) ;

			if ( Creator.Trim() != struOrg.Creator.Trim() )
				ary.Add ( String.Format ( "[Creator]: {0} => {1}", struOrg.Creator, Creator) ) ;

			if ( 所属街道1.Trim() != struOrg.所属街道1.Trim() )
				ary.Add ( String.Format ( "[所属街道1]: {0} => {1}", struOrg.所属街道1, 所属街道1) ) ;

			if ( 所属街道2.Trim() != struOrg.所属街道2.Trim() )
				ary.Add ( String.Format ( "[所属街道2]: {0} => {1}", struOrg.所属街道2, 所属街道2) ) ;

			if ( 社区.Trim() != struOrg.社区.Trim() )
				ary.Add ( String.Format ( "[社区]: {0} => {1}", struOrg.社区, 社区) ) ;

			if ( 办公房.Trim() != struOrg.办公房.Trim() )
				ary.Add ( String.Format ( "[办公房]: {0} => {1}", struOrg.办公房, 办公房) ) ;

			if ( 党员活动室.Trim() != struOrg.党员活动室.Trim() )
				ary.Add ( String.Format ( "[党员活动室]: {0} => {1}", struOrg.党员活动室, 党员活动室) ) ;

			if ( 社区警务室.Trim() != struOrg.社区警务室.Trim() )
				ary.Add ( String.Format ( "[社区警务室]: {0} => {1}", struOrg.社区警务室, 社区警务室) ) ;

			if ( 人民调解室.Trim() != struOrg.人民调解室.Trim() )
				ary.Add ( String.Format ( "[人民调解室]: {0} => {1}", struOrg.人民调解室, 人民调解室) ) ;

			if ( 社区健康服务中心.Trim() != struOrg.社区健康服务中心.Trim() )
				ary.Add ( String.Format ( "[社区健康服务中心]: {0} => {1}", struOrg.社区健康服务中心, 社区健康服务中心) ) ;

			if ( 社区图书馆.Trim() != struOrg.社区图书馆.Trim() )
				ary.Add ( String.Format ( "[社区图书馆]: {0} => {1}", struOrg.社区图书馆, 社区图书馆) ) ;

			if ( 星光老年之家.Trim() != struOrg.星光老年之家.Trim() )
				ary.Add ( String.Format ( "[星光老年之家]: {0} => {1}", struOrg.星光老年之家, 星光老年之家) ) ;

			if ( 户外文体广场.Trim() != struOrg.户外文体广场.Trim() )
				ary.Add ( String.Format ( "[户外文体广场]: {0} => {1}", struOrg.户外文体广场, 户外文体广场) ) ;


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
		
	}
}