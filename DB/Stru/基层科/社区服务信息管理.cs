





using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.基层科
{
    public class 社区服务信息管理
    {
		string _ID = String.Empty ; 
		string _CreateDate = String.Empty ; 
		string _Creator = String.Empty ; 
		string _所属街道1 = String.Empty ; 
		string _所属街道2 = String.Empty ; 
		string _社区服务中心 = String.Empty ; 
		string _管理人员 = String.Empty ; 
		string _专业社工 = String.Empty ; 
		string _辅助人员 = String.Empty ; 
		string _个案 = String.Empty ; 
		string _结案 = String.Empty ; 
		string _建档 = String.Empty ; 
		string _小组活动 = String.Empty ; 
		string _社区活动 = String.Empty ; 
		string _家访 = String.Empty ; 
		string _即时辅导 = String.Empty ; 
		string _咨询 = String.Empty ; 
		string _服务机构 = String.Empty ; 
		
		public 社区服务信息管理()
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
		
		public string 社区服务中心
		{
			set { _社区服务中心 = value ; }
			get { return _社区服务中心  ; }
		}
		
		public string 管理人员
		{
			set { _管理人员 = value ; }
			get { return _管理人员  ; }
		}
		
		public string 专业社工
		{
			set { _专业社工 = value ; }
			get { return _专业社工  ; }
		}
		
		public string 辅助人员
		{
			set { _辅助人员 = value ; }
			get { return _辅助人员  ; }
		}
		
		public string 个案
		{
			set { _个案 = value ; }
			get { return _个案  ; }
		}
		
		public string 结案
		{
			set { _结案 = value ; }
			get { return _结案  ; }
		}
		
		public string 建档
		{
			set { _建档 = value ; }
			get { return _建档  ; }
		}
		
		public string 小组活动
		{
			set { _小组活动 = value ; }
			get { return _小组活动  ; }
		}
		
		public string 社区活动
		{
			set { _社区活动 = value ; }
			get { return _社区活动  ; }
		}
		
		public string 家访
		{
			set { _家访 = value ; }
			get { return _家访  ; }
		}
		
		public string 即时辅导
		{
			set { _即时辅导 = value ; }
			get { return _即时辅导  ; }
		}
		
		public string 咨询
		{
			set { _咨询 = value ; }
			get { return _咨询  ; }
		}
		
		public string 服务机构
		{
			set { _服务机构 = value ; }
			get { return _服务机构  ; }
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
			社区服务中心 = String.Empty ; 
			管理人员 = String.Empty ; 
			专业社工 = String.Empty ; 
			辅助人员 = String.Empty ; 
			个案 = String.Empty ; 
			结案 = String.Empty ; 
			建档 = String.Empty ; 
			小组活动 = String.Empty ; 
			社区活动 = String.Empty ; 
			家访 = String.Empty ; 
			即时辅导 = String.Empty ; 
			咨询 = String.Empty ; 
			服务机构 = String.Empty ; 
			
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
		
			ID = dr[DB.Tab.基层科.社区服务信息管理.ID].ToString().Trim();
			CreateDate = dr[DB.Tab.基层科.社区服务信息管理.CreateDate].ToString().Trim();
			Creator = dr[DB.Tab.基层科.社区服务信息管理.Creator].ToString().Trim();
			所属街道1 = dr[DB.Tab.基层科.社区服务信息管理.所属街道1].ToString().Trim();
			所属街道2 = dr[DB.Tab.基层科.社区服务信息管理.所属街道2].ToString().Trim();
			社区服务中心 = dr[DB.Tab.基层科.社区服务信息管理.社区服务中心].ToString().Trim();
			管理人员 = dr[DB.Tab.基层科.社区服务信息管理.管理人员].ToString().Trim();
			专业社工 = dr[DB.Tab.基层科.社区服务信息管理.专业社工].ToString().Trim();
			辅助人员 = dr[DB.Tab.基层科.社区服务信息管理.辅助人员].ToString().Trim();
			个案 = dr[DB.Tab.基层科.社区服务信息管理.个案].ToString().Trim();
			结案 = dr[DB.Tab.基层科.社区服务信息管理.结案].ToString().Trim();
			建档 = dr[DB.Tab.基层科.社区服务信息管理.建档].ToString().Trim();
			小组活动 = dr[DB.Tab.基层科.社区服务信息管理.小组活动].ToString().Trim();
			社区活动 = dr[DB.Tab.基层科.社区服务信息管理.社区活动].ToString().Trim();
			家访 = dr[DB.Tab.基层科.社区服务信息管理.家访].ToString().Trim();
			即时辅导 = dr[DB.Tab.基层科.社区服务信息管理.即时辅导].ToString().Trim();
			咨询 = dr[DB.Tab.基层科.社区服务信息管理.咨询].ToString().Trim();
			服务机构 = dr[DB.Tab.基层科.社区服务信息管理.服务机构].ToString().Trim();
		
			return true;
		}

		public static List<DB.Stru.基层科.社区服务信息管理> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.基层科.社区服务信息管理> lst = new List<DB.Stru.基层科.社区服务信息管理>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.基层科.社区服务信息管理 stru = new DB.Stru.基层科.社区服务信息管理();
                stru.Dr2Stru ( dr );
                lst.Add ( stru );
            }

            return lst;
        }
		
		public static DataTable List2Dt ( ref List<DB.Stru.基层科.社区服务信息管理> lst )
        {
            DB.Orm.基层科.社区服务信息管理 orm = new DB.Orm.基层科.社区服务信息管理 ();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.基层科.社区服务信息管理 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }
		
        public static DB.Stru.基层科.社区服务信息管理 StruFromList_ByID ( ref List<DB.Stru.基层科.社区服务信息管理> list, string strID )
        {
		    if ( strID.Trim() == String.Empty )
                return null;
				
            foreach ( DB.Stru.基层科.社区服务信息管理 stru in list )
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
                dr[DB.Tab.基层科.社区服务信息管理.ID] = ID;
				
			CheckData();
			
			if ( CreateDate != String.Empty )
			dr[DB.Tab.基层科.社区服务信息管理.CreateDate] = CreateDate;
			dr[DB.Tab.基层科.社区服务信息管理.Creator] = Creator;
			dr[DB.Tab.基层科.社区服务信息管理.所属街道1] = 所属街道1;
			dr[DB.Tab.基层科.社区服务信息管理.所属街道2] = 所属街道2;
			dr[DB.Tab.基层科.社区服务信息管理.社区服务中心] = 社区服务中心;
			dr[DB.Tab.基层科.社区服务信息管理.管理人员] = 管理人员;
			dr[DB.Tab.基层科.社区服务信息管理.专业社工] = 专业社工;
			dr[DB.Tab.基层科.社区服务信息管理.辅助人员] = 辅助人员;
			dr[DB.Tab.基层科.社区服务信息管理.个案] = 个案;
			dr[DB.Tab.基层科.社区服务信息管理.结案] = 结案;
			dr[DB.Tab.基层科.社区服务信息管理.建档] = 建档;
			dr[DB.Tab.基层科.社区服务信息管理.小组活动] = 小组活动;
			dr[DB.Tab.基层科.社区服务信息管理.社区活动] = 社区活动;
			dr[DB.Tab.基层科.社区服务信息管理.家访] = 家访;
			dr[DB.Tab.基层科.社区服务信息管理.即时辅导] = 即时辅导;
			dr[DB.Tab.基层科.社区服务信息管理.咨询] = 咨询;
			dr[DB.Tab.基层科.社区服务信息管理.服务机构] = 服务机构;
        }
		
		public void CopyFrom( DB.Stru.基层科.社区服务信息管理 struFrom )
        {
			ID = struFrom.ID;
			CreateDate = struFrom.CreateDate;
			Creator = struFrom.Creator;
			所属街道1 = struFrom.所属街道1;
			所属街道2 = struFrom.所属街道2;
			社区服务中心 = struFrom.社区服务中心;
			管理人员 = struFrom.管理人员;
			专业社工 = struFrom.专业社工;
			辅助人员 = struFrom.辅助人员;
			个案 = struFrom.个案;
			结案 = struFrom.结案;
			建档 = struFrom.建档;
			小组活动 = struFrom.小组活动;
			社区活动 = struFrom.社区活动;
			家访 = struFrom.家访;
			即时辅导 = struFrom.即时辅导;
			咨询 = struFrom.咨询;
			服务机构 = struFrom.服务机构;
        }
		
		/// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
		public string GetLogStr ( DB.Stru.基层科.社区服务信息管理 struOrg )
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

			if ( 社区服务中心.Trim() != struOrg.社区服务中心.Trim() )
				ary.Add ( String.Format ( "[社区服务中心]: {0} => {1}", struOrg.社区服务中心, 社区服务中心) ) ;

			if ( 管理人员.Trim() != struOrg.管理人员.Trim() )
				ary.Add ( String.Format ( "[管理人员]: {0} => {1}", struOrg.管理人员, 管理人员) ) ;

			if ( 专业社工.Trim() != struOrg.专业社工.Trim() )
				ary.Add ( String.Format ( "[专业社工]: {0} => {1}", struOrg.专业社工, 专业社工) ) ;

			if ( 辅助人员.Trim() != struOrg.辅助人员.Trim() )
				ary.Add ( String.Format ( "[辅助人员]: {0} => {1}", struOrg.辅助人员, 辅助人员) ) ;

			if ( 个案.Trim() != struOrg.个案.Trim() )
				ary.Add ( String.Format ( "[个案]: {0} => {1}", struOrg.个案, 个案) ) ;

			if ( 结案.Trim() != struOrg.结案.Trim() )
				ary.Add ( String.Format ( "[结案]: {0} => {1}", struOrg.结案, 结案) ) ;

			if ( 建档.Trim() != struOrg.建档.Trim() )
				ary.Add ( String.Format ( "[建档]: {0} => {1}", struOrg.建档, 建档) ) ;

			if ( 小组活动.Trim() != struOrg.小组活动.Trim() )
				ary.Add ( String.Format ( "[小组活动]: {0} => {1}", struOrg.小组活动, 小组活动) ) ;

			if ( 社区活动.Trim() != struOrg.社区活动.Trim() )
				ary.Add ( String.Format ( "[社区活动]: {0} => {1}", struOrg.社区活动, 社区活动) ) ;

			if ( 家访.Trim() != struOrg.家访.Trim() )
				ary.Add ( String.Format ( "[家访]: {0} => {1}", struOrg.家访, 家访) ) ;

			if ( 即时辅导.Trim() != struOrg.即时辅导.Trim() )
				ary.Add ( String.Format ( "[即时辅导]: {0} => {1}", struOrg.即时辅导, 即时辅导) ) ;

			if ( 咨询.Trim() != struOrg.咨询.Trim() )
				ary.Add ( String.Format ( "[咨询]: {0} => {1}", struOrg.咨询, 咨询) ) ;

			if ( 服务机构.Trim() != struOrg.服务机构.Trim() )
				ary.Add ( String.Format ( "[服务机构]: {0} => {1}", struOrg.服务机构, 服务机构) ) ;


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
		
	}
}