using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.事务科.专项救助数据.Tab.意外救助;
using 福田民政.Forms.Work.数据管理.事务科.临时救助;
using 福田民政.Forms.Work.数据管理.事务科.临时救助.Tab;
using 福田民政.Forms.Work.数据管理.事务科.低收入居民数据.Tab.发放记录;
using 福田民政.Layout;

namespace 福田民政.Forms.数据管理.事务科
{
    public partial class 临时救助 : WorkForm
    {
        Find fFind = new Find();
        public TabWnd fTab = new TabWnd();

        public 临时救助()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "专项救助数据管理";
            Def.Act.Menu.Entry_数据管理_事务科_专项救助数据 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            
            fFind.SetParent( pnlTop );
            fFind.dlgtAddNew = Modify;

            //列表 fList = new 列表();
            //fList.SetParent( pnlList );

            
            fTab.SetParent( pnlList );
        }

        private void InitAction()
        {
        }

        private void Modify()
        {
            int nCur = fTab.ctrl.SelectedIndex;

            switch (nCur)
            {
                case 0:
                    Modify_意外救助();
                break;
                case 1:
                    Modify_疾病救助();
                break;
                case 2:
                    Modify_低保边缘户();
                break;
            }
        }

        void Modify_意外救助()
        {
            Work.数据管理.事务科.专项救助数据.Tab.意外救助.Edit fm = new Work.数据管理.事务科.专项救助数据.Tab.意外救助.Edit();
            fm.ShowDialog();
        }

        void Modify_疾病救助()
        {
            Work.数据管理.事务科.专项救助数据.Tab.疾病救助.Edit fm = new Work.数据管理.事务科.专项救助数据.Tab.疾病救助.Edit();
            fm.ShowDialog();
        }

        void Modify_低保边缘户()
        {
            Work.数据管理.事务科.专项救助数据.Tab.低保边缘户.Edit fm = new Work.数据管理.事务科.专项救助数据.Tab.低保边缘户.Edit();
            fm.ShowDialog();
        }
    }
}
