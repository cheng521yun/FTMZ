using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.UC.基层科
{
    public partial class 民主管理 : UserControl
    {
        DB.Stru.老龄办.发放老龄津贴 _stru = new DB.Stru.老龄办.发放老龄津贴();  //todo

        public 民主管理()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.老龄办.发放老龄津贴 stru
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

        private void 民主管理_Load( object sender, EventArgs e )
        {

        }

        void SetData()
        {
            //txt姓名.Text = _stru.姓名;
            //txt身份证号码.Text = _stru.身份证;
            //dat领取时间.strDate = _stru.领取时间;
            ////cmb所属街道.Text = _stru.街道;
            //uc街道办.str街道办 = _stru.街道;
            //FF.Ctrl.Combo.SetSelectText( cmb类别, _stru.类别 );
            //txt银行账号.Text = _stru.银行账号;
        }

        public void GetData()
        {
            //if ( String.IsNullOrEmpty( _stru.Creator.Trim() ) )
            //    _stru.Creator = GL.User.Name;

            //_stru.姓名 = txt姓名.Text.Trim();
            //_stru.身份证 = txt身份证号码.Text.Trim();
            //_stru.dat出生日期 = FF.Fun.Date.身份证2生日( _stru.身份证 );
            //_stru.领取时间 = dat领取时间.strDate;
            ////_stru.街道 = cmb所属街道.Text.Trim();
            //_stru.街道 = uc街道办.str街道办;
            //_stru.类别 = cmb类别.Text.Trim();
            //_stru.银行账号 = txt银行账号.Text.Trim();
        }


    }
}
