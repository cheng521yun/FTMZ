using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;

namespace 福田民政.Forms.数据管理.优抚科
{
    public partial class 优抚对象_查询 : WorkForm
    {
        public 优抚对象_查询()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "优抚对象 查询";
            Def.Act.Menu.Entry_数据管理_优抚科_优抚对象_查询 += Call;

            InitList();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("优抚对象",""),
                    new COLHEAD("优抚对象类别",""),
                    new COLHEAD("姓名",""),
                    new COLHEAD("身份证",""),
                    new COLHEAD("状态",""),
                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }
    }
}
