using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice3
{
    internal class Excel4XML : IConvertToXML
    {
        public Excel4XML(string filePath)
        {
            Console.WriteLine($"取得資料來源{filePath}");
        }


        public void ConvertToXML()
        {
            Console.WriteLine("Excel -> XML");
        }
    }
}