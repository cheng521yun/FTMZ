using System;
using System.Collections.Generic;
using System.Text;

namespace FrontFlag.Popedom
{
    public class POPEDOM
    {
        public enum OPREATE
        {
            Read = 0x0001,
            Write = 0x0010,
            Modify = 0x0100,
            Create = 0x1000
        } ;

        private byte _OprateVal=0;  //权限的表达值

        #region 属性

        public bool CanRead
        {
            get { return ((_OprateVal & (byte)OPREATE.Read) == (byte)OPREATE.Read) ? true : false; }
        }

        public bool CanWrite
        {
            get { return ((_OprateVal & (byte)OPREATE.Write) == (byte)OPREATE.Write) ? true : false; }
        }

        public bool CanModify
        {
            get { return CompareByte(_OprateVal, (int)OPREATE.Modify); }
        }

        public bool CanCreate
        {
            get { return CompareByte(_OprateVal, (int)OPREATE.Create); }
        }

        #endregion

        public bool CompareByte ( int nValue , int nFlag )
        {
            byte[] b1 = System.BitConverter.GetBytes(nValue);
            byte[] b2 = System.BitConverter.GetBytes(nFlag);

            if (b1.Length != b2.Length)
                return false;

            bool bRet = false;
            for (int i = 0; i < b1.Length; i ++ )
            {
                bRet = ( ( b1[i] & b2[i] ) == b2[i] ) ? true : false ;
                if (!bRet)
                    return false;
            }

            return true;
        }
    }
}
