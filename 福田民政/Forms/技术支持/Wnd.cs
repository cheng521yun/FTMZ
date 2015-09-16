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
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        private void Wnd_Load( object sender, EventArgs e )
        {
            InitForm();
        }

        private void InitForm()
        {
            AddFormList( typeof( 福田民政.Forms.技术支持.版本更新 ), Def.FormId.技术支持_版本更新 );
            AddFormList( typeof( 福田民政.Forms.技术支持.问题反馈 ), Def.FormId.技术支持_问题反馈 );
        }
    }
}
