using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrontFlag.Control
{
    public class PERMISSION
    {
        byte _p = 0xFF;      //默认有所有权限

        byte bShow = 0x01;
        byte bEnable = 0x02;
        byte bModify = 0x04;
        byte bDelete = 0x08;
        byte bCreate = 0x10;
        byte bLoad = 0x20;          //可否加载数据，暂时有没想到合适的应用实例
        byte bFind = 0x40;
        byte bExecute = 0x80;

        byte bAll = 0xFF;

        #region 属性

        public byte p
        {
            set { _p = value; }
            get { return _p; }
        }

        public bool CanShow
        {
            set { if ( value ) { p |= bShow; } else { p &= ( (byte)~bShow ); }; }
            get { return ( ( p & bShow ) == bShow ) ? true : false; }
        }

        public bool CanEnable
        {
            set { if ( value ) { p |= bEnable; } else { p &= ( (byte)~bEnable ); }; }
            get { return ( ( p & bEnable ) == bEnable ) ? true : false; }
        }

        public bool CanModify
        {
            set { if ( value ) { p |= bModify; } else { p &= ( (byte)~bModify ); }; }
            get { return ( ( p & bModify ) == bModify ) ? true : false; }
        }

        public bool CanDelete
        {
            set { if ( value ) { p |= bDelete; } else { p &= ( (byte)~bDelete ); }; }
            get { return ( ( p & bDelete ) == bDelete ) ? true : false; }
        }

        public bool CanCreate
        {
            set { if ( value ) { p |= bCreate; } else { p &= ( (byte)~bCreate ); }; }
            get { return ( ( p & bCreate ) == bCreate ) ? true : false; }
        }

        public bool CanLoad
        {
            set { if ( value ) { p |= bLoad; } else { p &= ( (byte)~bLoad ); }; }
            get { return ( ( p & bLoad ) == bLoad ) ? true : false; }
        }

        public bool CanFind
        {
            set { if ( value ) { p |= bFind; } else { p &= ( (byte)~bFind ); }; }
            get { return ( ( p & bFind ) == bFind ) ? true : false; }
        }

        public bool CanExecute
        {
            set { if ( value ) { p |= bExecute; } else { p &= ( (byte)~bExecute ); }; }
            get { return ( ( p & bExecute ) == bExecute ) ? true : false; }
        }

        public bool CanAll
        {
            set { if ( value ) { p |= bAll; } else { p &= ( (byte)~bAll ); }; }
            get { return ( ( p & bAll ) == bAll ) ? true : false; }
        }

        #endregion

    }
}
