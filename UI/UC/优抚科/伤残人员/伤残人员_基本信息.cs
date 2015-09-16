using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.UC.优抚科.伤残人员
{
    public partial class 伤残人员_基本信息 : UserControl
    {
        public 伤残人员_基本信息()
        {
            InitializeComponent();
        }

        public void SetData( DB.Stru.优抚科.优抚对象.伤残人员.基本信息 stru )
        {
            txt行政区划.Text = stru.行政区划;
            txt身份证号码.Text = stru.身份证号码 ;
            dat出生日期.strDate = stru.出生日期 ;
            cmb伤残等级.Text = stru.伤残等级 ;
            cmb伤残属别.Text = stru.伤残属别 ;
            dat参加工作时间.Text = stru.入伍时间 ;
            cmb劳动能力.Text = stru.劳动能力 ;
            cmb就业情况.Text = stru.就业情况 ;
            cmb户口簿住址类别.Text = stru.户口簿住址类别 ;

            txt姓名.Text = stru.姓名;
            cmb民族.Text = stru.民族;
            cmb性别.Text = stru.性别 ;
            cmb伤残性质.Text = stru.伤残性质;
            cmb婚姻状况.Text = stru.婚姻状况;
            dat退伍时间.strDate = stru.退伍时间 ;
            cmb生活能力.Text = stru.生活能力 ;
            cmb户口类别.Text = stru.户口类别 ;
            txt联系电话.Text = stru.联系电话 ;

            txt工作单位.Text = stru.工作单位 ;
            txt户口簿地址.Text = stru.户口簿住址 ;
            txt实际居住地地址.Text = stru.实际居住地址 ;
            txt备注.Text = stru.备注 ;
        }

        private bool CheckBeforeSave()
        {
            return true;
        }

        public bool GetData( ref DB.Stru.优抚科.优抚对象.伤残人员.基本信息 stru )
        {
            if ( !CheckBeforeSave() )
                return false;

            stru.行政区划 = txt行政区划.Text.Trim();
            stru.身份证号码 = txt身份证号码.Text.Trim();
            stru.出生日期 = dat出生日期.strDate;
            stru.伤残等级 = cmb伤残等级.Text.Trim();
            stru.伤残属别 = cmb伤残属别.Text.Trim();
            stru.入伍时间 = dat参加工作时间.Text.Trim();
            stru.劳动能力 = cmb劳动能力.Text.Trim();
            stru.就业情况 = cmb就业情况.Text.Trim();
            stru.户口簿住址类别 = cmb户口簿住址类别.Text.Trim();

            stru.姓名 = txt姓名.Text.Trim();
            stru.民族 = cmb民族.Text.Trim();
            stru.性别 = cmb性别.Text.Trim();
            stru.伤残性质 = cmb伤残性质.Text.Trim();
            stru.婚姻状况 = cmb婚姻状况.Text.Trim();
            stru.退伍时间 = dat退伍时间.strDate;
            stru.生活能力 = cmb生活能力.Text.Trim();
            stru.户口类别 = cmb户口类别.Text.Trim();
            stru.联系电话 = txt联系电话.Text.Trim();

            stru.工作单位 = txt工作单位.Text.Trim();
            stru.户口簿住址 = txt户口簿地址.Text.Trim();
            stru.实际居住地址 = txt实际居住地地址.Text.Trim();
            stru.备注 = txt备注.Text.Trim();

            return true;
        }
    }
}
