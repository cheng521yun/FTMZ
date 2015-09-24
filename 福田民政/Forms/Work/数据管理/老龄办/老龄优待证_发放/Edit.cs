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

namespace 福田民政.Forms.Work.数据管理.老龄办.老龄优待证_发放
{
    public partial class FEdit : EditDlg
    {
        DB.Stru.老龄办.敬老优待证 _stru = new DB.Stru.老龄办.敬老优待证();
        列表 _list = new 列表();

        public FEdit()
        {
            InitializeComponent();
        }

        private void Edit_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        #region 属性

        public DB.Stru.老龄办.敬老优待证 stru
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
            Caption = "发放老龄优待证";

            uc优待证.stru = _stru;
        }

        protected override void Save()
        {
            _stru= uc优待证.stru;

            _stru = BL.老龄办.优待证.Save( _stru );

            if ( _stru.IsValid() )
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Save_OK );
            else
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Save_Err );

            _list.Find();
        }

        protected override void Delete()
        {
            _stru = uc优待证.stru;

            if (_stru.IsNotValid())
            {
                return;
            }

            _stru = BL.老龄办.优待证.Delete( _stru );

            if ( ! _stru.IsValid() )
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Delete_OK );
            else
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Delete_Err );
        }
    }
}
