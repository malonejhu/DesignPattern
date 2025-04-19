using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Practice2
{
    internal class ConvertToXML : ConvertUtil
    {
        public ConvertToXML(IDataBase dataBase) : base(dataBase)
        {
        }

        public override void Convert()
        {
            dataBase.ShowDataBase();
            Console.WriteLine("轉換至XML");
        }
    }
}
