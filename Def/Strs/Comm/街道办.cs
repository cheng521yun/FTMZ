using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Strs.Comm
{
    public class 所属街道
    {
        //10个街道办
        static public string[] 街道办 = new string[] {"园岭街道办", "南园街道办", "福田街道办", "沙头街道办", "梅林街道办", "华富街道办", "香蜜湖街道办", "莲花街道办", "华强北街道办", "福保街道办"};

        ////工作站
        //public string[] 工作站_园岭街道办 = new string[] { "园东", "红荔", "长城", "南天", "上林", "鹏盛", "华林" };
        //public string[] 工作站_南园街道办 = new string[] { "巴登", "滨江", "南园", "沙埔头", "锦龙", "园西", "南华", "赤尾", "滨河", "东园", "玉田"};
        //public string[] 工作站_福田街道办 = new string[] { "岗厦", "皇岗", "口岸", "福田", "福山", "渔农", "福民", "水围", "海滨", "圩镇", "福安", "福华", "福南" };
        //public string[] 工作站_沙头街道办 = new string[] { "上沙", "下沙", "沙嘴", "沙尾", "新洲", "新沙", "天安", "新华", "金地", "金城", "翠湾", "金碧" };
        //public string[] 工作站_梅林街道办 = new string[] { "新兴", "下梅", "梅京", "孖岭", "上梅", "新阁", "梅林一村", "龙尾", "梅亭", "梅丰", "梅都", "梅河", "翰岭" };
        //public string[] 工作站_华富街道办 = new string[] { "梅岗", "华山", "新田", "田面", "黄木岗", "莲花一村", "莲花二村", "莲花三村" };
        //public string[] 工作站_香蜜湖街道办 = new string[] { "农园", "香安", "竹园", "香梅", "竹林", "香蜜", "香岭", "东海"};
        //public string[] 工作站_莲花街道办 = new string[] { "福中", "福新", "彩虹", "莲花北", "景田", "景华", "紫荆", "梅岭", "狮岭", "康欣", "梅富", "彩田"};
        //public string[] 工作站_华强北街道办 = new string[] { "通新岭", "福强", "荔村", "华红", "华航"};
        //public string[] 工作站_福保街道办 = new string[] { "福保", "石厦", "益田", "明月", "新港" };


        static public string[] Get工作站(string str街道办)
        {
            string[] strsRet = new string[] {String.Empty};
            int nIndex = -1;

            for ( int i = 0 ; i <街道办.Length ; i ++ )
            {
                if (街道办[i] == str街道办)
                {
                    nIndex = i;
                    break;
                }
            }

            if (nIndex == -1)
                return strsRet;

            if ( nIndex >= lst工作站.Count )
                return strsRet;

            strsRet = lst工作站[nIndex];

            return strsRet;
        }

        static private List<string[]> lst工作站 = new List<string[]>()
            {
                //园岭街道办
                new string[] { "园东", "红荔", "长城", "南天", "上林", "鹏盛", "华林" },
                //南园街道办
                new string[] { "巴登", "滨江", "南园", "沙埔头", "锦龙", "园西", "南华", "赤尾", "滨河", "东园", "玉田"},
                //福田街道办
                new string[] { "岗厦", "皇岗", "口岸", "福田", "福山", "渔农", "福民", "水围", "海滨", "圩镇", "福安", "福华", "福南" },
                //沙头街道办
                new string[] { "上沙", "下沙", "沙嘴", "沙尾", "新洲", "新沙", "天安", "新华", "金地", "金城", "翠湾", "金碧" },
                //梅林街道办
                new string[] { "新兴", "下梅", "梅京", "孖岭", "上梅", "新阁", "梅林一村", "龙尾", "梅亭", "梅丰", "梅都", "梅河", "翰岭" },
                //华富街道办
                new string[] { "新兴", "下梅", "梅京", "孖岭", "上梅", "新阁", "梅林一村", "龙尾", "梅亭", "梅丰", "梅都", "梅河", "翰岭" },
                //香蜜湖街道办
                new string[] { "农园", "香安", "竹园", "香梅", "竹林", "香蜜", "香岭", "东海"},
                //莲花街道办
                new string[] { "福中", "福新", "彩虹", "莲花北", "景田", "景华", "紫荆", "梅岭", "狮岭", "康欣", "梅富", "彩田"},
                //华强北街道办
                new string[] { "通新岭", "福强", "荔村", "华红", "华航"},
                //福保街道办
                new string[] { "福保", "石厦", "益田", "明月", "新港" },
            };

    }
}



