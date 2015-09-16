using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;

namespace 福田民政.Forms.日志管理
{
    public partial class 操作日志 : WorkForm
    {
        public 操作日志()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "日志管理 操作日志";
            Def.Act.Menu.Entry_日志管理_操作日志 += Call;

            InitList();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("建立日期",""),
                    new COLHEAD("操作人",""),
                    new COLHEAD("科室",""),
                    new COLHEAD("功能模块",""),
                    new COLHEAD("执行动作",""),
                    new COLHEAD("执行结果",""),
                } );

            fl.strIDCol = "ID";
        }
    }
}
