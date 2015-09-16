using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace FrontFlag
{
    public class JSON
    {
        /// <summary>
        /// 把类实例序列化成字符串。
        /// 注意： 只有类中的 Public变量 才会导出到String中！！！
        /// </summary>
        /// <param name="obj">一个类的实例</param>
        /// <returns></returns>
        public string ToJson( object obj )
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer( obj.GetType() );
            MemoryStream ms = new MemoryStream();
            ser.WriteObject( ms, obj );
            byte[] bs = ms.ToArray();
            ms.Close();
            string strRet = Encoding.UTF8.GetString( bs, 0, bs.Length );
            return strRet;
            //return Encoding.Default.GetString( ms.ToArray() );
        }

        /// <summary>
        /// 从系列化的字串生成类实例。
        /// </summary>
        /// <param name="strJson">Jason结构的字符串</param>
        /// <param name="type">类的typeof名称，如如 typeof( Core.stru.Customer )</param>
        /// <returns></returns>
        public object FromJson( string strJson, System.Type type )
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer( type );
            var ms = new MemoryStream( Encoding.UTF8.GetBytes( strJson ) );
            object obj = ser.ReadObject( ms ) ;
            ms.Close();
            return obj;
        }
    }
}
