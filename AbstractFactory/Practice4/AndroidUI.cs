using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice4
{
    internal class AndroidUI:IUI
    {
        public AndroidUI() 
        {
            Console.WriteLine("AndroidUI");
        }
    }
}
