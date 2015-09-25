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
using 福田民政.Forms.Work.数据管理.福利中心.老人入住.Tab.担保人;
namespace 福田民政.Forms.数据管理.福利中心.老人入住.Tab
{
    public partial class 担保人 : XForm
    {
        List<DB.Stru.福利中心.老人入住管理_担保人> _lst = new List<DB.Stru.福利中心.老人入住管理_担保人>();
        private string _strWhere = "";
        public 担保人()
        {
            InitializeComponent();
        }

        private void 担保人_Load(object sender, EventArgs e)
        {
            Find();
            LoadForm();
        }

        private void LoadForm()
        {
            InitList();
            InitTool();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("姓名","姓名"),
                    new COLHEAD("关系","关系"),
                    new COLHEAD("住址或工作单位","住址或工作单位"),
                    new COLHEAD("联系电话","联系电话")
                } );

            fl.strIDCol = "ID";
        }

        private void InitTool()
        {
            ButnTool fTool = new ButnTool();
            Form f = (Form)fTool;
            fl.AddFootPnl(ref f);

            fTool.dlgtAdd = Add;
            fTool.dlgtDelete = Delete;

        }

        private void Add()
        {
            福田民政.Forms.Work.数据管理.福利中心.老人入住.Tab.担保人.Edit fm = new Work.数据管理.福利中心.老人入住.Tab.担保人.Edit();
            fm.ShowDialog();
        }

        private void Delete()
        {
            MessageBox.Show( "Delete" );
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
            fl.MaxPage = BL.福利中心.老人入住管理_担保人.GetPageMax(strWhere);
            ShowPage(0);
        }

        void ShowPage(int nPageNo)
        {
            _lst = BL.福利中心.老人入住管理_担保人.GetPage(nPageNo, _strWhere); ;

            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList(_lst);
            fl.Refresh();
            fl.grd.Refresh();
        }

        void Modify(int nRow, int nCol)
        {
            if (nRow < 0 || nRow >= _lst.Count)
                return;

            DB.Stru.福利中心.老人入住管理_担保人 struSel = fl.grd.Rows[nRow].DataBoundItem as DB.Stru.福利中心.老人入住管理_担保人;
            if (struSel == null)
                return;

            Edit fm = new Edit();
            fm.stru = struSel;
            if (fm.ShowDialog() != DialogResult.OK)
                return;

            if (fm.stru.ID == "")   //delete
                _lst.RemoveAt(nRow);
            else    //modify
                _lst[nRow] = fm.stru;

            //Refreah
            //Fill();
            Find();
        }
    }
}
