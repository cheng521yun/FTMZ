using System;
using System.IO;

namespace FrontFlag
{
    public class DEBUG
    {
        public bool _bPrintOut = true ;        //true=产生输出; false=不产生输出。

        string _strOutFile = "Log.txt";

        System.DateTime _tmEnd ;               //保留上一次的时间.    


        public bool AllowPrintOut
        {
            set { _bPrintOut = value ; }
            get { return _bPrintOut ; }
        }

        public string OutFile
        {
            set { _strOutFile = value ; }
            get { return _strOutFile ; }
        }

        public void StartNewLog ()
        {
            File.Delete ( _strOutFile ) ;
        }

        public void Log ( string strInfo )
        {
            if ( ! _bPrintOut )
                return ;

            try
            {
                FileStream f = new FileStream ( _strOutFile , FileMode.OpenOrCreate , FileAccess.Write , FileShare.None );
                StreamWriter sw = new StreamWriter ( f );
                sw.BaseStream.Seek ( 0 , SeekOrigin.End );
                sw.WriteLine ( strInfo );
                sw.Close ( );
            }
            catch ( Exception e )
            {
                string strMsg = e.Message ;                
            }

            _tmEnd = DateTime.Now;   //为以后调用TimeLog 准备开始时间.
        }

        public void TimeLog ( string strInfo )
        {
            if ( ! _bPrintOut )
                return ;

            try
            {
                FileStream f = new FileStream ( _strOutFile , FileMode.OpenOrCreate , FileAccess.Write , FileShare.None );
                StreamWriter sw = new StreamWriter ( f );
                sw.BaseStream.Seek ( 0 , SeekOrigin.End );

                System.TimeSpan ts;
                System.DateTime tmNow = DateTime.Now;
                ts = tmNow - _tmEnd;

                sw.WriteLine ( String.Format ( "{0} [{1}:{2}:{3} {4}] {5}" , tmNow.ToLongTimeString () , ts.Hours , ts.Minutes , ts.Seconds , ts.TotalMilliseconds , strInfo ) );
                sw.WriteLine ( "" );        //添加一个空白行。
                sw.Close ();

                _tmEnd = tmNow;
            }
            catch ( Exception e )
            {
                string strMsg = e.Message;
            }
        }

        public void TimeLogms(string strInfo)
        {
            if (!_bPrintOut)
                return;

            try
            {
                FileStream f = new FileStream(_strOutFile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                StreamWriter sw = new StreamWriter(f);
                sw.BaseStream.Seek(0, SeekOrigin.End);

                System.TimeSpan ts;
                System.DateTime tmNow = DateTime.Now;
                ts = tmNow - _tmEnd;

                sw.WriteLine(String.Format("{0}.{1} [{2}:{3}:{4} {5}] {6}", tmNow.ToLongTimeString(), tmNow.Millisecond , ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds, strInfo));
                sw.WriteLine("");        //添加一个空白行。
                sw.Close();

                _tmEnd = tmNow;
            }
            catch (Exception e)
            {
                string strMsg = e.Message;
            }
        }

    }

}