using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_统计;

namespace 福田民政.Forms.数据管理.老龄办
{
    public partial class 老龄津贴_统计 : WorkForm
    {
        private FFind fFind = new FFind();
        private 列表 fList = new 列表();

        public 老龄津贴_统计()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "老龄津贴 统计";
            Def.Act.Menu.Entry_数据管理_老龄办_老龄津贴_统计 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            fFind.SetParent( pnlTop );
            fFind.dlgt统计 = 统计;

            fList.SetParent( pnlList );
        }

        private void InitAction()
        {
            //Def.Act.数据管理.老龄办.老龄津贴_停发 += Call老龄津贴_停发;
        }

        //public override void ShowWnd()
        //{
        //    Show();
        //}

        private void 统计( DateTime dat统计月份  )
        {
            fList.统计( dat统计月份 );
        }
    }
}
