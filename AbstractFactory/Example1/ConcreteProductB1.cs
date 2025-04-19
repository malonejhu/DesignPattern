using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example1
{
    internal class ConcreteProductB1:AbstractProductB
    {
        public ConcreteProductB1()
        {
            Console.WriteLine("create ConcreteProductB1");
        }
    }
}
