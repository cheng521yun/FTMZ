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
using 福田民政.Forms.Work.数据管理.事务科.社会救助.Tab;

namespace 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_发放
{
    public partial class FEdit : EditDlg
    {
        DB.Stru.老龄办.发放老龄津贴 _stru = new DB.Stru.老龄办.发放老龄津贴();
        老龄办.老龄津贴_发放.列表 _find = new 列表();
        public FEdit()
        {
            InitializeComponent();
        }

        private void Edit_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        #region 属性

        public DB.Stru.老龄办.发放老龄津贴 stru
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
            InitForm();
            Caption = "发放老龄津贴";

            uc.stru = _stru;
        }
        private void InitForm()
        {
            //_find.dlgtFind = Find1;
        }

        protected override void Save()
        {
            _stru = uc.stru;

            _stru = BL.老龄办.发放老龄津贴.Save( _stru );

            if ( _stru.IsValid() )
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Save_OK );
            else
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Save_Err );

            _find.Find();
        }

        private void Find1()
        {
            _find.Find();            
        }

        protected override void Delete()
        {
            _stru = uc.stru;

            if (_stru.IsNotValid())
            {
                return;
            }

            _stru = BL.老龄办.发放老龄津贴.Delete( _stru );

            if ( ! _stru.IsValid() )
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Delete_OK );
            else
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Delete_Err );
        }
    }
}
