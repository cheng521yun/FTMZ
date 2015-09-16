using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DB.Stru.老龄办
{
    partial class 发放老龄津贴
    {
        public int 年龄
        {
            get
            {
                return DateTime.Now.Year - dat出生日期.Year;
            }
        }

        public string 年龄Str
        {
            get
            {
                return 年龄 + "岁";
            }
        }


    }
}
