using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice1
{
    internal class MACCPU:ICPU
    {
        public MACCPU() 
        {
            Console.WriteLine("Create MAC CPU");
        }
    }
}
