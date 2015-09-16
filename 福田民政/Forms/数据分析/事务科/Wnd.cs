using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Def.Delegate;
using FrontFlag.Control;

namespace 福田民政.Forms.数据分析.事务科
{
    public partial class Wnd : XForm
    {
        public Wnd()
        {
            InitializeComponent();
        }

        #region Event

        private void Wnd_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        #endregion

        private void LoadForm()
        {
            Act.Entry_数据分析_事务科 += Call;
        }

        private void Call( object obj )
        {
            //MessageBox.Show( "in 事务科" );
            //if ( dlgtShowMe != null )
            //{
            //    dlgtShowMe( Def.FormId.事务科 );
            //}

            ShowMe();
        }
    }
}
