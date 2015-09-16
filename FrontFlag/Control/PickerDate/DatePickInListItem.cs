/*
 * 应用在 XParamListView 控件中。
 * CRM系统中，FinanceEditList 会使用XParamListView 控件。 （给PO设置付款信息）
 * 
 * MyDatePick 放到一般对话框上，默认会显示为隐藏状态。
 * 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FrontFlag.Control
{
    public partial class DatePickInListItem : UserControl
    {
        public delegate void entSendMsg ();
        public event entSendMsg DoFinish = null;  
        
        FUN Fun = new FUN ();

        public DatePickInListItem()
        {
            InitializeComponent ();

            dat.LostFocus += new System.EventHandler ( this.datPickerFocusOver );
            dat.KeyPress += new System.Windows.Forms.KeyPressEventHandler ( this.datPickerKeyPress );
            dat.ValueChanged += new System.EventHandler ( this.datPickerValueChanged );
            btnClear.Click += new System.EventHandler ( this.datPickerClear );
        }

        #region 属性

        public string strDate
        {
            set
            {
                dat.Value = FF.Fun.MyConvert.Str2Date(value);
            }
            get
            {
                if ( dat.Value.Year == 1900 )
                    return "";

                return dat.Value.ToString ( "yyyy-MM-dd" );            
            }
        }

        public bool bValid
        {
            get { return (dat.Value.Year == 1900) ? false : true; }
        }

        #endregion

        private void btnClear_Click ( object sender , EventArgs e )
        {
            dat.Value = Fun.MyConvert.Str2Date ( "1900-1-1" );
            Hide ();
            if ( DoFinish != null )
                DoFinish ();
        }

        private void datPickerClear ( object sender , EventArgs e )
        {
            dat.Value = Fun.MyConvert.Str2Date ( "1900-1-1" );
            Hide ();
            if ( DoFinish != null )
                DoFinish ();
        }

        private void datPickerFocusOver ( object sender , System.EventArgs e )
        {
            ////Hide ();
            ////if ( DoFinish != null )
            ////    DoFinish ();
        }

        //DatPicker
        private void datPickerKeyPress ( object sender , System.Windows.Forms.KeyPressEventArgs e )
        {
            if ( e.KeyChar == 13 || e.KeyChar == 27 )
            {
                Hide ();
                if ( DoFinish != null )
                    DoFinish ();
            }
        }

        private void datPickerValueChanged ( object sender , EventArgs e )
        {
            Hide ();
            if ( DoFinish != null )
                DoFinish ();
        }


    }
}
