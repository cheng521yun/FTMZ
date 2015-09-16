using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using UI.Ctrl.Btn;
using 福田民政.Forms.Work.数据管理.事务科.居家养老服务补贴;

namespace 福田民政.Forms.数据管理.事务科
{
    public partial class 居家养老服务补贴 : WorkForm
    {
        Find fFind = new Find();
        列表 fList = new 列表();


        public 居家养老服务补贴()
        {
            InitializeComponent();
        }

        private void 居家养老服务补贴_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        void LoadForm()
        {

        }

        protected override void Init()
        {
            strCaption = "居家养老服务补贴";
            Def.Act.Menu.Entry_数据管理_事务科_居家养老服务补贴 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            
            fFind.SetParent( pnlTop );
            fFind.dlgtAdd = AddNew;

            fList.SetParent( pnlList );

        }

        private void InitAction()
        {
        }

        private void AddNew()
        {
            福田民政.Forms.Work.数据管理.事务科.居家养老服务补贴.Edit fm = new Edit();
            fm.ShowDialog();
        }



    }
}
