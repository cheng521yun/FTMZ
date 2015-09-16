using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Def.Strs.优抚科
{
    public class 优抚对象
    {
        public static string[] 对象类别 = new string[] { "伤残人员",
                                                         "三属", 
                                                         "三红", 
                                                         "在乡复员军人", 
                                                         "带病回乡退伍军人", 
                                                         "参战涉核人员", 
                                                         "60周岁以上农村籍退役人员" ,
                                                         "部分烈士(错杀被平反人员)子女",
                                                         "铀矿开采军队退役人员",
                                                         "港澳老战士和烈属",
                                                         "五老人员"
                                                        };

        public static string[] 伤残人员 = new string[] { "残疾军人", "伤残国家机关工作人员", "伤残人民警察", "伤残民兵民工" };
        public static string[] 三属 = new string[] { "烈士遗属", "因公牺牲军人遗属", "病故军人遗属", "港澳老战士和烈属" };
        public static string[] 三红 = new string[] { "在乡退伍红军老战士", "在乡西路军红军老战士", "红军失散人员" };
        public static string[] 参战涉核人员 = new string[] { "参战退役人员", "原8023部队退役人员", "其他参加核试验退役人员" };
        public static string[] 部分烈士_错杀被平反人员__子女 = new string[] { "部分60周岁以上烈士子女", "部分60周岁以上错杀被平反人员子女" };
        public static string[] 港澳老战士和烈属 = new string[] { "港澳老战士", "港澳烈属" };
        public static string[] 五老人员 = new string[] { "老游击队员", "老党员", "老交通员", "老苏区干部", "老堡垒户" };

        //伤残人员
        public static string[] 涉核情况 = new string[] { "无", "原8023", "其他涉核" };
        public static string[] 伤残时期 = new string[] { "抗日战争", "解放战争", "建国后" };
        public static string[] 伤残等级 = new string[] {  "一级", "二级", "三级", "四级", "五级", "六级", "七级", "八级", "九级", "十级" };
        public static string[] 伤残属别 = new string[] { "在乡", "在职" };
        public static string[] 伤残性质 = new string[] {  "因战", "因公", "因病" };
        //伤残情形
        public static string[] 伤残情形 = new string[] { "肢体伤残", "病理残疾", "五官残疾" };
        public static string[] 肢体伤残 = new string[] { "单侧腕关节以下缺失", "单侧肘关节以下缺失", "单侧肩关节以下缺失", "双侧腕关节以下缺失", "双侧肩关节以下缺失",
                                                        "单侧腿部缺失", "单侧小腿以下缺失", "单侧大腿以下缺失", "双侧脚部缺失", "双侧小腿以下缺失",
                                                        "双侧大腿以下缺失", "高位截瘫", "偏瘫"
                                                       };
        public static string[] 五官残疾 = new string[] { "单眼球摘除", "双眼球摘除", "耳廓缺失", "耳聋", "鼻缺损", "额骨缺损" };


        //三属
        public static string[] 是否孤老 = new string[] { "不属于孤老", "属于孤老" };
        public static string[] 是否孤儿 = new string[] { "不属于孤儿", "属于孤儿" };
        public static string[] 是否残疾 = new string[] { "是", "否" };
        public static string[] 是否正在上学 = new string[] { "是", "否" };
        public static string[] 与死者关系 = new string[] { "死者配偶", "死者父母（抚养）", "死者子女", "死者兄弟姐妹" };

        //三红

        //在乡复员军人
        public static string[] 属于时期 = new string[] { "抗日战争", "解放战争", "建国后", "抗美援朝" };

        //参战涉核人员
        public static string[] 参战类别 = new string[] {"01 解放一江山岛作战", "02 川、甘、青、藏、滇地区平叛作战", "03 炮击金门作战", "04 中缅边境勘界警卫作战", "05 中印边境自卫反击战",
                                                        "06 “八.六”海战", "07 崇武以东海战", "08 援越抗美作战", "09 援老抗美作战", "10 珍宝岛自卫反击作战",
                                                        "11 西沙群岛自卫反击作战", "12 中越边境自卫反击作战", "13 “老山、者阴山”地区对越防御作战", "14 南沙群岛自卫反击作战", "15 其他"  };
        public static string[] 享受待遇 = new string[] { "农村参战人员生活补助", "城镇无单位且生活困难参战人员生活补助" };
        public static string[] 身份认定依据 = new string[] { "档案记录", "中央名录" };
        

        //通用
        public static string[] 性别 = new string[] { "男", "女" };
        public static string[] 民族 = new string[] { "汉族", "少数民族" };
        public static string[] 户口类别 = new string[] { "非农业", "农业" };
        public static string[] 是否有身份证复印件 = new string[] {  "有", "无" };
        public static string[] 是否有户口簿退伍证等其他扫描件 = new string[] { "有", "无" };

        public static string[] 供养方式 = new string[] { "分散供养", "荣誉军人康复医院", "复原军人慢性病疗养院", "复原退伍军人精神病院", "光荣院", "福利院", "老年性收养机构" };
        public static string[] 医疗保障方式 = new string[] { "城镇职工基本医疗保险", "城镇居民基本医疗保险", "新型农村合作医疗", "商业保险", "城乡医疗救助", "优抚对象医疗补助" };
        public static string[] 养老保障方式 = new string[] { "新型农村养老保险", "城镇居民养老保险", "城镇职工基本养老保险", "商业保险", "无", "未填" };


        public static string[] 婚姻状况 = new string[] { "已婚", "未婚", "丧偶", "离异" };
        public static string[] 劳动能力 = new string[] { "具备劳动能力", "完全丧失劳动能力", "部分丧失劳动能力" };
        public static string[] 生活能力 = new string[] { "自理", "享受护理" };

        public static string[] 就业情况 = new string[] { "在岗", "离退休", "失业", "无工作" };
        public static string[] 户口簿上住址类别 = new string[] { "城镇", "农村" };
        public static string[] 优抚对象状态 = new string[] { "享受待遇", "去世", "迁出广东", "取消" };


        



    }


}
