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
using 福田民政.Forms.Work.数据管理.优抚科.优抚资金发放;

namespace 福田民政.Forms.数据管理.优抚科
{
    public partial class 优抚资金发放 : WorkForm
    {
        福田民政.Forms.Work.数据管理.优抚科.优抚资金发放.Tool fTool = new Tool();

        public 优抚资金发放()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "优抚资金发放";
            Def.Act.Menu.Entry_数据管理_优抚科_优抚资金发放 += Call;

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
                    new COLHEAD("姓名",""),
                    new COLHEAD("性别",""),
                    new COLHEAD("身份证号",""),
                    new COLHEAD("优抚证书编号",""),
                    new COLHEAD("伤残等级",""),
                    new COLHEAD("户口类别",""),
                    new COLHEAD("优抚类别",""),
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
