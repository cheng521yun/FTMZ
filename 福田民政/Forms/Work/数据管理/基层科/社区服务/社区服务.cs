using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.基层科.社区服务;
using 福田民政.Forms.Work.数据管理.基层科.社区服务.Tab;

namespace 福田民政.Forms.数据管理.基层科
{
    public partial class 社区服务信息管理 : WorkForm
    {
        Find fFind = new Find();
        列表 fList = new 列表();
        TabWnd fTab = new TabWnd();

        public 社区服务信息管理()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "社区服务信息管理";
            Def.Act.Menu.Entry_数据管理_基层科_社区服务信息管理 += Call;

            InitForm();
            InitAction();
        }

        private void InitForm()
        {
            
            fFind.SetParent( pnlTop );
            //fFind.dlgtFind = Find;
            fFind.dlgtAdd = Add;
            fFind.dlgtExcelIn = ExcelIn;
            fFind.dlgtExcelOut = ExcelOut;

            
            fList.SetParent( pnlList );

            
            fTab.SetParent( pnlBottom );
        }

        private void InitAction()
        {
            //Def.Act.数据管理.老龄办.老龄津贴_发放 += Call老龄津贴_发放;
        }

        private void Add()
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
            fList.ExcelOut();
        }
    }
}
