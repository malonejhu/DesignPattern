using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice4
{
    internal class IOSUI:IUI
    {
        public IOSUI() 
        {
            Console.WriteLine("IOSUI");
        }
    }
}
