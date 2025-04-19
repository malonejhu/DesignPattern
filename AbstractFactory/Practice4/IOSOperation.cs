using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice4
{
    internal class IOSOperation:IOperation
    {
        public IOSOperation() 
        {
            Console.WriteLine("IOSOpeation");
        }
    }
}
