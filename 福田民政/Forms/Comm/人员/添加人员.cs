using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;

namespace 福田民政.Forms.Comm.人员
{
    public partial class F添加人员 : UI.Dlg.CommDlg
    {
        DB.Stru.人员 _stru = new DB.Stru.人员();

        public F添加人员()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.人员 stru
        {
            get { return _stru; }
        }

        #endregion

        private void 添加人员_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Caption = "添加人员";
        }

        protected override void OK()
        {
            if (!CheckBeforeSave())
            {
                Close_None();
                return;
            }

            DB2Dlg();

            _stru = BL.人员.AddNew(_stru);

            Close_OK();
        }

        private bool CheckBeforeSave()
        {
            return uc人员.CheckBeforeSave();
        }

        private void DB2Dlg()
        {
            _stru = uc人员.stru;
        }


    }
}
