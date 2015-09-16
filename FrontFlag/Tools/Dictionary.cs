//=================================================================================
//  参数字典类。
//  2008-05-07 
//
//=================================================================================


/*
字典表一定要用下面的结构建立：
 
CREATE TABLE [dbo].[_Dict] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Name] [nvarchar] (64) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[OrderNo] [int] NOT NULL ,
	[ParentID] [int] NOT NULL 
    [ExParam] [nvarchar] (128) COLLATE Chinese_PRC_CI_AS NOT NULL ,
) 
*/

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using FrontFlag.Test.BLLFUN;

namespace FrontFlag
{

    public class XDictionary
    {
        DIC_TAB Tab = new DIC_TAB();
        CONNECT Conn = new CONNECT();
        DIC_BLL Bll = new DIC_BLL();

        #region Private

        /// <summary>
        /// 查找指定Type的ID.
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strParenID"></param>
        /// <returns></returns>
        string GetPahtID( string strName, string strParenID )
        {
            SQL Sql = new SQL( CONNECT.SqlConnect );

            string strRet = "";

            string strSql = String.Format( "select {0} from {1} where {2}='{3}' and {4}='{5}' ", Tab.ID, Tab.TAB, Tab.Name, strName, Tab.ParentID, strParenID );

            DataTable dt = Sql.ExecDataTable( strSql );

            if( SQL.IsValid( ref dt ) )
            {
                strRet = dt.Rows[0][Tab.ID].ToString().Trim();
            }

            Sql.Close();

            return strRet;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strID"></param>
        /// <returns></returns>
        DIC_STRU GetStru_ByID( string strID )
        {
            SQL Sql = new SQL( CONNECT.SqlConnect );

            string strRet = "";

            string strSql = String.Format( "select * from {1} where {2}='{3}' ", Tab.ID, Tab.TAB, Tab.ID, strID );

            DataTable dt = Sql.ExecDataTable( strSql );
            Sql.Close();

            if( !SQL.IsValid( ref dt ) )
                return null;

            DIC_STRU stru = new DIC_STRU();

            DataRow dr = dt.Rows[0];
            stru.Dr2Stru( dr );

            return stru;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strParenID"></param>
        /// <returns></returns>
        DIC_STRU GetChildStru( string strName, string strParenID )
        {
            SQL Sql = new SQL( CONNECT.SqlConnect );

            string strRet = "";

            string strSql = String.Format( "select * from {1} where {2}='{3}' and {4}='{5}' ", Tab.ID, Tab.TAB, Tab.Name, strName, Tab.ParentID, strParenID );

            DataTable dt = Sql.ExecDataTable( strSql );
            Sql.Close();

            if( !SQL.IsValid( ref dt ) )
                return null;

            DIC_STRU stru = new DIC_STRU();

            DataRow dr = dt.Rows[0];
            stru.Dr2Stru( dr );

            return stru;
        }

        string GetPahtID( string strName, string strParenID, string strDB )
        {
            SQL Sql = new SQL( CONNECT.SqlConnect );
            //SQL Sql = new SQL ( CR.Param.MainSql.GetConnectStr ( strDB ) );

            string strRet = "";

            string strSql = String.Format( "select {0} from {1} where {2}='{3}' and {4}='{5}'  ", Tab.ID, Tab.TAB, Tab.Name, strName, Tab.ParentID, strParenID );

            DataTable dt = Sql.ExecDataTable( strSql );

            if( SQL.IsValid( ref dt ) )
            {
                strRet = dt.Rows[0][Tab.ID].ToString().Trim();
            }

            Sql.Close();
            return strRet;
        }

        DIC_STRU CreatePath( string strFullPath )
        {
            string[] strs = strFullPath.Split( new char[] { '/', '\\' } );
            if( strs.Length <= 0 )
                return null;

            DIC_STRU stru = new DIC_STRU();
            DIC_STRU struRoot = new DIC_STRU();
            string strPath = String.Empty;

            int n = 0;
            foreach( string str in strs )
            {
                if( n > 0 )
                    strPath += "/";
                strPath += str;

                stru = GetStru_ByPath( strPath );
                if( stru == null )
                {
                    if( n == 0 )
                        stru = AddRoot( strPath );
                    else
                        stru = AddSubRoot( struRoot, str );
                }

                if( stru == null )
                    return null;

                struRoot = stru;

                n++;
            }

            return stru;
        }

        #endregion

        #region Public

        public void SetSQLConnect( string strSqlConnect, string strTableName )
        {
            Conn.SetSqlCon( strSqlConnect );
            Tab.TAB = strTableName;
            Bll.TableName = strTableName;
        }

        public void SetAccessConnect( string strTablePath, string strTablePwd, string strTableName )
        {
            Conn.SetAccessCon( strTablePath, strTablePwd );
            Tab.TAB = strTableName;
            Bll.TableName = strTableName;
        }

        public DIC_STRU GetRootStru( string strName )
        {
            return GetChildStru( strName, "0" );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strFullPath">
        /// 参数路径名称。支持 "a/b/c"或"a\b\c" 表达式，定义参数的唯一，完整路径。
        /// </param>
        /// <returns>
        /// 返回 所有参数的字串数组。
        /// null=没有找到任何参数。
        /// </returns>
        public string[] GetValues_ByPath( string strFullPath )
        {
            string[] strsRet = null;

            //开始查找父ID是strParentID的参数。
            List<DIC_STRU> list = GetAll_ByPath( strFullPath );

            if( list == null || list.Count <= 0 )
                return null;

            strsRet = new string[list.Count];
            int i = 0;
            foreach( DIC_STRU stru in list )
            {
                strsRet[i++] = stru.Name;
            }

            return strsRet;
        }

        /// <summary>
        /// 用于获取只有一个子项的内容。
        /// </summary>
        /// <param name="strFullPath"></param>
        /// <returns></returns>
        public string GetFirstValues_ByPath( string strFullPath )
        {
            string strRet = "";
            string[] strsRet = GetValues_ByPath( strFullPath );
            if( strsRet != null && strsRet.Length >= 1 )
                strRet = strsRet[0];

            return strRet;
        }

        /// <summary>
        /// 找到指定path本身的记录
        /// </summary>
        /// <param name="strFullPath">
        /// 参数路径名称。支持 "a/b/c"或"a\b\c" 表达式，定义参数的唯一，完整路径。
        /// </param>
        /// <returns></returns>
        public DIC_STRU GetStru_ByPath( string strFullPath )
        {
            char[] chs = { '/', '\\' };
            string[] strsPath = strFullPath.Split( chs );
            if( strsPath == null || strsPath.Length <= 0 )
                return null;

            string strParentID = "0";   //目前是根路径

            //从左往右，依次遍历path，一直找到最右（即最后）一个Path的ID。
            foreach( string strPath in strsPath )
            {
                //获取 Child 的ID。
                strParentID = GetPahtID( strPath, strParentID );  //因为不同深度的参数会有同名的，所以要加ParentID， 确保唯一性。
            }

            if( strParentID.Trim() == String.Empty )
                return null;

            DIC_STRU stru = GetStru_ByID( strParentID );
            return stru;
        }

        /// <summary>
        /// 找到指定path下面的所有的子记录
        /// </summary>
        /// <param name="strFullPath">
        /// 参数路径名称。支持 "a/b/c"或"a\b\c" 表达式，定义参数的唯一，完整路径。
        /// </param>
        /// <returns>
        /// 返回 所有参数的字串数组。
        /// null=没有找到任何参数。
        /// </returns>
        public List<DIC_STRU> GetAll_ByPath( string strFullPath )
        {
            string[] strsRet = null;

            char[] chs = { '/', '\\' };
            string[] strsPath = strFullPath.Split( chs );
            if( strsPath == null || strsPath.Length <= 0 )
                return null;

            string strParentID = "0";   //目前是根路径

            //从左往右，依次遍历path，一直找到最右（即最后）一个Path的ID。
            foreach( string strPath in strsPath )
            {
                //获取 Child 的ID。
                strParentID = GetPahtID( strPath, strParentID );  //因为不同深度的参数会有同名的，所以要加ParentID， 确保唯一性。
            }

            if( strParentID.Trim() == String.Empty )
                return null;

            //开始查找父ID是strParentID的参数。
            List<DIC_STRU> list = GetAllChild( strParentID );

            return list;
        }

        public DIC_STRU GetFirst_ByPath( string strFullPath )
        {
            List<DIC_STRU> lst = GetAll_ByPath( strFullPath );
            if( lst == null || lst.Count <= 0 )
                return null;

            return lst[0];
        }

        public DIC_STRU Get_ByID( string strID )
        {
            if( strID.Trim() == String.Empty )
                return null;

            SQL Sql = new SQL( CONNECT.SqlConnect );

            List<DIC_STRU> list = new List<DIC_STRU>();

            string strSql = String.Format( "select * from {0} where {1}='{2}' ", Tab.TAB, Tab.ID, strID );

            DataTable dt = Sql.ExecDataTable( strSql );
            list = DIC_STRU.Dt2List( ref dt );

            Sql.Close();

            if( list == null || list.Count <= 0 )
                return null;

            return list[0];
        }

        /// <summary>
        /// 通过父ID之下的全部子项。
        /// </summary>
        /// <param name="strParentID"></param>
        /// <returns></returns>
        public List<DIC_STRU> GetAll_ByParentID( string strParentID )
        {
            if( strParentID.Trim() == String.Empty )
                return null;

            //开始查找父ID是strParentID的参数。
            List<DIC_STRU> list = GetAllChild( strParentID );

            return list;
        }

        /// <summary>
        /// 获取父路径下的所有子参数。
        /// </summary>
        /// <param name="strParenID"></param>
        /// <returns></returns>
        public List<DIC_STRU> GetAllChild( string strParenID )
        {
            SQL Sql = new SQL( CONNECT.SqlConnect );

            List<DIC_STRU> list = new List<DIC_STRU>();

            string strSql = String.Format( "select * from {0} where {1}='{2}' order by {3} ", Tab.TAB, Tab.ParentID, strParenID, Tab.OrderNo );

            DataTable dt = Sql.ExecDataTable( strSql );
            list = DIC_STRU.Dt2List( ref dt );

            Sql.Close();

            return list;
        }

        #region OrderNo

        /// <summary>
        /// 查找所有子项中最大的序号。
        /// </summary>
        /// <param name="strParenID"></param>
        /// <returns></returns>
        public int GetChildMaxNo( string strParenID )
        {
            SQL Sql = new SQL( CONNECT.SqlConnect );

            List<DIC_STRU> list = new List<DIC_STRU>();

            string strSql = String.Format( "select * from {0} where {1}='{2}' order by {3} desc ", Tab.TAB, Tab.ParentID, strParenID, Tab.OrderNo );

            DataTable dt = Sql.ExecDataTable( strSql );
            list = DIC_STRU.Dt2List( ref dt );

            Sql.Close();

            if( list == null || list.Count <= 0 )
                return 0;

            int nNo = FF.Fun.MyConvert.Str2Int( list[0].OrderNo );
            return nNo;
        }

        public DIC_STRU GetPreChild( DIC_STRU stru )
        {
            if( !stru.IsValid() )
                return null;

            string strParenID = stru.ParentID;
            if( strParenID == String.Empty )
                return null;

            string strCurNo = stru.OrderNo;

            SQL Sql = new SQL( CONNECT.SqlConnect );

            List<DIC_STRU> list = new List<DIC_STRU>();

            string strSql = String.Format( "select top 1 * from {0} where {1}='{2}' and {3}<{4} order by {3} desc ", Tab.TAB, Tab.ParentID, strParenID, Tab.OrderNo, strCurNo );

            DataTable dt = Sql.ExecDataTable( strSql );
            list = DIC_STRU.Dt2List( ref dt );

            Sql.Close();

            if( list == null || list.Count <= 0 )
                return null;

            return list[0];
        }

        public DIC_STRU GetNextChild( DIC_STRU stru )
        {
            if( !stru.IsValid() )
                return null;

            string strParenID = stru.ParentID;
            if( strParenID == String.Empty )
                return null;

            string strCurNo = stru.OrderNo;

            SQL Sql = new SQL( CONNECT.SqlConnect );

            List<DIC_STRU> list = new List<DIC_STRU>();

            string strSql = String.Format( "select top 1 * from {0} where {1}='{2}' and {3}>{4} order by {3} ", Tab.TAB, Tab.ParentID, strParenID, Tab.OrderNo, strCurNo );

            DataTable dt = Sql.ExecDataTable( strSql );
            list = DIC_STRU.Dt2List( ref dt );

            Sql.Close();

            if( list == null || list.Count <= 0 )
                return null;

            return list[0];
        }

        /// <summary>
        /// 把一个子项的序号往前移动。
        /// </summary>
        /// <param name="struCur"></param>
        /// <returns></returns>
        public bool ChildMove2Pre( DIC_STRU struCur )
        {
            DIC_STRU struPre = GetPreChild( struCur );
            if( struPre == null )
                return false;

            string strTmp = struPre.OrderNo;
            struPre.OrderNo = struCur.OrderNo;
            struCur.OrderNo = strTmp;

            Save( struCur );
            Save( struPre );

            return true;
        }

        public bool ChildMove2Pre( string strID )
        {
            DIC_STRU stru = Get_ByID( strID );
            return ChildMove2Pre( stru );
        }

        /// <summary>
        /// 把一个子项的序号往后移动。
        /// </summary>
        /// <param name="struCur"></param>
        /// <returns></returns>
        public bool ChildMove2Next( DIC_STRU struCur )
        {
            DIC_STRU struPre = GetNextChild( struCur );
            if( struPre == null )
                return false;

            string strTmp = struPre.OrderNo;
            struPre.OrderNo = struCur.OrderNo;
            struCur.OrderNo = strTmp;

            Save( struCur );
            Save( struPre );

            return true;
        }

        public bool ChildMove2Next( string strID )
        {
            DIC_STRU stru = Get_ByID( strID );
            return ChildMove2Next( stru );
        }

        #endregion

        public string Save( DIC_STRU stru )
        {
            return Bll.Save( stru );
        }
        public bool Save( List<DIC_STRU> list )
        {
            return Bll.Save( list );
        }

        public void Delete( DIC_STRU stru )
        {
            Bll.Delete( stru );
        }
        public void Delete( string strID )
        {
            DIC_STRU stru = Get_ByID( strID );
            Bll.Delete( stru );
        }
        public void Delete( List<DIC_STRU> list )
        {
            Bll.Delete( list );
        }

        public DIC_STRU AddRoot( string strRootName, string strRemark )
        {
            DIC_STRU stru = new DIC_STRU();
            stru.SetRoot( strRootName, strRemark );
            stru.ID = Save( stru );
            return stru;
        }
        public DIC_STRU AddRoot( string strRootName )
        {
            return AddRoot( strRootName, "" );
        }

        public DIC_STRU AddSubRoot( DIC_STRU struRoot, string strName, string strRemark )
        {
            if( struRoot.ID.Trim() == String.Empty )
                return null;

            List<DIC_STRU> lst = GetAllChild( struRoot.ID );
            int nNo = lst.Count + 1;

            DIC_STRU stru = new DIC_STRU();
            stru.SetSubRoot( struRoot.ID, strName, nNo, strRemark );
            stru.ID = Save( stru );
            return stru;
        }
        public DIC_STRU AddSubRoot( DIC_STRU struRoot, string strName )
        {
            return AddSubRoot( struRoot, strName, "" );
        }

        public DIC_STRU AddChild( DIC_STRU struRoot, string strName, string strRemark )
        {
            if( struRoot == null || struRoot.ID.Trim() == String.Empty )
                return null;

            int nNo = GetChildMaxNo( struRoot.ID ) + 1;

            DIC_STRU stru = new DIC_STRU();
            stru.SetChild( struRoot.ID, strName, nNo, strRemark );
            stru.ID = Save( stru );
            return stru;
        }
        public DIC_STRU AddChild( DIC_STRU struRoot, string strName )
        {
            return AddChild( struRoot, strName, "" );
        }

        /// <summary>
        /// 一次添加多个子项目。
        /// </summary>
        /// <param name="struRoot"></param>
        /// <param name="strsName"></param>
        public void AddChildStrs( DIC_STRU struRoot, string[] strsName )
        {
            foreach( string strName in strsName )
            {
                AddChild( struRoot, strName, "" );
            }
        }

        public DIC_STRU AddChild( string strParenID, string strName )
        {
            DIC_STRU struParent = FF.Dictionary.Get_ByID( strParenID );
            return AddChild( struParent, strName );
        }

        private bool isExist( string strFullPath, string strValue , ref DIC_STRU struFind )
        {
            struFind = new DIC_STRU();

            List<DIC_STRU> listAll = GetAll_ByPath( strFullPath );
            foreach ( DIC_STRU stru in listAll )
            {
                if (stru.Name == strValue)
                {
                    struFind = stru;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 只是追加 新子项，不删除旧有的子项。
        /// </summary>
        /// <param name="strFullPath"></param>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public DIC_STRU Append( string strFullPath, string strValue )
        {
            DIC_STRU struFind = new DIC_STRU();
            if ( isExist( strFullPath, strValue, ref struFind ) )
                return struFind;

            DIC_STRU struParent = CreateNode( strFullPath );
            return AddChild( struParent, strValue );
        }

        public void Append(string strFullPath, List<string> lstValue)
        {
            foreach ( string strValue in lstValue )
            {
                Append(strFullPath, strValue);
            }
        }

        private DIC_STRU CreateNode(string strFullPath)
        {
            DIC_STRU struRoot = GetStru_ByPath( strFullPath );

            //如果路径不存在，会先自动建立好路径。
            //如果路径只有一部分不存在，则只添加后半部分路径。前半部分路径不受影响。
            if ( struRoot == null )
            {
                //新建路径
                CreatePath( strFullPath );
                struRoot = GetStru_ByPath( strFullPath );
            }

            return struRoot;
        }

        /// <summary>
        /// 建议使用此函数。
        /// 路径不存在会自定建立。
        /// 会自动添加新项，删除多余的项。（注意！！！）
        /// </summary>
        /// <param name="strFullPath"></param>
        /// <param name="listStrs"></param>
        public void Update( string strFullPath, List<string> listStrs )
        {
            List<string> listOrg = CopyList( listStrs );

            //DIC_STRU struRoot = GetStru_ByPath( strFullPath );

            ////如果路径不存在，会先自动建立好路径。
            ////如果路径只有一部分不存在，则只添加后半部分路径。前半部分路径不受影响。
            //if( struRoot == null )
            //{
            //    //新建路径
            //    CreatePath( strFullPath );
            //    struRoot = GetStru_ByPath( strFullPath );
            //}

            DIC_STRU struRoot = CreateNode( strFullPath );

            List<DIC_STRU> listDelete = new List<DIC_STRU>();

            List<DIC_STRU> listAll = GetAll_ByPath( strFullPath );
            if( listAll == null )
                return;

            foreach( DIC_STRU stru in listAll )
            {
                string strName = stru.Name;

                //是否要删除
                if( !listStrs.Contains( strName ) )
                    listDelete.Add( stru );
                else
                    listStrs.Remove( strName );   //List<string>去掉Dictionary中已有的项，剩下的就是要新加进Dictionary的项
            }

            //删除
            foreach( DIC_STRU stru in listDelete )
                Delete( stru );

            //新加
            foreach( string strName in listStrs )
                AddChild( struRoot, strName );

            //排序
            SetOrder( strFullPath, listOrg );
        }

        #endregion

        #region Single String Fun

        public string GetString_ByPath( string strFullPath )
        {
            return GetFirstValues_ByPath( strFullPath );
        }

        public void SetString_ByPath( string strFullPath, string strVal )
        {
            List<string> listStrs = new List<string>();
            listStrs.Add( strVal );

            Update( strFullPath, listStrs );
        }

        #endregion

        #region List Fun

        public List<string> GetValuesList_ByPath( string strFullPath )
        {
            List<string> lst = new List<string>();

            string[] strs = GetValues_ByPath( strFullPath );
            if( strs == null )
                return lst;

            foreach( string str in strs )
            {
                lst.Add( str );
            }
            return lst;
        }

        //string GetRootStr ( string strFullPath )
        //{
        //    string strRoot = String.Empty;

        //    string[] strs = strFullPath.Split(new char[] {'/'});
        //    if (strs.Length > 0)
        //        strRoot = strs[0];

        //    return strRoot;
        //}

        int GetIndexFromList( List<string> listStrs, string strItem )
        {
            int index = -1;

            foreach( string str in listStrs )
            {
                index++;

                if( str == strItem )
                    return index;
            }

            return index;
        }

        public void SetOrder( string strFullPath, List<string> listStrs )
        {
            List<DIC_STRU> listAll = GetAll_ByPath( strFullPath );
            foreach( DIC_STRU stru in listAll )
            {
                string strName = stru.Name;
                int nIndex = GetIndexFromList( listStrs, strName );
                stru.OrderNo = nIndex.ToString();
            }

            Save( listAll );
        }

        List<string> CopyList( List<string> listOrg )
        {
            List<string> lstRet = new List<string>();
            foreach( string str in listOrg )
            {
                lstRet.Add( str );
            }
            return lstRet;
        }

        #endregion


    }

    ////用于定义字典是哪种数据库。
    //static class CONNECT_TYPE
    //{
    //    static public string SQL = "SQL";
    //    static public string ACCESS = "ACCESS";
    //}

    class CONNECT
    {
        //public CONNECT_TYPE ConType = new CONNECT_TYPE ();
        string strConType = "";

        //for SQL
        static string _strSqlConnect = "";
        static public string SqlConnect
        {
            get { return _strSqlConnect; }
        }

        //for Access
        string _strTablePath = "";
        string _strstrTablePwd = "";


        /// <summary>
        /// 连接 SQL 数据库。
        /// </summary>
        ///// <param name="strConnectType"></param>
        /// <param name="strSqlConnect"></param>
        ///// <param name="strTableName"></param>
        public void SetSqlCon( string strSqlConnect )
        {
            //if (strConnectType == CONNECT_TYPE.SQL)
            //{
            //strConType = CONNECT_TYPE.SQL; // CONNECT_TYPE.SQL;
            _strSqlConnect = strSqlConnect;
            //Tab.TAB = strTableName;
            //}
        }

        /// <summary>
        /// 连接 Access 数据库
        /// </summary>
        ///// <param name="strType"></param>
        /// <param name="strTablePath"></param>
        /// <param name="strTablePwd"></param>
        ///// <param name="strTableName"></param>
        public void SetAccessCon( string strTablePath, string strTablePwd )
        {
            //if (strType == CONNECT_TYPE.ACCESS)
            //{
            //strConType = CONNECT_TYPE.ACCESS; //CONNECT_TYPE.ACCESS;
            _strTablePath = strTablePath;
            _strstrTablePwd = strTablePwd;
            //TabName = strTableName;
            //}
        }

    }

    public class DIC_TAB
    {
        public string TAB = "";

        public string ID = "ID";
        public string Name = "Name";
        public string OrderNo = "OrderNo";
        public string ParentID = "ParentID";
        public string ExParam = "ExParam";

    }

    public class DIC_STRU
    {
        DIC_TAB Tab = new DIC_TAB();

        public string ID { set; get; }
        public string Name { set; get; }
        public string OrderNo { set; get; }
        public string ParentID { set; get; }
        public string ExParam { set; get; }

        public DIC_STRU()
        {
            Clear();
        }

        public DIC_STRU( string strRootName )
        {
            Clear();
            SetRoot( strRootName );
        }

        public DIC_STRU( string strParentID, string strChildName, int nNo )
        {
            Clear();
            SetChild( strParentID, strChildName, nNo );
        }

        private void Clear()
        {
            ID = string.Empty;
            Name = string.Empty;
            OrderNo = string.Empty;
            ParentID = string.Empty;
            ExParam = string.Empty;
        }

        public bool IsValid()
        {
            return ( ID.Trim() == String.Empty ) ? false : true;
        }

        public bool Dr2Stru( DataRow dr )
        {
            Clear();

            if( dr == null )
                return false;

            ID = dr[Tab.ID].ToString().Trim();
            Name = dr[Tab.Name].ToString().Trim();
            OrderNo = dr[Tab.OrderNo].ToString().Trim();
            ParentID = dr[Tab.ParentID].ToString().Trim();
            ExParam = dr[ Tab.ExParam ].ToString().Trim();

            return true;
        }

        public static List<DIC_STRU> Dt2List( ref DataTable dt )
        {
            List<DIC_STRU> lst = new List<DIC_STRU>();

            if( SQL.IsNotValid( ref dt ) )
                return lst;

            foreach( DataRow dr in dt.Rows )
            {
                DIC_STRU stru = new DIC_STRU();
                stru.Dr2Stru( dr );
                lst.Add( stru );
            }

            return lst;
        }

        public void Stru2Dr( ref DataRow dr )
        {
            if( ID.Trim() != String.Empty )
                dr[Tab.ID] = ID;

            if (String.IsNullOrEmpty(OrderNo))
                OrderNo = "0";

            dr[Tab.Name] = Name;
            dr[Tab.OrderNo] = OrderNo;
            dr[Tab.ParentID] = ParentID;
            dr[ Tab.ExParam ] = ExParam;
        }

        static public List<DIC_STRU> Table2List( ref DataTable dt )
        {
            List<DIC_STRU> list = new List<DIC_STRU>();

            if( SQL.IsNotValid( ref dt ) )
                return list;

            foreach( DataRow dr in dt.Rows )
            {
                DIC_STRU stru = new DIC_STRU();
                stru.Dr2Stru( dr );
                list.Add( stru );
            }

            return list;
        }

        #region Fun

        public void SetRoot( string strRootName, string exparam )
        {
            Name = strRootName;
            OrderNo = "0";
            ParentID = "0";
            ExParam = exparam;
        }
        public void SetRoot( string strRootName )
        {
            SetRoot( strRootName, "" );
        }

        public void SetSubRoot( string strParentID, string strRootName, int nNo, string exparam )
        {
            Name = strRootName;
            OrderNo = nNo.ToString();
            ParentID = strParentID;
            ExParam = exparam;
        }
        public void SetSubRoot( string strParentID, string strRootName, int nNo )
        {
            SetSubRoot( strParentID, strRootName, nNo, "" );
        }

        public void SetChild( string strParentID, string strChildName, int nNo, string exparam )
        {
            Name = strChildName;
            OrderNo = nNo.ToString();
            ParentID = strParentID;
            ExParam = exparam;
        }
        public void SetChild( string strParentID, string strChildName, int nNo )
        {
            SetChild( strParentID, strChildName, nNo );
        }

        #endregion

    }

    public class DIC_ORM
    {
        DIC_TAB Tab = new DIC_TAB();

        public string TableName
        {
            set { Tab.TAB = value; }
            get { return Tab.TAB; }
        }

        public DataTable GetWhere( string strWhere )
        {
            DataTable dt = new DataTable();

            FrontFlag.SQL sql = new SQL( CONNECT.SqlConnect );

            if( strWhere.Trim() != "" )
                strWhere = " Where " + strWhere;

            string strSql = String.Format( "select * from {0} {1} order by ID desc", Tab.TAB, strWhere );
            dt = sql.ExecDataTable( strSql );

            sql.Close();

            return dt;

        }

        public DataTable GetBlank()
        {
            SQL Sql = new SQL( CONNECT.SqlConnect );
            DataTable dt = Sql.GetBlankDt( Tab.TAB );
            Sql.Close();
            return dt;
        }

        public string Save( DataTable dt )
        {
            if( !SQL.IsValid( ref dt ) )
                return "";

            SQL Sql = new SQL( CONNECT.SqlConnect );

            string strID = Sql.Save( ref dt );

            Sql.Close();

            return strID;
        }

        public string Save( DIC_STRU stru )
        {
            DataTable dt = GetBlank();
            DataRow dr = dt.Rows[0];
            stru.Stru2Dr( ref dr );

            SQL Sql = new SQL( CONNECT.SqlConnect );

            string strID = Sql.Save( ref dt );

            Sql.Close();

            return strID;
        }

        public void Delete_ByID( string strID )
        {
            if( strID.Trim() == "" )
                return;

            SQL Sql = new SQL( CONNECT.SqlConnect );

            string strSql = String.Format( "delete from {0} where {1}='{2}'", Tab.TAB, Tab.ID, strID );
            Sql.Exec( strSql );

            Sql.Close();

            return;
        }
    }

    public class DIC_BLL
    {
        DIC_ORM Orm = new DIC_ORM();

        public string TableName
        {
            set { Orm.TableName = value; }
            get { return Orm.TableName; }
        }

        public List<DIC_STRU> Get_ByWhere( string strWhere )
        {
            DataTable dt = Orm.GetWhere( strWhere );

            if( SQL.IsNotValid( ref dt ) )
                return null;

            List<DIC_STRU> lst = new List<DIC_STRU>();
            lst = DIC_STRU.Dt2List( ref dt );

            return lst;
        }

        public string Save( DIC_STRU stru )
        {
            if( stru.Name.Trim() == "" )
                return "";

            return Orm.Save( stru );
        }

        public bool Save( List<DIC_STRU> list )
        {
            if( list == null || list.Count <= 0 )
                return false;

            string strParentID = list[0].ParentID;

            int nOrder = 0;
            bool bRet = true;

            foreach( DIC_STRU stru in list )
            {
                if( String.IsNullOrEmpty( stru.OrderNo ) )
                    stru.OrderNo = ( nOrder++ ).ToString();
                stru.ParentID = strParentID;

                bRet &= ( Orm.Save( stru ) == "" ) ? false : true;
            }

            return bRet;
        }

        public void Delete_ByID( string strID )
        {
            if( strID.Trim() == "" )
                return;

            Orm.Delete_ByID( strID );
        }

        public void Delete( DIC_STRU stru )
        {
            Delete_ByID( stru.ID );
        }

        public void Delete( List<DIC_STRU> list )
        {
            if( list == null || list.Count <= 0 )
                return;

            foreach( DIC_STRU stru in list )
            {
                Delete( stru );
            }
        }
    }

}
