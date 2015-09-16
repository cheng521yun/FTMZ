using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.民管局.台账列表;
using 福田民政.Forms.Work.数据管理.民管局.台账列表.Tab;

namespace 福田民政.Forms.数据管理.民管局
{
    public partial class 台账列表 : WorkForm
    {
        public 台账列表()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "台账列表";
            Def.Act.Menu.Entry_数据管理_民管局_台账列表 += Call;
        
            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            福田民政.Forms.Work.数据管理.民管局.台账列表.Find fFind = new Find();
            fFind.SetParent( pnlTop );

            列表 fList = new 列表();
            fList.SetParent( pnlList );

            福田民政.Forms.Work.数据管理.民管局.台账列表.Tab.TabWnd fTab = new TabWnd();
            fTab.SetParent(  pnlBottom );
        }

        private void InitAction()
        {
        }

    }
}
