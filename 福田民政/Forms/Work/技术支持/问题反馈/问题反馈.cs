using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;

namespace 福田民政.Forms.技术支持
{
    public partial class 问题反馈 : WorkForm
    {
        public 问题反馈()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "技术支持 问题反馈";
            Def.Act.Menu.Entry_技术支持_问题反馈 += Call;
        }

        private void btnOK_Click( object sender, EventArgs e )
        {
            Commit();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            ClearText();
        }

        private void Commit()
        {
            //run Commit

            ClearText();
        }

        private void ClearText()
        {
            txtContent.Text = String.Empty;
        }
    }
}
