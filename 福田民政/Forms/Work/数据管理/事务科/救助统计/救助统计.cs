using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.事务科.救助统计;

namespace 福田民政.Forms.数据管理.事务科
{
    public partial class 救助统计 : WorkForm
    {
        public 救助统计()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "救助统计";
            Def.Act.Menu.Entry_数据管理_事务科_救助统计 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            //Find fFind = new Find();
            //fFind.SetParent( pnlTop );

            列表 fList = new 列表();
            fList.SetParent( pnlList );

        }

        private void InitAction()
        {
        }

    }
}
