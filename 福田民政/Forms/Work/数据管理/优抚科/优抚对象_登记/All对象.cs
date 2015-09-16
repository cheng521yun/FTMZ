using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DB.Stru.优抚科.优抚对象.伤残人员;
using FrontFlag.Control;
using 福田民政.Forms.Work.数据管理.优抚科.优抚对象_登记.对象类别;

namespace 福田民政.Forms.Work.数据管理.优抚科.优抚对象_登记
{
    public partial class All对象 : XForm
    {
        private List<FORM_UNIT> lstForm = new List<FORM_UNIT>
            {
                new FORM_UNIT(){ Name="伤残人员", fm=new 伤残人员() },
               // new FORM_UNIT(){ Name="三属", fm=new 三属() }
            };


        public All对象()
        {
            InitializeComponent();
        }

        private void All对象_Load( object sender, EventArgs e )
        {
            LoadForm();
        }

        private void LoadForm()
        {
            foreach ( FORM_UNIT unit in lstForm )
            {
                unit.fm.SetParent( this );
            }
        }

        #region public

        public void Show对象类别( string str对象, string str对象类别 )
        {
            HideAll();

            XForm fm = GetXForm( str对象 );
            if (fm != null)
            {
                fm.Show();
            }

            I优抚对象 i对象 = GetInterFace( str对象 );
            if (i对象 == null)
                return;

            i对象.AddNew( str对象, str对象类别 );
        }

        public bool Save( string str对象 )
        {
            I优抚对象 i对象 = GetInterFace( str对象 );
            if (i对象 == null)
                return false;
            
            i对象.SaveData();

            return true;
        }

        #endregion

        #region Private

        private XForm GetXForm( string str对象 )
        {
            //foreach ( FORM_UNIT unit in lstForm )
            //{
            //    if ( unit.Name == str对象 )
            //    {
            //        return unit.fm;
            //    }
            //}

            //return null;

            return lstForm[0].fm;
        }

        private I优抚对象 GetInterFace( string str对象 )
        {
            foreach ( FORM_UNIT unit in lstForm )
            {
                if ( unit.Name == str对象 )
                {
                    return unit.fm as I优抚对象;
                }
            }

            return null;
        }

        private void HideAll()
        {
            foreach ( FORM_UNIT unit in lstForm )
            {
                unit.fm.Hide();
            }
        }

        #endregion

    }

    public class FORM_UNIT
    {
        public string Name = String.Empty;
        public XForm fm = null;
    }

}
