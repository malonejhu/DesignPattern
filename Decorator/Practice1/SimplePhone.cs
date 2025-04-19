using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Practice1
{
    internal class SimplePhone : Phone
    {
        public override void Display()
        {
            Console.WriteLine("SimplePhone");
        }
    }
}
