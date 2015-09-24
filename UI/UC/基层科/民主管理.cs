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
        DB.Stru.基层科.民主管理信息管理 _stru = new DB.Stru.基层科.民主管理信息管理();  //todo

        public 民主管理()
        {
            InitializeComponent();
        }

        #region 属性

        public DB.Stru.基层科.民主管理信息管理 stru
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
            txt办公电话.Text = _stru.办公电话;
            txt面积.Text = _stru.面积;
            txt人口数.Text = _stru.人口数;
            txt委员会地址.Text = _stru.委员会地址;
            txt委员会名称.Text = _stru.委员会名称;
            txt辖区范围.Text = _stru.辖区范围;
            txt住址机构代码.Text = _stru.组织机构代码;
            uc街道办.str街道办 = _stru.所属街道1;
            uc街道办.str工作站 = _stru.所属街道2;
        }

        public void GetData()
        {
            _stru.办公电话 = txt办公电话.Text;
           _stru.面积 = txt面积.Text ;
            _stru.人口数 = txt人口数.Text ;
            _stru.委员会地址 =txt委员会地址.Text;
            _stru.委员会名称 =txt委员会名称.Text ;
           _stru.辖区范围 =  txt辖区范围.Text ;
           _stru.组织机构代码 = txt住址机构代码.Text;
            _stru.所属街道1 = uc街道办.str街道办 ;
            _stru.所属街道2 = uc街道办.str工作站 ;
        }


    }
}
