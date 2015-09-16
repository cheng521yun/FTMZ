using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.基层科.数据统计.Tab;

namespace 福田民政.Forms.数据管理.基层科
{
    public partial class 数据统计 : WorkForm
    {
        public 数据统计()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "数据统计";
            Def.Act.Menu.Entry_数据管理_基层科_数据统计 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            //Find fFind = new Find();
            //fFind.SetParent( pnlTop );

            //列表 fList = new 列表();
            //fList.SetParent( pnlList );

            TabWnd fTab = new TabWnd();
            fTab.SetParent( this );
        }

        private void InitAction()
        {
            //Def.Act.数据管理.老龄办.老龄津贴_发放 += Call老龄津贴_发放;
        }
    }
}
