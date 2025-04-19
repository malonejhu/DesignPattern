using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice4
{
    internal class AndroidOperation:IOperation
    {
        public AndroidOperation() 
        {
            Console.WriteLine("AndroidOpeation");
        }
    }
}
