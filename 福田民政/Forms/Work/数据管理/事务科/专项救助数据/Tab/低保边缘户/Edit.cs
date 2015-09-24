using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using FrontFlag;
using UI.Dlg;

namespace 福田民政.Forms.Work.数据管理.事务科.专项救助数据.Tab.低保边缘户
{
    public partial class Edit : EditDlg
    {
        DB.Stru.事务科.专项救助_低保边缘户 _stru = new DB.Stru.事务科.专项救助_低保边缘户();

        临时救助.Tab.低保边缘户 _list = new 临时救助.Tab.低保边缘户();

        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        #region 属性

        public DB.Stru.事务科.专项救助_低保边缘户 stru
        {
            set
            {
                _stru = value;
            }
            get
            {
                return _stru;
            }
        }

        #endregion

        private void LoadForm()
        {
            Caption = "专项救助 低保边缘户";

            uc.stru = _stru;
            _list.Find();
        }

        protected override void Save()
        {
            _stru = uc.stru;

            bool result = BL.事务科.专项救助_低保边缘户.Save(_stru);

            if (result)
                FF.Ctrl.MsgBox.Show(Def.Str.Msg.Save_OK);
            else
                FF.Ctrl.MsgBox.Show(Def.Str.Msg.Save_Err);

            _list.Find();

        }
        public void Delete(string id)
        {
            uc.stru.ID = id;
            Delete();
        }
        protected override void Delete()
        {
            _stru = uc.stru;

            if (_stru.IsNotValid())
            {
                return;
            }
            bool result = BL.事务科.专项救助_低保边缘户.Delete(_stru);

            if (result)
                FF.Ctrl.MsgBox.Show(Def.Str.Msg.Delete_OK);
            else
                FF.Ctrl.MsgBox.Show(Def.Str.Msg.Delete_Err);

            _list.Find();
        }
    }
}
