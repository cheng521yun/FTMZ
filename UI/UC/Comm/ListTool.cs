using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.UC.Comm
{
    public partial class ListTool : UserControl
    {
        public Def.dlgt.Act dlgtExcelIn = null;
        public Def.dlgt.Act dlgtExcelOut = null;
        public Def.dlgt.Act dlgtAdd = null;
        public Def.dlgt.Act dlgtDelete = null;

        public ListTool()
        {
            InitializeComponent();
        }

        #region 属性


        public bool ShowDelete
        {
            set { btnDelete.Visible = value; }
            get { return btnDelete.Visible; }
        }

        #endregion

        private void ListTool_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            btnAdd.dlgtRun = Add;
            btnDelete.dlgtRun = Delete;
            btnExcelIn.dlgtRun = ExcelIn;
            btnExcelOut.dlgtRun = ExcelOut;

            btnDelete.Hide();
        }


        void Add()
        {
            if ( dlgtAdd != null )
                dlgtAdd();
        }

        void Delete()
        {
            if ( dlgtDelete != null )
                dlgtDelete();
        }

        void ExcelIn()
        {
            if ( dlgtExcelIn != null )
                dlgtExcelIn();

            //test
            //FileDialog dlg = new OpenFileDialog();
            //dlg.Title = "请选择需要导入的Excel文档.";
            //dlg.ShowDialog();
        }

        void ExcelOut()
        {
            if ( dlgtExcelOut != null )
                dlgtExcelOut();

            //SaveFileDialog dlg = new SaveFileDialog();
            //dlg.Title = "请选择需要导出的Excel文档.";
            //dlg.ShowDialog();

        }

        //private void btnExcelIn_Load( object sender, EventArgs e )
        //{

        //}

        //private void btnAdd_Load( object sender, EventArgs e )
        //{

        //}

    }

}
