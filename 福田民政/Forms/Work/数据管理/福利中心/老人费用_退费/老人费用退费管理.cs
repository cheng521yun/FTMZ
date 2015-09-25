using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using 福田民政.Forms.数据管理.福利中心.老人费用_退费;

namespace 福田民政.Forms.数据管理.福利中心
{
    public partial class 老人费用管理_退费登记 : WorkForm
    {
        public 老人费用管理_退费登记()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "老人费用退费管理";
            Def.Act.Menu.Entry_数据管理_福利中心_老人费用管理_退费登记 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            Find fFind = new Find();
            fFind.SetParent(pnlTop);

            列表 fList = new 列表();
            fList.SetParent(pnlList);

            fFind.dlgtAddNew = AddNew;
        }
        public override void ShowWnd()
        {
            Show();
        }

        private void AddNew()
        {
            福田民政.Forms.Work.数据管理.福利中心.老人费用退费管理.FEdit fm = new Work.数据管理.福利中心.老人费用退费管理.FEdit();
            fm.ShowDialog();
        }
        private void InitAction()
        {
            //Def.Act.数据管理.老龄办.老龄津贴_发放 += Call老龄津贴_发放;
        }
    }
}
