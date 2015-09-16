using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.民管局.台账统计;

namespace 福田民政.Forms.数据管理.民管局
{
    public partial class 台账统计 : WorkForm
    {
        public 台账统计()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            strCaption = "台账统计";
            Def.Act.Menu.Entry_数据管理_民管局_台账统计 += Call;
        }

        private void 台账统计_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            InitForm();
        }

        private void InitForm()
        {
            人员管理 f人员管理 = new 人员管理();
            f人员管理.SetParent( pnl01 );

            会员管理 f会员管理 = new 会员管理();
            f会员管理.SetParent( pnl02 );

            资产管理 f资产管理 = new 资产管理();
            f资产管理.SetParent( pnl03 );

            其他管理 f其他管理 = new 其他管理();
            f其他管理.SetParent( pnl04 );

        }

        private void 台账统计_SizeChanged( object sender, EventArgs e )
        {
            ChangeSize();
        }

        private void ChangeSize()
        {
            int H = this.Height / 4;
            int W = this.Width;

            pnl01.Size = new Size( W, H );
            pnl02.Size = new Size( W, H );
            pnl03.Size = new Size( W, H );
            pnl04.Size = new Size( W, H );
        }

    }
}
