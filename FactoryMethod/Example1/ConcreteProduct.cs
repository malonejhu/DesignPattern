using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1
{
    internal class ConcreteProduct : Product
    {
        public override void Show()
        {
            Console.WriteLine("ConcreteProduct");
        }
    }
}
