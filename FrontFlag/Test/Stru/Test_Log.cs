using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;

namespace FrontFlag.Test.Stru
{
    public class TEST_LOG
    {
        string _ID = "";
        string _CreateDate = "";
        string _ClassName = "";
        string _FunName = "";
        string _Event = "";
        string _Message = "";


        #region ??

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
        public string CreateDateStr
        {
            get { return FF.Fun.MyConvert.Str2Date(_CreateDate).ToString("yyyy-MM-dd"); }
        }

        public string ClassName
        {
            set { _ClassName = value; }
            get { return _ClassName; }
        }

        public string FunName
        {
            set { _FunName = value; }
            get { return _FunName; }
        }

        public string Event
        {
            set { _Event = value; }
            get { return _Event; }
        }

        public string Message
        {
            set { _Message = value; }
            get { return _Message; }
        }


        public string CombinStr
        {
            set
            {
                string strRet = value;
                char[] chs = new char[] { '|' };
                string[] strs = strRet.Split(chs);
                if (strs == null || strs.Length < 6)
                    return;

                ID = strs[0];
                CreateDate = strs[1];
                ClassName = strs[2];
                FunName = strs[3];
                Event = strs[4];
                Message = strs[5];
            }

            get
            {
                string strRet = "";
                strRet += ID + "|";
                strRet += CreateDate + "|";
                strRet += ClassName + "|";
                strRet += FunName + "|";
                strRet += Event + "|";
                strRet += Message + "|";
                return strRet;
            }
        }

        #endregion


        void Clear()
        {
            ID = "";
            CreateDate = "";
            ClassName = "";
            FunName = "";
            Event = "";
            Message = "";
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

            ID = dr[Tab.TEST_LOG.ID].ToString().Trim();
            CreateDate = dr[Tab.TEST_LOG.CreateDate].ToString().Trim();
            ClassName = dr[Tab.TEST_LOG.ClassName].ToString().Trim();
            FunName = dr[Tab.TEST_LOG.FunName].ToString().Trim();
            Event = dr[Tab.TEST_LOG.Event].ToString().Trim();
            Message = dr[Tab.TEST_LOG.Message].ToString().Trim();

            return true;
        }

        public static List<Stru.TEST_LOG> Dt2List(ref DataTable dt)
        {
            List<Stru.TEST_LOG> lst = new List<TEST_LOG>();

            if (SQL.IsNotValid(ref dt))
                return lst;

            foreach (DataRow dr in dt.Rows)
            {
                Stru.TEST_LOG stru = new TEST_LOG();
                stru.Dr2Stru(dr);
                lst.Add(stru);
            }

            return lst;
        }

        public static DataTable List2Dt(ref List<Stru.TEST_LOG> lst)
        {
            ORM.TEST_LOG orm = new ORM.TEST_LOG();
            DataTable dt = orm.GetBlank();

            foreach (Stru.TEST_LOG o in lst)
            {
                DataRow dr = dt.Rows.Add();
                o.Stru2Dr(ref dr);
            }

            return dt;
        }


        public static Stru.TEST_LOG StruFromList_ByID(ref List<Stru.TEST_LOG> list, string strID)
        {
            if (strID.Trim() == "")
                return null;

            foreach (Stru.TEST_LOG stru in list)
            {
                if (stru.ID == strID)
                    return stru;
            }
            return null;
        }


        public void Stru2Dr(ref DataRow dr)
        {
            if (ID.Trim() != String.Empty)
                dr[Tab.TEST_LOG.ID] = ID;

            if (CreateDate == "")
                CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            dr[Tab.TEST_LOG.CreateDate] = CreateDate;
            dr[Tab.TEST_LOG.ClassName] = ClassName;
            dr[Tab.TEST_LOG.FunName] = FunName;
            dr[Tab.TEST_LOG.Event] = Event;
            dr[Tab.TEST_LOG.Message] = Message;
        }

        /// <summary>
        /// Get Struc main Content
        /// </summary>
        /// <returns></returns>
        public string GetContentStr()
        {
            if (ID == "")
                return "";

            string strRet = "";
            ArrayList ary = new ArrayList();

            ary.Add(String.Format("[ID] : {0} ", ID));
            ary.Add(String.Format("[CreateDate] : {0} ", CreateDate));
            ary.Add(String.Format("[ClassName] : {0} ", ClassName));
            ary.Add(String.Format("[FunName] : {0} ", FunName));
            ary.Add(String.Format("[Event] : {0} ", Event));
            ary.Add(String.Format("[Message] : {0} ", Message));

            foreach (string str in ary)
            {
                strRet += str + System.Environment.NewLine;
            }

            return strRet;
        }
    }
}