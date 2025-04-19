using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example1
{
    internal class ConcreteProductA1:AbstractProductA
    {
        public ConcreteProductA1() 
        {
            Console.WriteLine("create ConcreteProductA1");
        }
    }
}
