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

namespace 福田民政.Forms.系统配置
{
    public partial class 个性化 : XForm
    {
        public 个性化()
        {
            InitializeComponent();
        }

        private void 个性化_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Act.Entry_系统配置_个性化 += Call;
        }

        private void Call( object obj )
        {
            //MessageBox.Show( "in 老龄办" );

            ShowMe();
        }
    }
}
