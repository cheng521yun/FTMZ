using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag;
using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.优抚科.伤残物品_登记;

namespace 福田民政.Forms.数据管理.优抚科
{
    public partial class 伤残物品_登记 : WorkForm
    {
        福田民政.Forms.Work.数据管理.优抚科.伤残物品_登记.Tool fTool = new Tool();

        public 伤残物品_登记()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "伤残物品 登记";
            Def.Act.Menu.Entry_数据管理_优抚科_伤残物品_登记 += Call;

            fTool.SetParent( pnlBottom );

            InitList();

            fTool.dlgtSave = AddNew;
            fTool.dlgtDelete = Delete;
            fTool.dlgtExcelIn = ExcelIn;
        }

 
        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("序号",""),
                    new COLHEAD("物品名称",""),
                    new COLHEAD("物品数量(个)",""),
                    new COLHEAD("使用期限(月)",""),
                    new COLHEAD("物品描述",""),
                    new COLHEAD("登记人",""),
                    new COLHEAD("登记日期",""),

                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }

        private void AddNew()
        {
            Edit fm = new Edit();
            fm.ShowDialog();

        }

        private void Delete()
        {
            if ( !FF.Ctrl.MsgBox.ShowYesNo_RetBool( "您确认要删除此记录？" ) )
                return;

            FF.Ctrl.MsgBox.Show( "只能删除有效数据!" );  //todo
        }

        private void ExcelIn()
        {
            string strExcelFile = Fun.Comm.GetExcelFile();

            if ( String.IsNullOrEmpty( strExcelFile ) )
                return;

            FF.Ctrl.MsgBox.Show( "无效的Excel文件格式!" );  //todo

        }
    }
}
