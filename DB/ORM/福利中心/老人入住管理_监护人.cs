




using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;


namespace DB.Orm.福利中心
{
    public class 老人入住管理_监护人
    {
        DB.DA.福利中心.老人入住管理_监护人 da = new DB.DA.福利中心.老人入住管理_监护人();
		
		#region Get

		public DataTable GetBlank ()
		{
			return da.GetBlank();
		}

		public List<DB.Stru.福利中心.老人入住管理_监护人> Get_ByWhere (string strWhere)
		{
			List<DB.Stru.福利中心.老人入住管理_监护人> lst = new List<DB.Stru.福利中心.老人入住管理_监护人>();
		
			DataTable dt = da.GetWhere(strWhere);
	
			if (SQL.IsNotValid(ref dt))
				return lst;
				
			lst = DB.Stru.福利中心.老人入住管理_监护人.Dt2List(ref dt);
	
			return lst;
		}
		
		public DB.Stru.福利中心.老人入住管理_监护人 GetFirst_ByWhere (string strWhere)
		{
			DB.Stru.福利中心.老人入住管理_监护人 stru = new DB.Stru.福利中心.老人入住管理_监护人 () ;
			List<DB.Stru.福利中心.老人入住管理_监护人> list = Get_ByWhere ( strWhere ) ;
			
			if ( list != null && list.Count > 0 )
				stru = list [ 0 ];
				
			return stru ;
		}
		
		public DB.Stru.福利中心.老人入住管理_监护人 Get_ByID (string strID)
		{
		    string strWhere = String.Format("{0}='{1}'", DB.Tab.福利中心.老人入住管理_监护人.ID, strID);
            return GetFirst_ByWhere ( strWhere );
		}
		
		#endregion 
		
		#region Split to Page
		
        //Get one Page data from all 
		public List<DB.Stru.福利中心.老人入住管理_监护人> GetPage( int nPageNo , string strWhere )
        {
            List<DB.Stru.福利中心.老人入住管理_监护人> lst = new List<DB.Stru.福利中心.老人入住管理_监护人> ();
			
			DataTable dt = da.GetPage ( nPageNo , strWhere );

            if ( SQL.IsNotValid ( ref dt ) )
                return lst;

			lst = DB.Stru.福利中心.老人入住管理_监护人.Dt2List ( ref dt );

            return lst;
        }
		
		//Get Page Number  
        public int GetPageMax(string strWhere)
        {
            return da.GetPageMax(strWhere);
        }

		#endregion
		
		#region Save
		public string Save( ref DataTable dt )
        {
            string strID = da.Save ( ref dt );
            return strID;
        }
		
        public string Save( DB.Stru.福利中心.老人入住管理_监护人 stru )
        {
            DataTable dt = GetBlank();
            DataRow dr = dt.NewRow();
            stru.Stru2Dr( ref dr );
            dt.Rows.Add(dr);
            string strID = da.Save( ref dt );
            return strID;
        }
		
		public bool Save ( List<DB.Stru.福利中心.老人入住管理_监护人> lst )
        {
            bool bRet = true;
            string strID;
            foreach ( DB.Stru.福利中心.老人入住管理_监护人 stru in lst )
            {
                strID = Save ( stru );
                bRet &= (strID == "") ? false : true;
            }
            return bRet;
        }
		
		#endregion 
		
		#region Delete
        
		public void Delete( DB.Stru.福利中心.老人入住管理_监护人 stru )
        {
            da.Delete_ByID ( stru.ID );
        }
		
		public void Delete ( List<string> lstDel  )
        {
            foreach ( string strID in lstDel )
                da.Delete_ByID ( strID );
        }
		
		public void Delete( List<DB.Stru.福利中心.老人入住管理_监护人> lst )
        {
			foreach ( DB.Stru.福利中心.老人入住管理_监护人 stru in lst )
            	da.Delete_ByID ( stru.ID );
        }
		
		#endregion 
		
		
		
		#region Update
		
        public void Update_ByID( string strID, string strFld, string strVal )
        {
            da.Update_ByID( strID, strFld, strVal );
        }
		
		#endregion 
		
		#region Sum
		
		public int GetCount(string strWhere)
        {
            int nCount = 0;
            DataTable dt = da.GetCount( strWhere );

            if (SQL.IsValid(ref dt))
            {
                string strCount = dt.Rows[0][0].ToString();
                nCount = FF.Fun.MyConvert.Str2Int(strCount);
            }

            return nCount;
        }
		
		public int GetSum(string strWhere)
        {
            int nCount = 0;
            DataTable dt = da.GetCount( strWhere );

            if (SQL.IsValid(ref dt))
            {
                string strCount = dt.Rows[0][0].ToString();
                nCount = FF.Fun.MyConvert.Str2Int(strCount);
            }

            return nCount;
        }
		
		#endregion
	}
	

}	


