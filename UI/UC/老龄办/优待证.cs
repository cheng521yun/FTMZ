using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag;
using Global;

namespace UI.UC.老龄办
{
    public partial class 优待证 : UserControl
    {
        DB.Stru.老龄办.敬老优待证 _stru = new DB.Stru.老龄办.敬老优待证();

        public 优待证()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.老龄办.敬老优待证 stru
        {
            set 
            { 
                _stru = value;
                SetData();
            }
            get
            {
                GetData();
                return _stru;
            }
        }

        #endregion

        private void 优待证_Load( object sender, EventArgs e )
        {
            //uc街道办.bShow工作站 = false;
        }

        void SetData( )
        {
            txt姓名.Text = _stru.姓名;
            FF.Ctrl.Combo.SetSelectText( cmb性别, _stru.性别 );
            txt身份证号码.Text = _stru.身份证号码;
            dat出生日期.strDate = _stru.出生日期;
            txt联系电话.Text = _stru.电话;
            //FF.Ctrl.Combo.SetSelectText( cmb所属街道, _stru.所属街道 );
            uc街道办.str街道办 = _stru.街道 ;
            txt单位或住址.Text = _stru.单位或住址;
            FF.Ctrl.Combo.SetSelectText( cmb优待证类别, _stru.优待证类别 );
            txt证件编号.Text = _stru.证件编号;
            txt照片回执号.Text = _stru.照片回执号;
        }

        public void GetData()
        {
            if (String.IsNullOrEmpty(_stru.Crerator.Trim()))
                _stru.Crerator = GL.User.Name;

            _stru.姓名 = txt姓名.Text.Trim() ;
            _stru.性别 = cmb性别.Text.Trim();
            _stru.身份证号码 = txt身份证号码.Text.Trim();
            _stru.出生日期 = dat出生日期.strDate  ;
            _stru.电话 = txt联系电话.Text.Trim();
            //_stru.所属街道 = cmb所属街道.Text.Trim();
            _stru.街道 = uc街道办.str街道办;
            _stru.单位或住址 = txt单位或住址.Text.Trim();
            _stru.优待证类别 = cmb优待证类别.Text.Trim();
            _stru.证件编号 = txt证件编号.Text.Trim();
            _stru.照片回执号 = txt照片回执号.Text.Trim();
        }

    }
}
