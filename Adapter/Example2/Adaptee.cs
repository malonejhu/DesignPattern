using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example2
{
    internal class Adaptee
    {
        public void SpecificRequest() 
        {
            Console.WriteLine("Example2.Adaptee");
        }
    }
}
