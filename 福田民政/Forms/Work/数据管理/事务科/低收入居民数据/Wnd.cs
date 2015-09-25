using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.事务科.低收入居民数据;
using 福田民政.Forms.Work.数据管理.事务科.社会救助;
using 福田民政.Forms.Work.数据管理.事务科.社会救助.Tab;

namespace 福田民政.Forms.数据管理.事务科
{
    public partial class 社会救助 : WorkForm
    {
        Find fFind = new Find();
        public 列表 fList = new 列表();
        TabWnd fTab = new TabWnd();

        public 社会救助()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "低收入居民数据管理";
            Def.Act.Menu.Entry_数据管理_事务科_低收入居民数据 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            
            fFind.SetParent( pnlTop );
            fFind.dlgtAddNew = AddNew;
            fFind.dlgtFind = RunFind;

            
            fList.SetParent( pnlList );

            
            fTab.SetParent( pnlBottom );
        }

        private void InitAction()
        {

        }

        public override void ShowWnd()
        {
            Show();

            fList.Find();
           
        }

        private void AddNew()
        {
            福田民政.Forms.Work.数据管理.事务科.低收入居民数据.FEdit fm = new FEdit();
            fm.ShowDialog();
        }

        private void RunFind(string strWhere)
        {
            fList.Find( strWhere );
        }
    }
}
