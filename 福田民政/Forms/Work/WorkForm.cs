using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrontFlag.Control;

namespace 福田民政.Forms
{
    public partial class WorkForm : XForm
    {
        protected string strCaption = String.Empty;
        protected object objParam = null;

        public WorkForm()
        {
            InitializeComponent();
        }

        private void WorkForm_Load( object sender, EventArgs e )
        {
            Init();
        }

        protected virtual void Init()
        {
        }

        protected void Call( object obj )
        {
            objParam = obj;

            ShowMe();

            App.fMain.ShowCaption( strCaption );
        }
    }
}
