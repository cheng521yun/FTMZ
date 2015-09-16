using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.系统配置.用户管理
{

    public partial class Wnd : WorkForm
    {

        福田民政.Forms.Work.系统配置.用户管理.Edit fEdit = new Edit();
        福田民政.Forms.Work.系统配置.用户管理.List fList = new List();
        
        public Wnd()
        {
            InitializeComponent();
        }

        private void Wnd_Load( object sender, EventArgs e )
        {

        }

        protected override void Init()
        {
            strCaption = "系统配置 用户管理";
            Def.Act.Menu.Entry_系统配置_用户管理 += Call;
        }

        private void Wnd_Load_1( object sender, EventArgs e )
        {
            InitCtrl();
            LoadForm();
        }

        private void InitCtrl()
        {
            fEdit.SetParent( pnlEdit );
            fList.SetParent( pnlList );

            fEdit.dlgtFlush = SaveUserOK;
            fList.dlgtSelected = EditUser;
        }

        private void LoadForm()
        {
            
        }

        public override void ShowWnd()
        {
            Show();
            LoadList();
        }

        private void SaveUserOK()
        {
            LoadList();
        }

        void LoadList()
        {
            fList.LoadData();
        }

        private void EditUser(DB.Stru.USER stru)
        {
            fEdit.Modify(stru);
        }
    }
}
