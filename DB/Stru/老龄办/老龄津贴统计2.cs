using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DB.Stru.老龄办
{
    partial class 老龄津贴统计
    {
        public bool Dr2Stru_统计( DataRow dr )
        {
            Clear();

            if ( dr == null )
                return false;

            街道 = dr[ DB.Tab.老龄办.老龄津贴统计.街道 ].ToString().Trim();
            年龄段80 = dr[ DB.Tab.老龄办.老龄津贴统计.年龄段80 ].ToString().Trim();
            年龄段90 = dr[ DB.Tab.老龄办.老龄津贴统计.年龄段90 ].ToString().Trim();
            年龄段100 = dr[ DB.Tab.老龄办.老龄津贴统计.年龄段100 ].ToString().Trim();

            return true;
        }

        public static void Set统计月份( List<DB.Stru.老龄办.老龄津贴统计> lst, DateTime dat )
        {
            foreach ( DB.Stru.老龄办.老龄津贴统计 stru in lst )
            {
                stru._统计月份 = dat.ToString("yyyy-MM");
            }
        }
    }
}
