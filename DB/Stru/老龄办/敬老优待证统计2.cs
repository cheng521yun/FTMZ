using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DB.Stru.老龄办
{
    partial class 敬老优待证统计
    {
        public bool Dr2Stru_统计( DataRow dr )
        {
            Clear();

            if ( dr == null )
                return false;

            街道 = dr[ DB.Tab.老龄办.敬老优待证统计.街道 ].ToString().Trim();
            蓝证 = dr[ DB.Tab.老龄办.敬老优待证统计.蓝证 ].ToString().Trim();
            黄证 = dr[ DB.Tab.老龄办.敬老优待证统计.黄证 ].ToString().Trim();
            免费乘车证 = dr[ DB.Tab.老龄办.敬老优待证统计.免费乘车证 ].ToString().Trim();
            合计 = dr[ DB.Tab.老龄办.敬老优待证统计.合计 ].ToString().Trim();

            return true;
        }
    }
}
