using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI.UC.民管局.登记_社团;

namespace UI.UC.民管局
{
    public partial class 民管局登记_社团 : UserControl
    {
        Left fLeft = new Left();
        Right fRight = new Right();

        public 民管局登记_社团()
        {
            InitializeComponent();
        }

        private void 民管局登记_民非_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            
            fLeft.SetParent( pnlLeft );
            fLeft.dlgtRun = Run;

            fRight.SetParent( pnlContent );
        }

        private void Run(string strCaption)
        {
            fRight.ShowWnd( strCaption );
        }
    }
}
