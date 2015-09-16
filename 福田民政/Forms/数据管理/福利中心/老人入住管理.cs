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

namespace 福田民政.Forms.数据管理.福利中心
{
    public partial class 老人入住管理 : XForm
    {
        public 老人入住管理()
        {
            InitializeComponent();
        }

        private void 老人入住管理_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Act.Entry_数据管理_福利中心_老人入住管理 += Call;
        }

        private void Call( object obj )
        {
            ShowMe();
        }
    }
}
