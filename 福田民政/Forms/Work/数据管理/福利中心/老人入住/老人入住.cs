﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using 福田民政.Forms.数据管理.福利中心.老人入住;
using 福田民政.Forms.数据管理.福利中心.老人入住.Tab;

namespace 福田民政.Forms.数据管理.福利中心
{
    public partial class 老人入住管理 : WorkForm
    {
        Find fFind = new Find();
        列表 fList = new 列表();
        TabWnd fTab = new TabWnd();
        public 老人入住管理()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "老人入住管理";
            Def.Act.Menu.Entry_数据管理_福利中心_老人入住管理 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            fFind.SetParent(pnlTop);
            fFind.dlgtAddNew = AddNew;

            fList.SetParent(pnlList);


            fTab.SetParent(pnlBottom);
        }

        public override void ShowWnd()
        {
            Show();
        }

        private void AddNew()
        {
            福田民政.Forms.Work.数据管理.福利中心.老人入住.FEdit fm = new Work.数据管理.福利中心.老人入住.FEdit();
            fm.ShowDialog();
        }
        private void InitAction()
        {
            //Def.Act.数据管理.老龄办.老龄津贴_发放 += Call老龄津贴_发放;
        }
    }
}
