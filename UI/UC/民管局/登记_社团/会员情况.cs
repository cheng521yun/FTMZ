using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace UI.UC.民管局.登记_社团
{
    public partial class 会员情况 : XForm
    {
        public 会员情况()
        {
            InitializeComponent();
        }

        private void 会员情况_Load( object sender, EventArgs e )
        {
            InitList();
        }

        private void InitList()
        {
            InitList01();
            InitList02();
        }

        private void InitList01()
        {
            fl单位会员数.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("单位名称","" ),
                    new COLHEAD("执照证号",""),
                    new COLHEAD("法定代表人",""),
                    new COLHEAD("资产级别",""),
                    new COLHEAD("联系电话",""),
                } );
        }

        private void InitList02()
        {
            fl个人会员数.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("姓名","" ),
                    new COLHEAD("身份证号",""),
                    new COLHEAD("现户口所在地",""),
                    new COLHEAD("预备党员",""),
                    new COLHEAD("联系电话",""),
                    new COLHEAD("特殊人才情况",""),
                } );
        }

    }
}
