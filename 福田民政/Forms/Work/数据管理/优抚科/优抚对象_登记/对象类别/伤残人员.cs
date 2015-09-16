using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Buss;
using DB.Stru.优抚科.优抚对象.伤残人员;
using FrontFlag;
using FrontFlag.Control;

namespace 福田民政.Forms.Work.数据管理.优抚科.优抚对象_登记.对象类别
{
    public partial class 伤残人员 : XForm, I优抚对象
    {
        DB.Stru.优抚科.优抚对象.伤残人员.基本信息 _stru = new 基本信息();


        public 伤残人员()
        {
            InitializeComponent();
        }

        public void AddNew(string str对象, string str对象类别)
        {
            _stru.优抚对象 = str对象;
            _stru.优抚对象类别 = str对象类别;
        }

        public void LoadData( object stru )
        {
            _stru = stru as DB.Stru.优抚科.优抚对象.伤残人员.基本信息;


            Load基本信息();
        }

        public void SaveData()
        {
            Save基本信息();
        }

        #region 基本信息

        private void Load基本信息()
        {
            uc基本信息.SetData( _stru );
        }

        private void Save基本信息()
        {
            uc基本信息.GetData( ref _stru );

            _stru = BL.优抚科.对象.伤残人员.Save基本信息( _stru );

            if ( _stru.IsValid() )
                FF.Ctrl.MsgBox.Show( Def.Str.Msg.Save_OK );
            else
                FF.Ctrl.MsgBox.ShowWarn( Def.Str.Msg.Save_Err );
        }

        #endregion
    }
}
