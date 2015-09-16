using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using FrontFlag;
using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.优抚科.优抚对象_登记;
using 福田民政.Forms.Work.数据管理.优抚科.优抚对象_登记.对象类别;

namespace 福田民政.Forms.数据管理.优抚科
{
    public partial class 优抚对象_登记 : WorkForm
    {
        All对象 fAll = new All对象();

        
        public 优抚对象_登记()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "优抚对象 登记";
            Def.Act.Menu.Entry_数据管理_优抚科_优抚对象_登记 += Call;

            InitForm();
            InitAction();
        }

        public override void ShowWnd()
        {
            Show();
            //Test();

            //这里可以获取objParam
        }


        private void InitForm()
        {
            fAll.SetParent( pnlContent );

            Tool fTool = new Tool();
            fTool.SetParent( pnlBottom );

            fTool.dlgtSave = Save;
            fTool.dlgtDelete = Delete;
            fTool.dlgtExcelIn = ExcelIn;

            ucCmb优抚对象.dlgtChange对象类别 = Change对象类别;
        }

        private void InitAction()
        {
            //Def.Act.数据管理.老龄办.老龄津贴_发放 += Call老龄津贴_发放;
        }

        private string Get对象()
        {
            return ucCmb优抚对象.str对象;
        }
        private string Get对象类别()
        {
            return ucCmb优抚对象.str对象类别;
        }

        private void Change对象类别()
        {
            string str对象 = Get对象();
            string str对象类别 = Get对象类别();
            fAll.Show对象类别( str对象, str对象类别 );
        }

        private void Save()
        {
            FF.Ctrl.MsgBox.Show( "保存前，请填写完整数据!" );   //todo
            return;   


            string str对象 = Get对象();
            fAll.Save( str对象 );

            
        }

        private void Delete()
        {
            if (! FF.Ctrl.MsgBox.ShowYesNo_RetBool("您确认要删除此记录？"))
                return;

            FF.Ctrl.MsgBox.Show( "只能删除有效数据!" );  //todo
        }

        private void ExcelIn()
        {
            string strExcelFile = Fun.Comm.GetExcelFile();

            if (String.IsNullOrEmpty(strExcelFile))
                return;

            FF.Ctrl.MsgBox.Show( "无效的Excel文件格式!" );  //todo

        }

    }
}
