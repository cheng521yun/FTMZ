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
using 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_发放;

namespace 福田民政.Forms.数据管理.老龄办
{
    public partial class 老龄津贴_发放 : WorkForm
    {
        FFind fFind = new FFind();
        列表 fList = new 列表();


        public 老龄津贴_发放()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "老龄津贴 发放";
            Def.Act.Menu.Entry_数据管理_老龄办_老龄津贴_发放 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            fFind.SetParent( pnlTop );
            fFind.dlgtFind = Find;
            fFind.dlgtAdd = 发放老龄津贴;
            fFind.dlgtExcelIn = ExcelIn;
            fFind.dlgtExcelOut = ExcelOut;
   
            fList.SetParent( pnlList );
            
        }

        private void InitAction()
        {
           // Def.Act.数据管理.老龄办.老龄津贴_发放 += Call老龄津贴_发放;
        }

        public override void ShowWnd()
        {
            Show();
            Find( String.Empty );
        }

        private void Find( string strWhere )
        {
            fList.Find( strWhere );
        }

        private void 发放老龄津贴()
        {
            FEdit fm = new FEdit();
            if ( fm.ShowDialog() != DialogResult.OK )
                return;
        }

        private void ExcelIn()
        {
            fList.ExcelIn();
        }

        private void ExcelOut()
        {

        }

    }
}
