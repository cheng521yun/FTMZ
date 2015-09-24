using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.事务科.居家养老服务补贴
{
    public partial class 列表 : XForm
    {
        List<DB.Stru.事务科.居家养老服务补贴> _lst = new List<DB.Stru.事务科.居家养老服务补贴>();
        private string _strWhere = "";

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
            Find();
        }

        								


        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("街道","所属街道"),
                    new COLHEAD("社区","社区"),
                    new COLHEAD("序号","序号"),
                    new COLHEAD("姓名","姓名"),
                    new COLHEAD("性别","性别"),
                    new COLHEAD("年龄","年龄"),
                    new COLHEAD("身份证号","身份证"),
                    new COLHEAD("享受类别","享受类别"),

                    new COLHEAD("享受金额","享受金额"),
                    new COLHEAD("目前服务机构","服务机构"),
                    new COLHEAD("批准时间","批准时间"),

                    new COLHEAD("居住地址","居住地址"),
                    new COLHEAD("居住状况","居住状况"),
                    new COLHEAD("联系电话","联系电话"),
                    new COLHEAD("紧急联系人","紧急联系人"),
                    new COLHEAD("紧急联系人电话","紧急联系人电话",120),
                    new COLHEAD("备  注","备注"),

                    new COLHEAD("填表人","填表人"),
                    new COLHEAD("联系电话","填表人联系电话"),
                    new COLHEAD("填表日期","填表日期"),

                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }
        public void Find()
        {
            Find(String.Empty);
        }

        public void Find(string strWhere)
        {
            //if ( ! String.IsNullOrEmpty( strWhere ) && strWhere == _strWhere)
            //    return;

            _strWhere = strWhere;

            //设置翻页的数码。
            fl.MaxPage = BL.老龄办.优待证.GetPageMax(strWhere);
            ShowPage(0);
        }

        void ShowPage(int nPageNo)
        {
            _lst = BL.事务科.居家养老服务补贴.GetPage(nPageNo, _strWhere); ;

            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList(_lst);
            fl.Refresh();

        }
    }
}
