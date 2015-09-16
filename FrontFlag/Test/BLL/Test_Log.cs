using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;

using FrontFlag;
//using Core;

namespace FrontFlag.Test.BLLFUN
{
    public class TEST_LOG
    {
        ORM.TEST_LOG Test_log = new ORM.TEST_LOG();


        public DataTable GetBlank()
        {
            return Test_log.GetBlank();
        }

        public List<FrontFlag.Test.Stru.TEST_LOG> Get_ByWhere(string strWhere)
        {
            List<FrontFlag.Test.Stru.TEST_LOG> lst = new List<FrontFlag.Test.Stru.TEST_LOG>();

            DataTable dt = Test_log.GetWhere(strWhere);

            if (SQL.IsNotValid(ref dt))
                return lst;

            lst = FrontFlag.Test.Stru.TEST_LOG.Dt2List(ref dt);

            return lst;
        }

        public FrontFlag.Test.Stru.TEST_LOG GetFirst_ByWhere(string strWhere)
        {
            FrontFlag.Test.Stru.TEST_LOG stru = new FrontFlag.Test.Stru.TEST_LOG();
            List<FrontFlag.Test.Stru.TEST_LOG> list = Get_ByWhere(strWhere);

            if (list != null && list.Count > 0)
                stru = list[0];

            return stru;
        }

        public FrontFlag.Test.Stru.TEST_LOG Get_ByID(string strID)
        {
            string strWhere = String.Format("{0}='{1}'", Tab.TEST_LOG.ID, strID);
            return GetFirst_ByWhere(strWhere);
        }

        #region Split to Page

        //Get one Page data from all 
        public List<FrontFlag.Test.Stru.TEST_LOG> GetPage(int nPageNo, string strWhere)
        {
            List<FrontFlag.Test.Stru.TEST_LOG> lst = new List<FrontFlag.Test.Stru.TEST_LOG>();

            DataTable dt = Test_log.GetPage(nPageNo, strWhere);

            if (SQL.IsNotValid(ref dt))
                return lst;

            lst = FrontFlag.Test.Stru.TEST_LOG.Dt2List(ref dt);

            return lst;
        }

        //Get Page Number  
        public int GetPageMax(string strWhere)
        {
            return Test_log.GetPageMax(strWhere);
        }

        #endregion

        //Save
        public string Save(ref DataTable dt)
        {
            string strID = Test_log.Save(ref dt);
            return strID;
        }

        public string Save(FrontFlag.Test.Stru.TEST_LOG stru)
        {
            string strID = Test_log.Save(stru);
            return strID;
        }

        public bool Save(List<FrontFlag.Test.Stru.TEST_LOG> lst)
        {
            bool bRet = true;
            string strID;
            foreach (FrontFlag.Test.Stru.TEST_LOG stru in lst)
            {
                strID = Save(stru);
                bRet &= (strID == "") ? false : true;
            }
            return bRet;
        }

        //Delete
        public void Delete(FrontFlag.Test.Stru.TEST_LOG stru)
        {
            Test_log.Delete_ByID(stru.ID);
        }

        public void Delete(List<string> lstDel)
        {
            foreach (string strID in lstDel)
                Test_log.Delete_ByID(strID);
        }

        public void Delete(List<FrontFlag.Test.Stru.TEST_LOG> lst)
        {
            foreach (FrontFlag.Test.Stru.TEST_LOG stru in lst)
                Test_log.Delete_ByID(stru.ID);
        }

        #region Fun

        public void Save ( string strClass, string strFun, string strEvent , string strMsg )
        {
            FrontFlag.Test.Stru.TEST_LOG stru = new Stru.TEST_LOG();
            stru.ClassName = strClass;
            stru.FunName = strFun;
            stru.Event = strEvent;
            stru.Message = strMsg;
            Save( stru );
        }

        public void Save(string strClass, string strFun, string strMsg)
        {
            Save( strClass, strFun, "-" , strMsg  );
        }

        public void Save(string strClass, string strMsg)
        {
            Save(strClass, "-", "-", strMsg);
        }

        public void Save(string strMsg)
        {
            Save("-", "-", "-", strMsg);
        }

        #endregion
    }


}


