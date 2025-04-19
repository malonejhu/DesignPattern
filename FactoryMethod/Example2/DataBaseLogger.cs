using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2
{
    internal class DataBaseLogger : Logger
    {
        public void WriteLog()
        {
            Console.WriteLine("寫入DataBaseLogger");
        }
    }
}
