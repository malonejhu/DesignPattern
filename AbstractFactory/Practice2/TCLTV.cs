using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice2
{
    internal class TCLTV : ITV
    {
        public TCLTV()
        {
            Console.WriteLine("TCL TV");
        }
    }
}
