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
using 福田民政.Forms.Work.数据管理.福利中心.老人入住;
namespace 福田民政.Forms.数据管理.福利中心.老人入住
{
    public partial class 列表 : XForm
    {
        List<DB.Stru.福利中心.老人入住管理> _lst = new List<DB.Stru.福利中心.老人入住管理>();
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
            Find();
            InitList();
        }
        
        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("姓名","姓名"),
                    new COLHEAD("性别","性别"),
                    new COLHEAD("本人成份","本人成份"),
                    new COLHEAD("户籍所在地","户籍所在地"),
                    new COLHEAD("籍贯","籍贯"),
                    new COLHEAD("身份证","身份证"),
                    new COLHEAD("家庭住址","家庭住址"),
                    new COLHEAD("身体状况","身体状况"),
                    new COLHEAD("申请事由","申请事由"),
                    new COLHEAD("押金费用","押金费用"),

                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            fl.OnDBClickCell = Modify;
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
            fl.MaxPage = BL.福利中心.老人入住管理.GetPageMax(strWhere);
            ShowPage(0);
        }

        void ShowPage(int nPageNo)
        {
            _lst = BL.福利中心.老人入住管理.GetPage(nPageNo, _strWhere); ;

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

            DB.Stru.福利中心.老人入住管理 struSel = fl.grd.Rows[nRow].DataBoundItem as DB.Stru.福利中心.老人入住管理;
            if (struSel == null)
                return;

            FEdit fm = new FEdit();
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
