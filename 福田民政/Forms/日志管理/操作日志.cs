using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Def.Delegate;
using FrontFlag.Control;

namespace 福田民政.Forms.日志管理
{
    public partial class 操作日志 : XForm
    {
        public 操作日志()
        {
            InitializeComponent();
        }

        private void 操作日志_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Act.Entry_日志管理_操作日志 += Call;
        }

        private void Call( object obj )
        {
            //MessageBox.Show( "in 老龄办" );

            ShowMe();
        }
    }
}
