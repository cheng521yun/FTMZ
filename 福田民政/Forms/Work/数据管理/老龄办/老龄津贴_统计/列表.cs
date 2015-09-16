using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using DB.Stru.老龄办;
using FrontFlag;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_统计
{
    public partial class 列表 : XForm
    {
        List<DB.Stru.老龄办.老龄津贴统计> _lst = new List<老龄津贴统计>();

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
                    new COLHEAD("统计月份","统计月份"),
                    new COLHEAD("街道办事处","街道"),
                    new COLHEAD("年龄段80","年龄段80"),
                    new COLHEAD("年龄段90","年龄段90"),
                    new COLHEAD("年龄段100","年龄段100"),
                    new COLHEAD("本月新增","本月新增"),
                    new COLHEAD("本月停止","本月终止"),
                    new COLHEAD("本月继续","本月继续"),
                    new COLHEAD("备注","备注")
                } );


            fl.strIDCol = "ID";

            //fl.OnShowPage = ShowPage;
            //fl.OnDBClickCell = Modify;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dat统计月份">已经设置为当月1日</param>
        public void 统计( DateTime dat统计月份 )
        {
            //string strDat0 = String.Format("{0}-{1}-01", dat统计月份.Year, dat统计月份.Month);
            DateTime dat1 = dat统计月份;
            DateTime dat2 = dat1.AddMonths(1);
            string str1 = String.Format( "{0}-{1}-01", dat1.Year, dat1.Month );
            string str2 = String.Format( "{0}-{1}-01", dat2.Year, dat2.Month );

            string strWhere = String.Format( "{0}>='{1}' and {0}<'{2}' ", DB.Tab.老龄办.发放老龄津贴.CreateDate, str1, str2 );

            _lst = BL.老龄办.老龄津贴统计.Get_统计( strWhere );

            //补充字段内容
            DB.Stru.老龄办.老龄津贴统计.Set统计月份( _lst, dat统计月份 );


            //
            Fill();
        }

        void Fill()
        {
            fl.SortBindingList( _lst );
            fl.Refresh();

        }
    }
}
