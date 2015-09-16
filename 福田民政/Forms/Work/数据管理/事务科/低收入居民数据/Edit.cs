using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using DB.Stru.事务科;
using UI.Dlg;
using FrontFlag;

namespace 福田民政.Forms.Work.数据管理.事务科.低收入居民数据
{
    public partial class FEdit : EditDlg
    {
        DB.Stru.事务科.低收入居民 _stru = new 低收入居民();

        public FEdit()
        {
            InitializeComponent();
        }

        #region

        public DB.Stru.事务科.低收入居民 stru
        {
            set { _stru = value; }
            get { return _stru; }
        }

        #endregion

        private void Edit_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Caption = "编辑 低收入居民数据";
            //SetChild(uc);

            uc.stru = _stru;
        }



        private bool CheckBeforSave()
        {

            return true;
        }


        protected override void Save()
        {
            _stru = uc.stru; 

            if ( !CheckBeforSave() )
                return;

            bool bRet = BL.事务科.低收入居民.Save( _stru );

            if ( bRet )
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Save_OK );
            else
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Save_Err );
        }

        protected override void Delete()
        {
            bool bRet = BL.事务科.低收入居民.Delete( _stru );

            if ( bRet )
            {
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Delete_OK );
                _stru.ID = String.Empty;
            }
            else
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Delete_Err );
        }
    }
}
