using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice1
{
    internal class PCCPU:ICPU
    {
        public PCCPU() 
        {
            Console.WriteLine("Create PC CPU");
        }
    }
}
