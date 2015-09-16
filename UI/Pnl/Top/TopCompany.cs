using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Global;

namespace UI.Pnl.TopMenu
{
    public partial class TopCompany : UserControl
    {
        public TopCompany()
        {
            InitializeComponent();
        }

        private void TopCompany_Load( object sender, EventArgs e )
        {
            if ( ! this.DesignMode )
                LoadForm();
        }

        private void LoadForm()
        {
            try
            {
                Image img = new Bitmap( GL.Res.Pic.CompanyLogo );
                if ( img != null )
                    picBox.Image = img;
            }
            catch (Exception ex)
            {
                string strMsg = ex.Message;
            }
        }
    }
}
