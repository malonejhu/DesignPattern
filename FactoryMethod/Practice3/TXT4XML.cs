using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice3
{
    internal class TXT4XML : IConvertToXML
    {
        public TXT4XML(string filePath)
        {
            Console.WriteLine($"取得資料來源{filePath}");
        }

        public void ConvertToXML()
        {
            Console.WriteLine("TXT -> XML");
        }
    }
}
