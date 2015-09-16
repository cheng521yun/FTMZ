using System;
using System.Collections.Generic;
using System.Text;

namespace FrontFlag.Control
{
    public class POPEDOM
    {
        FUN.POPEDOMBYTE _PopedomByte = new FUN.POPEDOMBYTE ();

        private System.Windows.Forms.Control _ctrl = null;

        #region 属性

        public System.Windows.Forms.Control Ctrl
        {
            set
            {
                _ctrl = value;
            }
        }

        public byte Byte
        {
            set
            {
                _PopedomByte.p = value;

                _ctrl.Visible = _PopedomByte.CanRead;             //不可见           
                _ctrl.Enabled = _PopedomByte.CanModify;           //可见，状态无效
            }

        }

        public FUN.POPEDOMBYTE PopedomByte
        {
            set { _PopedomByte = value; }
            get { return _PopedomByte; }
        }

        #endregion


    }
}
