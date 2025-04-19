using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice2
{
    internal class HaierTV:ITV
    {
        public HaierTV() 
        {
            Console.WriteLine("Haier TV");
        }
    }
}
