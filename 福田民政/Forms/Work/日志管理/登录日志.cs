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
    public partial class 登录日志 : WorkForm
    {
        public 登录日志()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "日志管理 登录日志";
            Def.Act.Menu.Entry_日志管理_登录日志 += Call;

            InitList();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("建立日期",""),
                    new COLHEAD("操作人",""),
                    new COLHEAD("科室",""),
                    new COLHEAD("动作",""),
                    new COLHEAD("结果",""),
                } );

            fl.strIDCol = "ID";
        }
    }
}
