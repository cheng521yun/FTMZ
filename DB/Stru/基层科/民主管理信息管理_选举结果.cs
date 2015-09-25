





using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.基层科
{
    public class 民主管理信息管理_选举结果
    {
		string _ID = String.Empty ; 
		string _父ID = String.Empty ; 
		string _CreateDate = String.Empty ; 
		string _Creator = String.Empty ; 
		string _街道办事处 = String.Empty ; 
		string _本级社区委员会数 = String.Empty ; 
		string _需要换届选举的社区委员会数 = String.Empty ; 
		string _社区综合当组织班子总职数 = String.Empty ; 
		string _社区委员会班子总职数 = String.Empty ; 
		string _总数 = String.Empty ; 
		
		public 民主管理信息管理_选举结果()
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
		
		public string 街道办事处
		{
			set { _街道办事处 = value ; }
			get { return _街道办事处  ; }
		}
		
		public string 本级社区委员会数
		{
			set { _本级社区委员会数 = value ; }
			get { return _本级社区委员会数  ; }
		}
		
		public string 需要换届选举的社区委员会数
		{
			set { _需要换届选举的社区委员会数 = value ; }
			get { return _需要换届选举的社区委员会数  ; }
		}
		
		public string 社区综合当组织班子总职数
		{
			set { _社区综合当组织班子总职数 = value ; }
			get { return _社区综合当组织班子总职数  ; }
		}
		
		public string 社区委员会班子总职数
		{
			set { _社区委员会班子总职数 = value ; }
			get { return _社区委员会班子总职数  ; }
		}
		
		public string 总数
		{
			set { _总数 = value ; }
			get { return _总数  ; }
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
			街道办事处 = String.Empty ; 
			本级社区委员会数 = String.Empty ; 
			需要换届选举的社区委员会数 = String.Empty ; 
			社区综合当组织班子总职数 = String.Empty ; 
			社区委员会班子总职数 = String.Empty ; 
			总数 = String.Empty ; 
			
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
		
			ID = dr[DB.Tab.基层科.民主管理信息管理_选举结果.ID].ToString().Trim();
			父ID = dr[DB.Tab.基层科.民主管理信息管理_选举结果.父ID].ToString().Trim();
			CreateDate = dr[DB.Tab.基层科.民主管理信息管理_选举结果.CreateDate].ToString().Trim();
			Creator = dr[DB.Tab.基层科.民主管理信息管理_选举结果.Creator].ToString().Trim();
			街道办事处 = dr[DB.Tab.基层科.民主管理信息管理_选举结果.街道办事处].ToString().Trim();
			本级社区委员会数 = dr[DB.Tab.基层科.民主管理信息管理_选举结果.本级社区委员会数].ToString().Trim();
			需要换届选举的社区委员会数 = dr[DB.Tab.基层科.民主管理信息管理_选举结果.需要换届选举的社区委员会数].ToString().Trim();
			社区综合当组织班子总职数 = dr[DB.Tab.基层科.民主管理信息管理_选举结果.社区综合当组织班子总职数].ToString().Trim();
			社区委员会班子总职数 = dr[DB.Tab.基层科.民主管理信息管理_选举结果.社区委员会班子总职数].ToString().Trim();
			总数 = dr[DB.Tab.基层科.民主管理信息管理_选举结果.总数].ToString().Trim();
		
			return true;
		}

		public static List<DB.Stru.基层科.民主管理信息管理_选举结果> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.基层科.民主管理信息管理_选举结果> lst = new List<DB.Stru.基层科.民主管理信息管理_选举结果>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.基层科.民主管理信息管理_选举结果 stru = new DB.Stru.基层科.民主管理信息管理_选举结果();
                stru.Dr2Stru ( dr );
                lst.Add ( stru );
            }

            return lst;
        }
		
		public static DataTable List2Dt ( ref List<DB.Stru.基层科.民主管理信息管理_选举结果> lst )
        {
            DB.Orm.基层科.民主管理信息管理_选举结果 orm = new DB.Orm.基层科.民主管理信息管理_选举结果 ();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.基层科.民主管理信息管理_选举结果 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }
		
        public static DB.Stru.基层科.民主管理信息管理_选举结果 StruFromList_ByID ( ref List<DB.Stru.基层科.民主管理信息管理_选举结果> list, string strID )
        {
		    if ( strID.Trim() == String.Empty )
                return null;
				
            foreach ( DB.Stru.基层科.民主管理信息管理_选举结果 stru in list )
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
                dr[DB.Tab.基层科.民主管理信息管理_选举结果.ID] = ID;
				
			CheckData();

            dr[DB.Tab.基层科.民主管理信息管理_选举结果.父ID] = string.IsNullOrEmpty(父ID) ? "0" : 父ID;
			if ( CreateDate != String.Empty )
			dr[DB.Tab.基层科.民主管理信息管理_选举结果.CreateDate] = CreateDate;
			dr[DB.Tab.基层科.民主管理信息管理_选举结果.Creator] = Creator;
			dr[DB.Tab.基层科.民主管理信息管理_选举结果.街道办事处] = 街道办事处;
			dr[DB.Tab.基层科.民主管理信息管理_选举结果.本级社区委员会数] = 本级社区委员会数;
			dr[DB.Tab.基层科.民主管理信息管理_选举结果.需要换届选举的社区委员会数] = 需要换届选举的社区委员会数;
			dr[DB.Tab.基层科.民主管理信息管理_选举结果.社区综合当组织班子总职数] = 社区综合当组织班子总职数;
			dr[DB.Tab.基层科.民主管理信息管理_选举结果.社区委员会班子总职数] = 社区委员会班子总职数;
			dr[DB.Tab.基层科.民主管理信息管理_选举结果.总数] = 总数;
        }
		
		public void CopyFrom( DB.Stru.基层科.民主管理信息管理_选举结果 struFrom )
        {
			ID = struFrom.ID;
			父ID = struFrom.父ID;
			CreateDate = struFrom.CreateDate;
			Creator = struFrom.Creator;
			街道办事处 = struFrom.街道办事处;
			本级社区委员会数 = struFrom.本级社区委员会数;
			需要换届选举的社区委员会数 = struFrom.需要换届选举的社区委员会数;
			社区综合当组织班子总职数 = struFrom.社区综合当组织班子总职数;
			社区委员会班子总职数 = struFrom.社区委员会班子总职数;
			总数 = struFrom.总数;
        }
		
		/// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
		public string GetLogStr ( DB.Stru.基层科.民主管理信息管理_选举结果 struOrg )
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

			if ( 街道办事处.Trim() != struOrg.街道办事处.Trim() )
				ary.Add ( String.Format ( "[街道办事处]: {0} => {1}", struOrg.街道办事处, 街道办事处) ) ;

			if ( 本级社区委员会数.Trim() != struOrg.本级社区委员会数.Trim() )
				ary.Add ( String.Format ( "[本级社区委员会数]: {0} => {1}", struOrg.本级社区委员会数, 本级社区委员会数) ) ;

			if ( 需要换届选举的社区委员会数.Trim() != struOrg.需要换届选举的社区委员会数.Trim() )
				ary.Add ( String.Format ( "[需要换届选举的社区委员会数]: {0} => {1}", struOrg.需要换届选举的社区委员会数, 需要换届选举的社区委员会数) ) ;

			if ( 社区综合当组织班子总职数.Trim() != struOrg.社区综合当组织班子总职数.Trim() )
				ary.Add ( String.Format ( "[社区综合当组织班子总职数]: {0} => {1}", struOrg.社区综合当组织班子总职数, 社区综合当组织班子总职数) ) ;

			if ( 社区委员会班子总职数.Trim() != struOrg.社区委员会班子总职数.Trim() )
				ary.Add ( String.Format ( "[社区委员会班子总职数]: {0} => {1}", struOrg.社区委员会班子总职数, 社区委员会班子总职数) ) ;

			if ( 总数.Trim() != struOrg.总数.Trim() )
				ary.Add ( String.Format ( "[总数]: {0} => {1}", struOrg.总数, 总数) ) ;


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
		
	}
}