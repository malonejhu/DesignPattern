using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Practice1
{
    internal class Men : Person
    {
        public override void Say()
        {
            Console.WriteLine("I'm Men");
        }
    }
}
