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
using 福田民政.Forms.Work.数据管理.优抚科.抚恤标准管理;

namespace 福田民政.Forms.数据管理.优抚科
{
    public partial class 抚恤标准管理 : WorkForm
    {
        福田民政.Forms.Work.数据管理.优抚科.抚恤标准管理.Tool fTool = new Tool();

        public 抚恤标准管理()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "抚恤标准管理";
            Def.Act.Menu.Entry_数据管理_优抚科_抚恤标准管理 += Call;

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
                    new COLHEAD("伤残优抚对象","",160),
                    new COLHEAD("烈属",""),
                    new COLHEAD("因公牺牲军人遗属","",200),
                    new COLHEAD("病故军人遗属","",160),
                    new COLHEAD("红军失散人员","",160),
                    new COLHEAD("在乡复员军人","",160),
                    new COLHEAD("带病回乡退伍军人","",200),
                    new COLHEAD("参战涉核人员",""),
                    new COLHEAD("铀矿开采军队退役人员","",200),
                    new COLHEAD("老烈士子女",""),
                    new COLHEAD("“五老”人员",""),

                } );

            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnSelectionChanged = SelectChange;
        }

        private void AddNew()
        {
            //FF.Ctrl.MsgBox.Show( "保存前，请填写完整数据!" );   //todo
            return;

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
