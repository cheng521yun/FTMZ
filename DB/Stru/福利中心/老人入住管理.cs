
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.��������
{
    public class ������ס����
    {
		string _ID = String.Empty ; 
		string _CreateDate = String.Empty ; 
		string _Creator = String.Empty ; 
		string _���� = String.Empty ; 
		string _�Ա� = String.Empty ; 
		string _���˳ɷ� = String.Empty ; 
		string _�������ڵ� = String.Empty ; 
		string _���� = String.Empty ; 
		string _���֤ = String.Empty ; 
		string _��ͥסַ = String.Empty ; 
		string _����״�� = String.Empty ; 
		string _�������� = String.Empty ; 
		string _Ѻ����� = String.Empty ; 
		
		public ������ס����()
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
		
		public string ����
		{
			set { _���� = value ; }
			get { return _����  ; }
		}
		
		public string �Ա�
		{
			set { _�Ա� = value ; }
			get { return _�Ա�  ; }
		}
		
		public string ���˳ɷ�
		{
			set { _���˳ɷ� = value ; }
			get { return _���˳ɷ�  ; }
		}
		
		public string �������ڵ�
		{
			set { _�������ڵ� = value ; }
			get { return _�������ڵ�  ; }
		}
		
		public string ����
		{
			set { _���� = value ; }
			get { return _����  ; }
		}
		
		public string ���֤
		{
			set { _���֤ = value ; }
			get { return _���֤  ; }
		}
		
		public string ��ͥסַ
		{
			set { _��ͥסַ = value ; }
			get { return _��ͥסַ  ; }
		}
		
		public string ����״��
		{
			set { _����״�� = value ; }
			get { return _����״��  ; }
		}
		
		public string ��������
		{
			set { _�������� = value ; }
			get { return _��������  ; }
		}
		
		public string Ѻ�����
		{
			set { _Ѻ����� = value ; }
			get { return _Ѻ�����  ; }
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
			���� = String.Empty ; 
			�Ա� = String.Empty ; 
			���˳ɷ� = String.Empty ; 
			�������ڵ� = String.Empty ; 
			���� = String.Empty ; 
			���֤ = String.Empty ; 
			��ͥסַ = String.Empty ; 
			����״�� = String.Empty ; 
			�������� = String.Empty ; 
			Ѻ����� = String.Empty ; 
			
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
		
			ID = dr[DB.Tab.��������.������ס����.ID].ToString().Trim();
			CreateDate = dr[DB.Tab.��������.������ס����.CreateDate].ToString().Trim();
			Creator = dr[DB.Tab.��������.������ס����.Creator].ToString().Trim();
			���� = dr[DB.Tab.��������.������ס����.����].ToString().Trim();
			�Ա� = dr[DB.Tab.��������.������ס����.�Ա�].ToString().Trim();
			���˳ɷ� = dr[DB.Tab.��������.������ס����.���˳ɷ�].ToString().Trim();
			�������ڵ� = dr[DB.Tab.��������.������ס����.�������ڵ�].ToString().Trim();
			���� = dr[DB.Tab.��������.������ס����.����].ToString().Trim();
			���֤ = dr[DB.Tab.��������.������ס����.���֤].ToString().Trim();
			��ͥסַ = dr[DB.Tab.��������.������ס����.��ͥסַ].ToString().Trim();
			����״�� = dr[DB.Tab.��������.������ס����.����״��].ToString().Trim();
			�������� = dr[DB.Tab.��������.������ס����.��������].ToString().Trim();
			Ѻ����� = dr[DB.Tab.��������.������ס����.Ѻ�����].ToString().Trim();
		
			return true;
		}

		public static List<DB.Stru.��������.������ס����> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.��������.������ס����> lst = new List<DB.Stru.��������.������ס����>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.��������.������ס���� stru = new DB.Stru.��������.������ס����();
                stru.Dr2Stru ( dr );
                lst.Add ( stru );
            }

            return lst;
        }
		
		public static DataTable List2Dt ( ref List<DB.Stru.��������.������ס����> lst )
        {
            DB.Orm.��������.������ס���� orm = new DB.Orm.��������.������ס���� ();
            DataTable dt = orm.GetBlank();

            foreach ( DB.Stru.��������.������ס���� o in lst )
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }
		
        public static DB.Stru.��������.������ס���� StruFromList_ByID ( ref List<DB.Stru.��������.������ס����> list, string strID )
        {
		    if ( strID.Trim() == String.Empty )
                return null;
				
            foreach ( DB.Stru.��������.������ס���� stru in list )
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
                dr[DB.Tab.��������.������ס����.ID] = ID;
				
			CheckData();
			
			if ( CreateDate != String.Empty )
			dr[DB.Tab.��������.������ס����.CreateDate] = CreateDate;
			dr[DB.Tab.��������.������ס����.Creator] = Creator;
			dr[DB.Tab.��������.������ס����.����] = ����;
			dr[DB.Tab.��������.������ס����.�Ա�] = �Ա�;
			dr[DB.Tab.��������.������ס����.���˳ɷ�] = ���˳ɷ�;
			dr[DB.Tab.��������.������ס����.�������ڵ�] = �������ڵ�;
			dr[DB.Tab.��������.������ס����.����] = ����;
			dr[DB.Tab.��������.������ס����.���֤] = ���֤;
			dr[DB.Tab.��������.������ס����.��ͥסַ] = ��ͥסַ;
			dr[DB.Tab.��������.������ס����.����״��] = ����״��;
			dr[DB.Tab.��������.������ס����.��������] = ��������;
			dr[DB.Tab.��������.������ס����.Ѻ�����] = Ѻ�����;
        }
		
		public void CopyFrom( DB.Stru.��������.������ס���� struFrom )
        {
			ID = struFrom.ID;
			CreateDate = struFrom.CreateDate;
			Creator = struFrom.Creator;
			���� = struFrom.����;
			�Ա� = struFrom.�Ա�;
			���˳ɷ� = struFrom.���˳ɷ�;
			�������ڵ� = struFrom.�������ڵ�;
			���� = struFrom.����;
			���֤ = struFrom.���֤;
			��ͥסַ = struFrom.��ͥסַ;
			����״�� = struFrom.����״��;
			�������� = struFrom.��������;
			Ѻ����� = struFrom.Ѻ�����;
        }
		
		/// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
		public string GetLogStr ( DB.Stru.��������.������ס���� struOrg )
        {
			if ( struOrg.ID == String.Empty ) 
				return String.Empty; 
		
            string strRet = String.Empty;
            ArrayList ary = new ArrayList ();
			
			if ( CreateDate.Trim() != struOrg.CreateDate.Trim() )
				ary.Add ( String.Format ( "[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate) ) ;

			if ( Creator.Trim() != struOrg.Creator.Trim() )
				ary.Add ( String.Format ( "[Creator]: {0} => {1}", struOrg.Creator, Creator) ) ;

			if ( ����.Trim() != struOrg.����.Trim() )
				ary.Add ( String.Format ( "[����]: {0} => {1}", struOrg.����, ����) ) ;

			if ( �Ա�.Trim() != struOrg.�Ա�.Trim() )
				ary.Add ( String.Format ( "[�Ա�]: {0} => {1}", struOrg.�Ա�, �Ա�) ) ;

			if ( ���˳ɷ�.Trim() != struOrg.���˳ɷ�.Trim() )
				ary.Add ( String.Format ( "[���˳ɷ�]: {0} => {1}", struOrg.���˳ɷ�, ���˳ɷ�) ) ;

			if ( �������ڵ�.Trim() != struOrg.�������ڵ�.Trim() )
				ary.Add ( String.Format ( "[�������ڵ�]: {0} => {1}", struOrg.�������ڵ�, �������ڵ�) ) ;

			if ( ����.Trim() != struOrg.����.Trim() )
				ary.Add ( String.Format ( "[����]: {0} => {1}", struOrg.����, ����) ) ;

			if ( ���֤.Trim() != struOrg.���֤.Trim() )
				ary.Add ( String.Format ( "[���֤]: {0} => {1}", struOrg.���֤, ���֤) ) ;

			if ( ��ͥסַ.Trim() != struOrg.��ͥסַ.Trim() )
				ary.Add ( String.Format ( "[��ͥסַ]: {0} => {1}", struOrg.��ͥסַ, ��ͥסַ) ) ;

			if ( ����״��.Trim() != struOrg.����״��.Trim() )
				ary.Add ( String.Format ( "[����״��]: {0} => {1}", struOrg.����״��, ����״��) ) ;

			if ( ��������.Trim() != struOrg.��������.Trim() )
				ary.Add ( String.Format ( "[��������]: {0} => {1}", struOrg.��������, ��������) ) ;

			if ( Ѻ�����.Trim() != struOrg.Ѻ�����.Trim() )
				ary.Add ( String.Format ( "[Ѻ�����]: {0} => {1}", struOrg.Ѻ�����, Ѻ�����) ) ;


            foreach ( string str in ary )
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
		
	}
}