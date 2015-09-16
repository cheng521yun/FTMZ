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

namespace 福田民政.Forms.Work.数据管理.老龄办.老龄津贴_统计
{
    public partial class FFind : XForm
    {
        public Def.dlgt.ActDateTime dlgt统计 = null;

        public FFind()
        {
            InitializeComponent();

            btnFind.dlgtClickFind = Find;
        }

        private void Find()
        {
            string strDat = String.Format( "{0}-{1}-01", dat统计月份.Value.Year, dat统计月份.Value.Month );
            DateTime dat = FF.Fun.MyConvert.Str2Date(strDat);

            if ( dlgt统计 != null )
                dlgt统计( dat );
        }

        private void FFind_Load( object sender, EventArgs e )
        {
            
        }


    }
}
