using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example1
{
    internal class ConcreteProductB2: AbstractProductB
    {
        public ConcreteProductB2()
        {
            Console.WriteLine("create ConcreteProductB2");
        }
    }
}
