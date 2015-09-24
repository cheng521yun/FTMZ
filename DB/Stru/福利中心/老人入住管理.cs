


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
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _委员会名称 = String.Empty;
        string _所属街道1 = String.Empty;
        string _所属街道2 = String.Empty;
        string _办公电话 = String.Empty;
        string _委员会地址 = String.Empty;
        string _人口数 = String.Empty;
        string _面积 = String.Empty;
        string _辖区范围 = String.Empty;
        string _组织机构代码 = String.Empty;

        public 老人入住管理()
        {
            Init();
        }

        #region Prop

        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string CreateDate
        {
            set { _CreateDate = value; }
            get { return _CreateDate; }
        }
        public DateTime datCreateDate
        {
            set { _CreateDate = value.ToString("yyyy-MM-dd HH:mm:ss"); }
            get { return FF.Fun.MyConvert.Str2Date(_CreateDate); }
        }
        public string CreateDateStr
        {
            get { return FF.Fun.MyConvert.Str2Date(_CreateDate).ToString("yyyy-MM-dd"); }
        }

        public string Creator
        {
            set { _Creator = value; }
            get { return _Creator; }
        }

        public string 委员会名称
        {
            set { _委员会名称 = value; }
            get { return _委员会名称; }
        }

        public string 所属街道1
        {
            set { _所属街道1 = value; }
            get { return _所属街道1; }
        }

        public string 所属街道2
        {
            set { _所属街道2 = value; }
            get { return _所属街道2; }
        }

        public string 办公电话
        {
            set { _办公电话 = value; }
            get { return _办公电话; }
        }

        public string 委员会地址
        {
            set { _委员会地址 = value; }
            get { return _委员会地址; }
        }

        public string 人口数
        {
            set { _人口数 = value; }
            get { return _人口数; }
        }

        public string 面积
        {
            set { _面积 = value; }
            get { return _面积; }
        }

        public string 辖区范围
        {
            set { _辖区范围 = value; }
            get { return _辖区范围; }
        }

        public string 组织机构代码
        {
            set { _组织机构代码 = value; }
            get { return _组织机构代码; }
        }


        #endregion

        //Will Manual Input Code
        //Default Value, 
        void Init()
        {
        }

        void Clear()
        {
            ID = String.Empty;
            CreateDate = String.Empty;
            Creator = String.Empty;
            委员会名称 = String.Empty;
            所属街道1 = String.Empty;
            所属街道2 = String.Empty;
            办公电话 = String.Empty;
            委员会地址 = String.Empty;
            人口数 = String.Empty;
            面积 = String.Empty;
            辖区范围 = String.Empty;
            组织机构代码 = String.Empty;

            Init();
        }

        public bool IsValid()
        {
            return (ID.Trim() == String.Empty) ? false : true;
        }

        public bool IsNotValid()
        {
            return !IsValid();
        }

        public bool Dr2Stru(DataRow dr)
        {
            Clear();

            if (dr == null)
                return false;

            ID = dr[DB.Tab.基层科.民主管理信息管理.ID].ToString().Trim();
            CreateDate = dr[DB.Tab.基层科.民主管理信息管理.CreateDate].ToString().Trim();
            Creator = dr[DB.Tab.基层科.民主管理信息管理.Creator].ToString().Trim();
            委员会名称 = dr[DB.Tab.基层科.民主管理信息管理.委员会名称].ToString().Trim();
            所属街道1 = dr[DB.Tab.基层科.民主管理信息管理.所属街道1].ToString().Trim();
            所属街道2 = dr[DB.Tab.基层科.民主管理信息管理.所属街道2].ToString().Trim();
            办公电话 = dr[DB.Tab.基层科.民主管理信息管理.办公电话].ToString().Trim();
            委员会地址 = dr[DB.Tab.基层科.民主管理信息管理.委员会地址].ToString().Trim();
            人口数 = dr[DB.Tab.基层科.民主管理信息管理.人口数].ToString().Trim();
            面积 = dr[DB.Tab.基层科.民主管理信息管理.面积].ToString().Trim();
            辖区范围 = dr[DB.Tab.基层科.民主管理信息管理.辖区范围].ToString().Trim();
            组织机构代码 = dr[DB.Tab.基层科.民主管理信息管理.组织机构代码].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.基层科.民主管理信息管理> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.基层科.民主管理信息管理> lst = new List<DB.Stru.基层科.民主管理信息管理>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.基层科.民主管理信息管理 stru = new DB.Stru.基层科.民主管理信息管理();
                stru.Dr2Stru(dr);
                lst.Add(stru);
            }

            return lst;
        }

        public static DataTable List2Dt(ref List<DB.Stru.基层科.民主管理信息管理> lst)
        {
            DB.Orm.基层科.民主管理信息管理 orm = new DB.Orm.基层科.民主管理信息管理();
            DataTable dt = orm.GetBlank();

            foreach (DB.Stru.基层科.民主管理信息管理 o in lst)
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }

        public static DB.Stru.基层科.民主管理信息管理 StruFromList_ByID(ref List<DB.Stru.基层科.民主管理信息管理> list, string strID)
        {
            if (strID.Trim() == String.Empty)
                return null;

            foreach (DB.Stru.基层科.民主管理信息管理 stru in list)
            {
                if (stru.ID == strID)
                    return stru;
            }
            return null;
        }

        //Will Manual Input Code
        //Check Special Field Data can save into DataBase
        private void CheckData()
        {
            if (CreateDate == String.Empty)
                CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }

        public void Stru2Dr(ref DataRow dr)
        {
            if (ID.Trim() != String.Empty)
                dr[DB.Tab.基层科.民主管理信息管理.ID] = ID;

            CheckData();

            if (CreateDate != String.Empty)
                dr[DB.Tab.基层科.民主管理信息管理.CreateDate] = CreateDate;
            dr[DB.Tab.基层科.民主管理信息管理.Creator] = Creator;
            dr[DB.Tab.基层科.民主管理信息管理.委员会名称] = 委员会名称;
            dr[DB.Tab.基层科.民主管理信息管理.所属街道1] = 所属街道1;
            dr[DB.Tab.基层科.民主管理信息管理.所属街道2] = 所属街道2;
            dr[DB.Tab.基层科.民主管理信息管理.办公电话] = 办公电话;
            dr[DB.Tab.基层科.民主管理信息管理.委员会地址] = 委员会地址;
            dr[DB.Tab.基层科.民主管理信息管理.人口数] = 人口数;
            dr[DB.Tab.基层科.民主管理信息管理.面积] = 面积;
            dr[DB.Tab.基层科.民主管理信息管理.辖区范围] = 辖区范围;
            dr[DB.Tab.基层科.民主管理信息管理.组织机构代码] = 组织机构代码;
        }

        public void CopyFrom(DB.Stru.基层科.民主管理信息管理 struFrom)
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            委员会名称 = struFrom.委员会名称;
            所属街道1 = struFrom.所属街道1;
            所属街道2 = struFrom.所属街道2;
            办公电话 = struFrom.办公电话;
            委员会地址 = struFrom.委员会地址;
            人口数 = struFrom.人口数;
            面积 = struFrom.面积;
            辖区范围 = struFrom.辖区范围;
            组织机构代码 = struFrom.组织机构代码;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr(DB.Stru.基层科.民主管理信息管理 struOrg)
        {
            if (struOrg.ID == String.Empty)
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if (CreateDate.Trim() != struOrg.CreateDate.Trim())
                ary.Add(String.Format("[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate));

            if (Creator.Trim() != struOrg.Creator.Trim())
                ary.Add(String.Format("[Creator]: {0} => {1}", struOrg.Creator, Creator));

            if (委员会名称.Trim() != struOrg.委员会名称.Trim())
                ary.Add(String.Format("[委员会名称]: {0} => {1}", struOrg.委员会名称, 委员会名称));

            if (所属街道1.Trim() != struOrg.所属街道1.Trim())
                ary.Add(String.Format("[所属街道1]: {0} => {1}", struOrg.所属街道1, 所属街道1));

            if (所属街道2.Trim() != struOrg.所属街道2.Trim())
                ary.Add(String.Format("[所属街道2]: {0} => {1}", struOrg.所属街道2, 所属街道2));

            if (办公电话.Trim() != struOrg.办公电话.Trim())
                ary.Add(String.Format("[办公电话]: {0} => {1}", struOrg.办公电话, 办公电话));

            if (委员会地址.Trim() != struOrg.委员会地址.Trim())
                ary.Add(String.Format("[委员会地址]: {0} => {1}", struOrg.委员会地址, 委员会地址));

            if (人口数.Trim() != struOrg.人口数.Trim())
                ary.Add(String.Format("[人口数]: {0} => {1}", struOrg.人口数, 人口数));

            if (面积.Trim() != struOrg.面积.Trim())
                ary.Add(String.Format("[面积]: {0} => {1}", struOrg.面积, 面积));

            if (辖区范围.Trim() != struOrg.辖区范围.Trim())
                ary.Add(String.Format("[辖区范围]: {0} => {1}", struOrg.辖区范围, 辖区范围));

            if (组织机构代码.Trim() != struOrg.组织机构代码.Trim())
                ary.Add(String.Format("[组织机构代码]: {0} => {1}", struOrg.组织机构代码, 组织机构代码));


            foreach (string str in ary)
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}