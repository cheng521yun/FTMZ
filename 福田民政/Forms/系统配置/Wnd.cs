using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.系统配置
{
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        private void Wnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitForm();
        }

        private void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.系统配置.参数设置 ), Def.FormId.系统配置_参数设置 );
            AddFormList( typeof( 福田民政.Forms.系统配置.个性化 ), Def.FormId.系统配置_个性化 );
        }

    }
}
