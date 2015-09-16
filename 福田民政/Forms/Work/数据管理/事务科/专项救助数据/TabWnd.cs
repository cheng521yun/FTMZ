using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.事务科.临时救助.Tab
{
    public partial class TabWnd : XForm
    {
        意外或其他救助 f意外或其他救助 = new 意外或其他救助();
        疾病救助 f疾病救助 = new 疾病救助();
        低保边缘户 f低保边缘户 = new 低保边缘户();


        public TabWnd()
        {
            InitializeComponent();
        }

        private void TabWnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            
            f意外或其他救助.SetParent( pag意外或其他救助 );

            f疾病救助.SetParent( pag疾病救助 );

            f低保边缘户.SetParent( pag低保边缘户 );

        }
    }
}
