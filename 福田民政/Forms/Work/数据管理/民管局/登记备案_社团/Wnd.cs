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
using UI.Dlg;
using 福田民政.Forms.Comm.人员;
using 福田民政.Forms.Work.数据管理.民管局.登记备案;
using 福田民政.Forms.Work.数据管理.民管局.登记备案.Tab;
using 福田民政.Forms.Work.数据管理.民管局.登记备案_社团.Edit;

namespace 福田民政.Forms.数据管理.民管局.登记备案_社团
{
    public partial class 登记备案_社团 : WorkForm
    {
        public 登记备案_社团()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "登记备案 社团";
            Def.Act.Menu.Entry_数据管理_民管局_登记备案_社团 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            Find fFind = new Find();
            fFind.SetParent( pnlTop );
            fFind.BtnTool.dlgtAdd = Add;
            fFind.BtnTool.dlgtExcelIn = ExcelIn;
            fFind.BtnTool.dlgtExcelOut = ExcelOut;

            列表 fList = new 列表();
            fList.SetParent( pnlList );

            TabWnd fTab = new TabWnd();
            fTab.SetParent(  pnlBottom );

            ButnTool fTool = new ButnTool();
            fTool.SetParent( pnlTool );
            fTool.dlgtAdd = Add;
        }

        private void InitAction()
        {
            //Def.Act.数据管理.老龄办.老龄津贴_发放 += Call老龄津贴_发放;
        }

        //private void Call老龄津贴_发放( object obj )
        //{
        //    //MessageBox.Show( "Call老龄津贴_发放" );
        //    F查找人员 fm = new F查找人员();
        //    if ( fm.ShowDialog() != DialogResult.OK )
        //        return;

        //    UI.Dlg.AskDlg dlg = new AskDlg();
        //    dlg.strNote = String.Format( "是否给 {0} 发放老龄津贴？", fm.stru.姓名 );
        //    if ( dlg.ShowDialog() != DialogResult.OK )
        //        return;

        //    MessageBox.Show( "发放" );
        //}

        private void Add()
        {
            福田民政.Forms.Work.数据管理.民管局.登记备案_社团.Edit.Edit fm = new Edit();
            fm.ShowDialog();
        }

        private void ExcelIn()
        {
            FF.File.SelectFile();
        }

        private void ExcelOut()
        {
            FF.File.SelectFile();
        }

    }
}
