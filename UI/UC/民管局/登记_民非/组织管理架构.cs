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
    public partial class 组织管理架构 : XForm
    {
        public 组织管理架构()
        {
            InitializeComponent();
        }

        private void 组织管理架构_Load( object sender, EventArgs e )
        {
            InitList();
        }

        private void InitList()
        {
            InitList01();
            InitList02();
            InitList03();
            InitList04();
        }

        private void InitList01()
        {
            //fl.SetGrdFld( new COLHEAD[] 
            //    { 
            //        new COLHEAD("职位",""),
            //        new COLHEAD("姓名",""),
            //        new COLHEAD("性别",""),
            //        new COLHEAD("学历",""),
            //        new COLHEAD("是否留学",""),
            //        new COLHEAD("职务",""),
            //        new COLHEAD("联系电话",""),
            //    } );
        }

        private void InitList02()
        {
            fl02.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("兼职人数(男)",""),
                    new COLHEAD("兼职人数(女)",""),
                    new COLHEAD("专职人数(男)",""),
                    new COLHEAD("专职人数(女)",""),
                    new COLHEAD("各学历段人数",""),
                    new COLHEAD("各年龄段人数",""),
                } );
        }

        private void InitList03()
        {
            fl03.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("兼职人数(男)",""),
                    new COLHEAD("兼职人数(女)",""),
                    new COLHEAD("专职人数(男)",""),
                    new COLHEAD("专职人数(女)",""),
                    new COLHEAD("各学历段人数",""),
                    new COLHEAD("各年龄段人数",""),
                } );
        }

        private void InitList04()
        {
            fl04.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("专职工作人员中党员","", 200),
                    new COLHEAD("预备党员",""),
                    new COLHEAD("兼职工作人员中党员","",200),
                    new COLHEAD("预备党员",""),
                    new COLHEAD("是否建立党组织",""),
                    new COLHEAD("党组织关系",""),
                } );
        }

    }
}
