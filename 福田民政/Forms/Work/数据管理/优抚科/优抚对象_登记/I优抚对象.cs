using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 福田民政.Forms.Work.数据管理.优抚科.优抚对象_登记
{
    public interface I优抚对象
    {
        void AddNew( string str对象, string str对象类别 );
        void LoadData( object stru );
        void SaveData();
    }
}
