using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Buss.Param;
using Buss.User;
using Buss.人员;
using Buss.优抚科;
using Buss.系统;
using Buss.老龄办;

namespace Buss
{
    public class BL
    {
        static public Buss.系统.SysParam SysParam = new SysParam();
        static public DICTIONARY Dict = new DICTIONARY();

        static public USER User = new USER();

        static public PERSON 人员 = new PERSON();

        public static Buss老龄办 老龄办 = new Buss老龄办();
        public static 优抚科.优抚科 优抚科 = new 优抚科.优抚科();
        public static Buss.事务科.事务科 事务科 = new 事务科.事务科();

    }
}
