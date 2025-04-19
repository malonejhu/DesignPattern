using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Example1
{
    internal class ConcreteProductA : Product
    {
        public override void MethodDiff()
        {
            Console.WriteLine("ConcreteProductA MethodDiff");
        }
    }
}