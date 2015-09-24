


using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace DB.Stru.事务科
{
    public class 居家养老服务补贴
    {
        string _ID = String.Empty;
        string _CreateDate = String.Empty;
        string _Creator = String.Empty;
        string _所属街道 = String.Empty;
        string _社区 = String.Empty;
        string _姓名 = String.Empty;
        string _性别 = String.Empty;
        string _身份证 = String.Empty;
        string _年龄 = String.Empty;
        string _享受类别 = String.Empty;
        string _享受金额 = String.Empty;
        string _服务机构 = String.Empty;
        string _批准时间 = String.Empty;
        string _居住地址 = String.Empty;
        string _居住状况 = String.Empty;
        string _联系电话 = String.Empty;
        string _紧急联系人 = String.Empty;
        string _紧急联系人电话 = String.Empty;
        string _备注 = String.Empty;
        string _填表人 = String.Empty;
        string _填表人联系电话 = String.Empty;
        string _填表日期 = String.Empty;

        public 居家养老服务补贴()
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

        public string 所属街道
        {
            set { _所属街道 = value; }
            get { return _所属街道; }
        }

        public string 社区
        {
            set { _社区 = value; }
            get { return _社区; }
        }

        public string 姓名
        {
            set { _姓名 = value; }
            get { return _姓名; }
        }

        public string 性别
        {
            set { _性别 = value; }
            get { return _性别; }
        }

        public string 身份证
        {
            set { _身份证 = value; }
            get { return _身份证; }
        }

        public string 年龄
        {
            set { _年龄 = value; }
            get { return _年龄; }
        }

        public string 享受类别
        {
            set { _享受类别 = value; }
            get { return _享受类别; }
        }
        public DateTime dat享受类别
        {
            set { _享受类别 = value.ToString("yyyy-MM-dd HH:mm:ss"); }
            get { return FF.Fun.MyConvert.Str2Date(_享受类别); }
        }
        public string 享受类别Str
        {
            get { return FF.Fun.MyConvert.Str2Date(_享受类别).ToString("yyyy-MM-dd"); }
        }

        public string 享受金额
        {
            set { _享受金额 = value; }
            get { return _享受金额; }
        }

        public string 服务机构
        {
            set { _服务机构 = value; }
            get { return _服务机构; }
        }

        public string 批准时间
        {
            set { _批准时间 = value; }
            get { return _批准时间; }
        }
        public DateTime dat批准时间
        {
            set { _批准时间 = value.ToString("yyyy-MM-dd HH:mm:ss"); }
            get { return FF.Fun.MyConvert.Str2Date(_批准时间); }
        }
        public string 批准时间Str
        {
            get { return FF.Fun.MyConvert.Str2Date(_批准时间).ToString("yyyy-MM-dd"); }
        }

        public string 居住地址
        {
            set { _居住地址 = value; }
            get { return _居住地址; }
        }

        public string 居住状况
        {
            set { _居住状况 = value; }
            get { return _居住状况; }
        }

        public string 联系电话
        {
            set { _联系电话 = value; }
            get { return _联系电话; }
        }

        public string 紧急联系人
        {
            set { _紧急联系人 = value; }
            get { return _紧急联系人; }
        }

        public string 紧急联系人电话
        {
            set { _紧急联系人电话 = value; }
            get { return _紧急联系人电话; }
        }

        public string 备注
        {
            set { _备注 = value; }
            get { return _备注; }
        }

        public string 填表人
        {
            set { _填表人 = value; }
            get { return _填表人; }
        }

        public string 填表人联系电话
        {
            set { _填表人联系电话 = value; }
            get { return _填表人联系电话; }
        }

        public string 填表日期
        {
            set { _填表日期 = value; }
            get { return _填表日期; }
        }
        public DateTime dat填表日期
        {
            set { _填表日期 = value.ToString("yyyy-MM-dd HH:mm:ss"); }
            get { return FF.Fun.MyConvert.Str2Date(_填表日期); }
        }
        public string 填表日期Str
        {
            get { return FF.Fun.MyConvert.Str2Date(_填表日期).ToString("yyyy-MM-dd"); }
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
            所属街道 = String.Empty;
            社区 = String.Empty;
            姓名 = String.Empty;
            性别 = String.Empty;
            身份证 = String.Empty;
            年龄 = String.Empty;
            享受类别 = String.Empty;
            享受金额 = String.Empty;
            服务机构 = String.Empty;
            批准时间 = String.Empty;
            居住地址 = String.Empty;
            居住状况 = String.Empty;
            联系电话 = String.Empty;
            紧急联系人 = String.Empty;
            紧急联系人电话 = String.Empty;
            备注 = String.Empty;
            填表人 = String.Empty;
            填表人联系电话 = String.Empty;
            填表日期 = String.Empty;

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

            ID = dr[DB.Tab.事务科.居家养老服务补贴.ID].ToString().Trim();
            CreateDate = dr[DB.Tab.事务科.居家养老服务补贴.CreateDate].ToString().Trim();
            Creator = dr[DB.Tab.事务科.居家养老服务补贴.Creator].ToString().Trim();
            所属街道 = dr[DB.Tab.事务科.居家养老服务补贴.所属街道].ToString().Trim();
            社区 = dr[DB.Tab.事务科.居家养老服务补贴.社区].ToString().Trim();
            姓名 = dr[DB.Tab.事务科.居家养老服务补贴.姓名].ToString().Trim();
            性别 = dr[DB.Tab.事务科.居家养老服务补贴.性别].ToString().Trim();
            身份证 = dr[DB.Tab.事务科.居家养老服务补贴.身份证].ToString().Trim();
            年龄 = dr[DB.Tab.事务科.居家养老服务补贴.年龄].ToString().Trim();
            享受类别 = dr[DB.Tab.事务科.居家养老服务补贴.享受类别].ToString().Trim();
            享受金额 = dr[DB.Tab.事务科.居家养老服务补贴.享受金额].ToString().Trim();
            服务机构 = dr[DB.Tab.事务科.居家养老服务补贴.服务机构].ToString().Trim();
            批准时间 = dr[DB.Tab.事务科.居家养老服务补贴.批准时间].ToString().Trim();
            居住地址 = dr[DB.Tab.事务科.居家养老服务补贴.居住地址].ToString().Trim();
            居住状况 = dr[DB.Tab.事务科.居家养老服务补贴.居住状况].ToString().Trim();
            联系电话 = dr[DB.Tab.事务科.居家养老服务补贴.联系电话].ToString().Trim();
            紧急联系人 = dr[DB.Tab.事务科.居家养老服务补贴.紧急联系人].ToString().Trim();
            紧急联系人电话 = dr[DB.Tab.事务科.居家养老服务补贴.紧急联系人电话].ToString().Trim();
            备注 = dr[DB.Tab.事务科.居家养老服务补贴.备注].ToString().Trim();
            填表人 = dr[DB.Tab.事务科.居家养老服务补贴.填表人].ToString().Trim();
            填表人联系电话 = dr[DB.Tab.事务科.居家养老服务补贴.填表人联系电话].ToString().Trim();
            填表日期 = dr[DB.Tab.事务科.居家养老服务补贴.填表日期].ToString().Trim();

            return true;
        }

        public static List<DB.Stru.事务科.居家养老服务补贴> Dt2List(ref DataTable dt)
        {
            List<DB.Stru.事务科.居家养老服务补贴> lst = new List<DB.Stru.事务科.居家养老服务补贴>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                DB.Stru.事务科.居家养老服务补贴 stru = new DB.Stru.事务科.居家养老服务补贴();
                stru.Dr2Stru(dr);
                lst.Add(stru);
            }

            return lst;
        }

        public static DataTable List2Dt(ref List<DB.Stru.事务科.居家养老服务补贴> lst)
        {
            DB.Orm.事务科.居家养老服务补贴 orm = new DB.Orm.事务科.居家养老服务补贴();
            DataTable dt = orm.GetBlank();

            foreach (DB.Stru.事务科.居家养老服务补贴 o in lst)
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }

        public static DB.Stru.事务科.居家养老服务补贴 StruFromList_ByID(ref List<DB.Stru.事务科.居家养老服务补贴> list, string strID)
        {
            if (strID.Trim() == String.Empty)
                return null;

            foreach (DB.Stru.事务科.居家养老服务补贴 stru in list)
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
                dr[DB.Tab.事务科.居家养老服务补贴.ID] = ID;

            CheckData();

            if (CreateDate != String.Empty)
                dr[DB.Tab.事务科.居家养老服务补贴.CreateDate] = CreateDate;
            dr[DB.Tab.事务科.居家养老服务补贴.Creator] = Creator;
            dr[DB.Tab.事务科.居家养老服务补贴.所属街道] = 所属街道;
            dr[DB.Tab.事务科.居家养老服务补贴.社区] = 社区;
            dr[DB.Tab.事务科.居家养老服务补贴.姓名] = 姓名;
            dr[DB.Tab.事务科.居家养老服务补贴.性别] = 性别;
            dr[DB.Tab.事务科.居家养老服务补贴.身份证] = 身份证;
            dr[DB.Tab.事务科.居家养老服务补贴.年龄] = 年龄;
            if (享受类别 != String.Empty)
                dr[DB.Tab.事务科.居家养老服务补贴.享受类别] = 享受类别;
            dr[DB.Tab.事务科.居家养老服务补贴.享受金额] = string.IsNullOrEmpty(享受金额) ? "0" : 享受金额;
            dr[DB.Tab.事务科.居家养老服务补贴.服务机构] = 服务机构;
            if (批准时间 != String.Empty)
                dr[DB.Tab.事务科.居家养老服务补贴.批准时间] = 批准时间;
            dr[DB.Tab.事务科.居家养老服务补贴.居住地址] = 居住地址;
            dr[DB.Tab.事务科.居家养老服务补贴.居住状况] = 居住状况;
            dr[DB.Tab.事务科.居家养老服务补贴.联系电话] = 联系电话;
            dr[DB.Tab.事务科.居家养老服务补贴.紧急联系人] = 紧急联系人;
            dr[DB.Tab.事务科.居家养老服务补贴.紧急联系人电话] = 紧急联系人电话;
            dr[DB.Tab.事务科.居家养老服务补贴.备注] = 备注;
            dr[DB.Tab.事务科.居家养老服务补贴.填表人] = 填表人;
            dr[DB.Tab.事务科.居家养老服务补贴.填表人联系电话] = 填表人联系电话;
            if (填表日期 != String.Empty)
                dr[DB.Tab.事务科.居家养老服务补贴.填表日期] = 填表日期;
        }

        public void CopyFrom(DB.Stru.事务科.居家养老服务补贴 struFrom)
        {
            ID = struFrom.ID;
            CreateDate = struFrom.CreateDate;
            Creator = struFrom.Creator;
            所属街道 = struFrom.所属街道;
            社区 = struFrom.社区;
            姓名 = struFrom.姓名;
            性别 = struFrom.性别;
            身份证 = struFrom.身份证;
            年龄 = struFrom.年龄;
            享受类别 = struFrom.享受类别;
            享受金额 = struFrom.享受金额;
            服务机构 = struFrom.服务机构;
            批准时间 = struFrom.批准时间;
            居住地址 = struFrom.居住地址;
            居住状况 = struFrom.居住状况;
            联系电话 = struFrom.联系电话;
            紧急联系人 = struFrom.紧急联系人;
            紧急联系人电话 = struFrom.紧急联系人电话;
            备注 = struFrom.备注;
            填表人 = struFrom.填表人;
            填表人联系电话 = struFrom.填表人联系电话;
            填表日期 = struFrom.填表日期;
        }

        /// <summary>
        /// Get Modify Log
        /// </summary>
        /// <returns></returns>
        public string GetLogStr(DB.Stru.事务科.居家养老服务补贴 struOrg)
        {
            if (struOrg.ID == String.Empty)
                return String.Empty;

            string strRet = String.Empty;
            ArrayList ary = new ArrayList();

            if (CreateDate.Trim() != struOrg.CreateDate.Trim())
                ary.Add(String.Format("[CreateDate]: {0} => {1}", struOrg.CreateDate, CreateDate));

            if (Creator.Trim() != struOrg.Creator.Trim())
                ary.Add(String.Format("[Creator]: {0} => {1}", struOrg.Creator, Creator));

            if (所属街道.Trim() != struOrg.所属街道.Trim())
                ary.Add(String.Format("[所属街道]: {0} => {1}", struOrg.所属街道, 所属街道));

            if (社区.Trim() != struOrg.社区.Trim())
                ary.Add(String.Format("[社区]: {0} => {1}", struOrg.社区, 社区));

            if (姓名.Trim() != struOrg.姓名.Trim())
                ary.Add(String.Format("[姓名]: {0} => {1}", struOrg.姓名, 姓名));

            if (性别.Trim() != struOrg.性别.Trim())
                ary.Add(String.Format("[性别]: {0} => {1}", struOrg.性别, 性别));

            if (身份证.Trim() != struOrg.身份证.Trim())
                ary.Add(String.Format("[身份证]: {0} => {1}", struOrg.身份证, 身份证));

            if (年龄.Trim() != struOrg.年龄.Trim())
                ary.Add(String.Format("[年龄]: {0} => {1}", struOrg.年龄, 年龄));

            if (享受类别.Trim() != struOrg.享受类别.Trim())
                ary.Add(String.Format("[享受类别]: {0} => {1}", struOrg.享受类别, 享受类别));

            if (享受金额.Trim() != struOrg.享受金额.Trim())
                ary.Add(String.Format("[享受金额]: {0} => {1}", struOrg.享受金额, 享受金额));

            if (服务机构.Trim() != struOrg.服务机构.Trim())
                ary.Add(String.Format("[服务机构]: {0} => {1}", struOrg.服务机构, 服务机构));

            if (批准时间.Trim() != struOrg.批准时间.Trim())
                ary.Add(String.Format("[批准时间]: {0} => {1}", struOrg.批准时间, 批准时间));

            if (居住地址.Trim() != struOrg.居住地址.Trim())
                ary.Add(String.Format("[居住地址]: {0} => {1}", struOrg.居住地址, 居住地址));

            if (居住状况.Trim() != struOrg.居住状况.Trim())
                ary.Add(String.Format("[居住状况]: {0} => {1}", struOrg.居住状况, 居住状况));

            if (联系电话.Trim() != struOrg.联系电话.Trim())
                ary.Add(String.Format("[联系电话]: {0} => {1}", struOrg.联系电话, 联系电话));

            if (紧急联系人.Trim() != struOrg.紧急联系人.Trim())
                ary.Add(String.Format("[紧急联系人]: {0} => {1}", struOrg.紧急联系人, 紧急联系人));

            if (紧急联系人电话.Trim() != struOrg.紧急联系人电话.Trim())
                ary.Add(String.Format("[紧急联系人电话]: {0} => {1}", struOrg.紧急联系人电话, 紧急联系人电话));

            if (备注.Trim() != struOrg.备注.Trim())
                ary.Add(String.Format("[备注]: {0} => {1}", struOrg.备注, 备注));

            if (填表人.Trim() != struOrg.填表人.Trim())
                ary.Add(String.Format("[填表人]: {0} => {1}", struOrg.填表人, 填表人));

            if (填表人联系电话.Trim() != struOrg.填表人联系电话.Trim())
                ary.Add(String.Format("[填表人联系电话]: {0} => {1}", struOrg.填表人联系电话, 填表人联系电话));

            if (填表日期.Trim() != struOrg.填表日期.Trim())
                ary.Add(String.Format("[填表日期]: {0} => {1}", struOrg.填表日期, 填表日期));


            foreach (string str in ary)
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }

    }
}