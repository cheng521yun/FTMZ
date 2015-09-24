using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;
using Buss;

namespace 福田民政.Forms.Work.数据管理.基层科.民主管理
{
    public partial class 列表 : XForm
    {
        List<DB.Stru.基层科.民主管理信息管理> _lst = new List<DB.Stru.基层科.民主管理信息管理>();
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
        }


        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("序号","序号"),
                    new COLHEAD("委员会名称","委员会名称"),
                    new COLHEAD("所属街道","所属街道1"),
                    new COLHEAD("工作站","所属街道2"),
                    new COLHEAD("办公电话","办公电话"),
                    new COLHEAD("委员会地址","委员会地址"),
                    new COLHEAD("人口数","人口数"),
                    new COLHEAD("面积","面积"),
                    new COLHEAD("辖区范围","辖区范围"),
                    new COLHEAD("组织机构代码","组织机构代码"),
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
            //if ( strWhere == _strWhere )
            //    return;

            _strWhere = strWhere;

            //设置翻页的数码。
            fl.MaxPage = BL.基层科.民主管理信息管理.GetPageMax(strWhere);
            ShowPage(0);
        }

        void ShowPage(int nPageNo)
        {
            _lst = BL.基层科.民主管理信息管理.GetPage(nPageNo, _strWhere); ;

            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList(_lst);
            fl.Refresh();

        }
        public void ExcelIn()
        {
            string strTmp = Fun.Comm.GetExcelFile();
        }

        public void ExcelOut()
        {
            string strTmp = Fun.Comm.GetExcelFile();
        }
    }
}
