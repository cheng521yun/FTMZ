using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.事务科.居家养老服务补贴
{
    public partial class 列表 : XForm
    {
        public 列表()
        {
            InitializeComponent();
        }

        private void fl_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitList();
        }

        								


        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("街道",""),
                    new COLHEAD("社区",""),
                    new COLHEAD("序号",""),
                    new COLHEAD("姓名",""),
                    new COLHEAD("性别",""),
                    new COLHEAD("年龄",""),
                    new COLHEAD("身份证号",""),
                    new COLHEAD("享受类别",""),

                    new COLHEAD("享受金额",""),
                    new COLHEAD("目前服务机构",""),
                    new COLHEAD("批准时间",""),

                    new COLHEAD("居住地址",""),
                    new COLHEAD("居住状况",""),
                    new COLHEAD("联系电话",""),
                    new COLHEAD("紧急联系人",""),
                    new COLHEAD("紧急联系人电话","",120),
                    new COLHEAD("备  注",""),

                    new COLHEAD("填表人",""),
                    new COLHEAD("联系电话",""),
                    new COLHEAD("填表日期",""),

                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }

    }
}
