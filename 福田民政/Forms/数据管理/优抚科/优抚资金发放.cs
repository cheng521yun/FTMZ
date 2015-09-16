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

namespace 福田民政.Forms.数据管理.优抚科
{
    public partial class 优抚资金发放 : XForm
    {
        public 优抚资金发放()
        {
            InitializeComponent();
        }

        private void 优抚对象_登记_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            Act.Entry_数据管理_优抚科_优抚资金发放 += Call;
        }

        private void Call( object obj )
        {
            ShowMe();
        }
    }
}
