using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DB.Stru;
using Global.Param;
using Global.Path;
using Global.Res;
using Global.Url;

namespace Global
{
    public class GL
    {
        static public VERSION Version = new VERSION();

        static public DB.Stru.USER User = new USER();

        static public COMMAND Command = new COMMAND();

        static public PARAM Param = new PARAM();

        static public PATH Path = new PATH();

        static public RES Res = new RES(); 

        static public URL Url = new URL();

    }
}
