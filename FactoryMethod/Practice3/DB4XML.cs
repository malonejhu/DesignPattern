using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice3
{
    internal class DB4XML : IConvertToXML
    {
        public DB4XML(string cn)
        {
            Console.WriteLine($"取得資料來源{cn}");
        }
        public void ConvertToXML()
        {
            Console.WriteLine("DB -> XML");
        }
    }
}
