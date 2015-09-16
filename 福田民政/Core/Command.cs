using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Def;


namespace 福田民政.Core
{
    public class CCommand
    {
        List<INTENT> _lstIntent = new List<INTENT>();

        private int _MaxLen = 10;    //保留指令数量。用于返回操作。
        private int _nPos = -1;      //当前指令指针。因为可以前进和后退。

        #region public

        public void ExecCur()
        {
            INTENT Intent = GetCurIntent();
            if ( Intent == null )
                return;

            Exec( Intent );
        }

        public void ExecNext()
        {
            if ( ListNext() )
            {
                ExecCur();
            }
        }

        public void ExecPre()
        {
            if ( ListPre() )
            {
                ExecCur();
            }
        }

        public void Exec( INTENT Intent )
        {
            dlgt.ActObj Act = Def.CommandId_Act.GetAct( Intent.nCommand );
            if ( Act == null )
                return;

            AddIntent( Intent );

            object objPaeam = Intent.objParam;
            Act( objPaeam );
        }

        public void Exec( int nCommand )
        {
            INTENT Intent = new INTENT( nCommand );
            Exec( Intent );
        }

        public void Exec( int nCommand, string strParam )
        {
            INTENT Intent = new INTENT( nCommand, strParam );
            Exec( Intent );
        }

        public void Exec( int nCommand, object objParam )
        {
            INTENT Intent = new INTENT( nCommand, objParam );
            Exec( Intent );
        }

        #endregion

        #region 链表操作

        private void AddIntent( INTENT Intent )
        {
            _lstIntent.Add( Intent );

            if ( _lstIntent.Count > _MaxLen )
                _lstIntent.RemoveAt( 0 );

            _nPos = _lstIntent.Count - 1;   //指针到最尾。（指向最新加入的指令）
        }

        private INTENT GetCurIntent()
        {
            if ( _nPos < 0 || _nPos >= _lstIntent.Count )
                return null;

            return _lstIntent[ _nPos ];
        }

        private bool ListNext()
        {
            if ( _nPos < _lstIntent.Count - 1 )
            {
                _nPos++;
                return true;
            }
            return false;
        }

        private bool ListPre()
        {
            if ( _nPos > 1 )
            {
                _nPos--;
                return true;
            }
            return false;
        }

        #endregion
    }

    public class INTENT
    {
        public INTENT( int ncommand )
        {
            nCommand = ncommand;
            //Act = act;
        }
        public INTENT( int ncommand, string strparam )
        {
            nCommand = ncommand;
            objParam = strparam;
            //Act = act;
        }
        public INTENT( int ncommand, object objparam )
        {
            nCommand = ncommand;
            objParam = objparam;
            //Act = act;
        }

        public int nCommand = -1;
        public object objParam = String.Empty;
    }

}
