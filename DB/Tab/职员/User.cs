
/* 
	User : 
	Date :
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Tab
{
    public class USER
    {
        //static public string TAB = "User";    //阿里云SQL数据库不允许使用 User 名称的表
        static public string TAB = "Employee";   

        static public string ID = "ID";
        static public string Code = "Code";
        static public string CreateDate = "CreateDate";
        static public string Creator = "Creator";
        static public string Name = "Name";
        static public string Password = "Password";
        static public string Grander = "Grander";
        static public string Status = "Status";
        static public string Role = "Role";
        public static string Department = "Department";

    }
}
