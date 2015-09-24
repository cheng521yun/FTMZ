using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using DB.Stru.老龄办;
using Def.Type;
using FrontFlag;
using FrontFlag.Control;
using FrontFlag.Test;
using Global;
using Microsoft.Office.Interop.Excel;
using 福田民政.Forms.Work.数据管理.老龄办.Comm;
using DataTable = System.Data.DataTable;

namespace 福田民政.Forms.Work.数据管理.老龄办.老龄优待证_发放
{
    public partial class 列表 : XForm
    {
        List<DB.Stru.老龄办.敬老优待证> _lst = new List<敬老优待证>();
        private string _strWhere = "-1";

        public 列表()
        {
            InitializeComponent();
        }

        private void fl_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitList();
        }

        private void InitList()
        {
            fl.SetGrdFld( new COLHEAD[] 
                { 
                    new COLHEAD("ID","ID"),
                    new COLHEAD("街道","街道"),
                    new COLHEAD("姓名","姓名"),
                    new COLHEAD("性别","性别"),
                    new COLHEAD("身份证号码","身份证号码"),
                    new COLHEAD("出生日期","出生日期Str"),
                    new COLHEAD("优待证类别","优待证类别"),
                    new COLHEAD("发放日期","CreateDateStr"),
                    new COLHEAD("发放人","Crerator"),
                    new COLHEAD("电话","电话"),
                    new COLHEAD("手机","联系手机"),
                    new COLHEAD("地址","地址"),

                } );

            fl.strIDCol = "ID";

            fl.OnShowPage = ShowPage;
            fl.OnDBClickCell = Modify;
            //fl.OnSelectionChanged = SelectChange;

        }

        public void Find()
        {
            Find( String.Empty );
        }

        public void Find( string strWhere )
        {
            //if ( ! String.IsNullOrEmpty( strWhere ) && strWhere == _strWhere)
            //    return;

            _strWhere = strWhere;

            //设置翻页的数码。
            fl.MaxPage = BL.老龄办.优待证.GetPageMax( strWhere );
            ShowPage( 0 );
        }

        void ShowPage( int nPageNo )
        {
            _lst = BL.老龄办.优待证.GetPage( nPageNo, _strWhere ); ;

            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList( _lst );
            fl.Refresh();
            fl.grd.Refresh();
        }

        void Modify( int nRow, int nCol )
        {
            if ( nRow < 0 || nRow >= _lst.Count )
                return;

            DB.Stru.老龄办.敬老优待证 struSel = fl.grd.Rows[ nRow ].DataBoundItem as DB.Stru.老龄办.敬老优待证;
            if ( struSel == null )
                return;

            FEdit fm = new FEdit();
            fm.stru = struSel;
            if ( fm.ShowDialog() != DialogResult.OK )
                return;

            if ( fm.stru.ID == "" )   //delete
                _lst.RemoveAt( nRow );
            else    //modify
                _lst[ nRow ] = fm.stru;

            //Refreah
            //Fill();
            Find();
        }

        #region Excel

        public void ExcelIn()
        {
            //选择导入证件类型
            Comm.SelectType fmType = new SelectType();
            if ( fmType.ShowDialog() != DialogResult.OK )
                return;
            string strType = fmType.Type;

            //
            DB.DA.老龄办.敬老优待证 da = new DB.DA.老龄办.敬老优待证();
            DataTable dtDB = da.GetBlank();

            //定义Excel表匹配列
            List<IntStr> lstIS = new List<IntStr>()
            {
                new IntStr(1,"姓名"),
                new IntStr(2,"性别"),
                new IntStr(3,"出生日期"),
                new IntStr(4,"单位或住址"),
                new IntStr(5,"身份证号码"),
                new IntStr(6,"电话"),
                new IntStr(7,"证件编号"),  
                new IntStr(8,"照片回执号"),
                new IntStr(9,"街道"),
            };

            //导入Excel
            FrontFlag.EXCEL2 Factory = new FrontFlag.EXCEL2();
            Factory.strSqlConn = DB.DBParam.Sql.Connect;
            DataTable dtExcel = Factory.GetExcelData();

            福田民政.Fun.Comm.CopyDt( dtExcel, dtDB, lstIS );

            List<DB.Stru.老龄办.敬老优待证> lstDB = new List<敬老优待证>();
            lstDB = DB.Stru.老龄办.敬老优待证.Dt2List( ref dtDB );

            if ( lstDB.Count == 0 )
            {
                FF.Ctrl.MsgBox.Show( "导入失败！\n没有可以导入的数据！" );
                return;
            }

            //补加数据
            foreach ( DB.Stru.老龄办.敬老优待证 stru in lstDB )
            {
                stru.CreateDate = FF.Str.Date.GetNow_yyyyMMddHHmmss();
                stru.Crerator = GL.User.Name;
                stru.优待证类别 = strType;
            }

            //保存数据
            DB.Orm.老龄办.敬老优待证 Orm = new DB.Orm.老龄办.敬老优待证();
            Orm.Save( lstDB );

            FF.Ctrl.MsgBox.Show( "导入成功。" );

            return;
        }

        public void ExcelOut()
        {

        }

        #endregion
    }
}
