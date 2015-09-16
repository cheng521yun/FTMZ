using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace UI.UC.民管局.登记_民非
{
    public partial class 联系信息 : XForm
    {
        public 联系信息()
        {
            InitializeComponent();
        }

        private void 联系信息_Load( object sender, EventArgs e )
        {
            InitList();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("姓名",""),
                    new COLHEAD("性别",""),
                    new COLHEAD("身份证",""),
                    new COLHEAD("住址",""),
                    new COLHEAD("手机",""),
                    new COLHEAD("电话",""),
                    new COLHEAD("邮箱",""),
                } );
        }
    }
}
