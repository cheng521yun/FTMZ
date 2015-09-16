using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control.PickerDate
{
    public partial class XDatePicker : UserControl
    {
        public delegate void entSendMsg ( string strmsg );
        public event entSendMsg Finish = null;  

        FUN Fun = new FUN();

        //设置权限
        POPEDOM Popedom = new POPEDOM (); 

        string _strDate = "";
        private bool _bShowTime = false;   //日期后面是否显示时间。

        public XDatePicker()
        {
            InitializeComponent();

            //
            Popedom.Ctrl = this;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Init();
        }

        #region 属性

        public string strDate
        {
            set
            {
                _strDate = value;
                txt.Text = ( _strDate.Trim() == "" || _strDate.Contains ( "1900" ) ) ? "" : FF.Fun.MyConvert.Str2Date( _strDate ).ToString("yyyy-MM-dd") ;
            }

            get
            {
                return _strDate;
            }
        }

        public string strDate_DB
        {
            get
            {
                if ( _strDate.Trim () == "" )
                    return "1900-1-1";

                return _strDate;
            }
        }

        public bool bShowTime
        {
            set { _bShowTime = value; }
            get { return _bShowTime ; }
        }

        /// <summary>
        /// 设置权限
        /// </summary>
        public Byte PByte
        {
            set { Popedom.Byte = value; }
        }

        public FUN.POPEDOMBYTE PopedomByte
        {
            set { Popedom.PopedomByte = value; }
            get { return Popedom.PopedomByte; }
        }

        #endregion 

        #region Event

        private void OntxtClick(object sender, EventArgs e)
        {
            ShowSelectDate();
        }

        private void OnDatChange(object sender, EventArgs e)
        {
            SelectDate();
        }

        private void OnBtnClick(object sender, EventArgs e)
        {
            ClearSelectDate();
        }

        #endregion

        void Init()
        {
            dat.Location = new Point( 0,0 );
            dat.Hide();
            btn.Location = new Point(80, 0);
            btn.Hide();

            this.Size = new Size ( 100 , 20 ) ;
        }

        public void ShowTxt ()
        {
            txt.Show();
            dat.Hide();
            btn.Hide();
        }

        public void ShowDatPacker()
        {
            txt.Hide();
            dat.Show();
            btn.Show();
        }

        public void HideDatPacker ()
        {
            txt.Show();
            dat.Hide();
            btn.Hide();

            if ( Finish != null )
            {
                if ( bShowTime )
                {
                    string str = txt.Text.ToString () ;
                    if ( str != String.Empty )
                        str = str + " " + DateTime.Now.ToString ( "HH:mm" );
                    Finish( str );
                }
                else
                    Finish(txt.Text.ToString());
            }
        }

        void SelectDate()
        {
            _strDate = dat.Value.ToString( "yyyy-MM-dd" );
            txt.Text = _strDate;
            HideDatPacker();
        }

        void ClearSelectDate()
        {
            _strDate = "";
            txt.Text = ""; 
            HideDatPacker();
        }

        void ShowSelectDate()
        {
            if (_strDate != "" && ! _strDate.Contains("1900") )
                dat.Value = Fun.MyConvert.Str2Date(_strDate);
            else
                dat.Value = DateTime.Now;

            ShowDatPacker();
        }
    }
}
