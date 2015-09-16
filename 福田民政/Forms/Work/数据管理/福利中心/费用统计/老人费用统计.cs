using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using 福田民政.Forms.数据管理.福利中心.费用统计.Tab;

namespace 福田民政.Forms.数据管理.福利中心
{
    public partial class 老人费用统计 : WorkForm
    {
        public 老人费用统计()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "老人费用统计";
            Def.Act.Menu.Entry_数据管理_福利中心_老人费用统计 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            TabWnd fTab = new TabWnd();
            fTab.SetParent( this );
        }

        private void InitAction()
        {
            //Def.Act.数据管理.老龄办.老龄津贴_发放 += Call老龄津贴_发放;
        }
    }
}
