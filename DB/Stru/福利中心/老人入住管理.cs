
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.福利中心
{
    public class 老人入住管理
    {
		string _ID = String.Empty ; 
		string _CreateDate = String.Empty ; 
		string _Creator = String.Empty ; 
		string _姓名 = String.Empty ; 
		string _性别 = String.Empty ; 
		string _本人成份 = String.Empty ; 
		string _户籍所在地 = String.Empty ; 
		string _籍贯 = String.Empty ; 
		string _身份证 = String.Empty ; 
		string _家庭住址 = String.Empty ; 
		string _身体状况 = String.Empty ; 
		string _申请事由 = String.Empty ; 
		string _押金费用 = String.Empty ; 
		
		public 老人入住管理()
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
		
		public string 本人成份
		{
			set { _本人成份 = value ; }
			get { return _本人成份  ; }
		}
		
		public string 户籍所在地
		{
			set { _户籍所在地 = value ; }
			get { return _户籍所在地  ; }
		}
		
		public string 籍贯
		{
			set { _籍贯 = value ; }
			get { return _籍贯  ; }
		}
		
		public string 身份证
		{
			set { _身份证 = value ; }
			get { return _身份证  ; }
		}
		
		public string 家庭住址
		{
			set { _家庭住址 = value ; }
			get { return _家庭住址  ; }
		}
		
		public string 身体状况
		{
			set { _身体状况 = value ; }
			get { return _身体状况  ; }
		}
		
		public string 申请事由
		{
			set { _申请事由 = value ; }
			get { return _申请事由  ; }
		}
		
		public string 押金费用
		{
			set { _押金费用 = value ; }
			get { return _押金费用  ; }
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
			本人成份 = String.Empty ; 
			户籍所在地 = String.Empty ; 
			籍贯 = String.Empty ; 
			身份证 = String.Empty ; 
			家庭住址 = String.Empty ; 
			身体状况 = String.Empty ; 
			申请事由 = String.Empty ; 
			押金费用 = String.Empty ; 
			
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
		
			ID = dr[DB.Tab.福利中心.老人入住管理.ID].ToString().Trim();
			CreateDate = dr[DB.Tab.福利中心.老人入住管理.CreateDate].ToString().Trim();
			Creator = dr[DB.Tab.福利中心.老人入住管理.Creator].ToString().Trim();
			姓名 = dr[DB.Tab.福利中心.老人入住管理.姓名].ToString().Trim();
			性别 = dr[DB.Tab.福利中心.老人入住管理.性别].ToString().Trim();
			本人成份 = dr[DB.Tab.福利中心.老人入住管理.本人成份].ToString().Trim();
			户籍所在地 = dr[DB.Tab.福利中心.老人入住管理.户籍所在地].ToString().Trim();
			籍贯 = dr[DB.Tab.福利中心.老人入住管理.籍贯].ToString().Trim();
			身份证 = dr[DB.Tab.福利中心.老人入住管理.身份证].ToString().Trim();
			家庭住址 = dr[DB.Tab.福利中心.老人入住管理.家庭住址].ToString().Trim();
			身体状况 = dr[DB.Tab.福利中心.老人入住管理.身体状况].ToString().Trim();
			申请事由 = dr[DB.Tab.福利中心.老人入住管理.申请事由].ToString().Trim();
			押金费用 = dr[DB.Tab.福利中心.老人入住管理.押金费用].ToString().Trim();
		
			return true;
		}

		public static List<DB.Stru.福利中心.老人入住管理> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.福利中心.老人入住管理> lst = new List<DB.Stru.福利中心.老人入住管理>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.福利中心.老人入住管理 stru = new DB.Stru.福利中心.老人入住管理();
                stru.Dr2Stru ( dr );
                lst.Add ( stru );
            }

            return lst;
        }
		
		public static DataTable List2Dt ( ref List<DB.Stru.福利中心.老人入住管理> lst )
        {
            DB.Orm.福利中心.老人入住管理 orm = new DB.Orm.福利中心.老人入住管理 ();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.福利中心.老人入住管理 o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }
		
        public static DB.Stru.福利中心.老人入住管理 StruFromList_ByID ( ref List<DB.Stru.福利中心.老人入住管理> list, string strID )
        {
		    if ( strID.Trim() == String.Empty )
                return null;
				
            foreach ( DB.Stru.福利中心.老人入住管理 stru in list )
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
                dr[DB.Tab.福利中心.老人入住管理.ID] = ID;
				
			CheckData();
			
			if ( CreateDate != String.Empty )
			dr[DB.Tab.福利中心.老人入住管理.CreateDate] = CreateDate;
			dr[DB.Tab.福利中心.老人入住管理.Creator] = Creator;
			dr[DB.Tab.福利中心.老人入住管理.姓名] = 姓名;
			dr[DB.Tab.福利中心.老人入住管理.性别] = 性别;
			dr[DB.Tab.福利中心.老人入住管理.本人成份] = 本人成份;
			dr[DB.Tab.福利中心.老人入住管理.户籍所在地] = 户籍所在地;
			dr[DB.Tab.福利中心.老人入住管理.籍贯] = 籍贯;
			dr[DB.Tab.福利中心.老人入住管理.身份证] = 身份证;
			dr[DB.Tab.福利中心.老人入住管理.家庭住址] = 家庭住址;
			dr[DB.Tab.福利中心.老人入住管理.身体状况] = 身体状况;
			dr[DB.Tab.福利中心.老人入住管理.申请事由] = 申请事由;
			dr[DB.Tab.福利中心.老人入住管理.押金费用] = 押金费用;
        }
		
		public void CopyFrom( DB.Stru.福利中心.老人入住管理 struFrom )
        {
			ID = struFrom.ID;
			CreateDate = struFrom.CreateDate;
			Creator = struFrom.Creator;
			姓名 = struFrom.姓名;
			性别 = struFrom.性别;
			本人成份 = struFrom.本人成份;
			户籍所在地 = struFrom.户籍所在地;
			籍贯 = struFrom.籍贯;
			身份证 = struFrom.身份证;
			家庭住址 = struFrom.家庭住址;
			身体状况 = struFrom.身体状况;
			申请事由 = struFrom.申请事由;
			押金费用 = struFrom.押金费用;
        }
		
		/// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
		public string GetLogStr ( DB.Stru.福利中心.老人入住管理 struOrg )
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

			if ( 本人成份.Trim() != struOrg.本人成份.Trim() )
				ary.Add ( String.Format ( "[本人成份]: {0} => {1}", struOrg.本人成份, 本人成份) ) ;

			if ( 户籍所在地.Trim() != struOrg.户籍所在地.Trim() )
				ary.Add ( String.Format ( "[户籍所在地]: {0} => {1}", struOrg.户籍所在地, 户籍所在地) ) ;

			if ( 籍贯.Trim() != struOrg.籍贯.Trim() )
				ary.Add ( String.Format ( "[籍贯]: {0} => {1}", struOrg.籍贯, 籍贯) ) ;

			if ( 身份证.Trim() != struOrg.身份证.Trim() )
				ary.Add ( String.Format ( "[身份证]: {0} => {1}", struOrg.身份证, 身份证) ) ;

			if ( 家庭住址.Trim() != struOrg.家庭住址.Trim() )
				ary.Add ( String.Format ( "[家庭住址]: {0} => {1}", struOrg.家庭住址, 家庭住址) ) ;

			if ( 身体状况.Trim() != struOrg.身体状况.Trim() )
				ary.Add ( String.Format ( "[身体状况]: {0} => {1}", struOrg.身体状况, 身体状况) ) ;

			if ( 申请事由.Trim() != struOrg.申请事由.Trim() )
				ary.Add ( String.Format ( "[申请事由]: {0} => {1}", struOrg.申请事由, 申请事由) ) ;

			if ( 押金费用.Trim() != struOrg.押金费用.Trim() )
				ary.Add ( String.Format ( "[押金费用]: {0} => {1}", struOrg.押金费用, 押金费用) ) ;


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
		
	}
}