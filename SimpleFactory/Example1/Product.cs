using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Example1
{
    internal abstract class Product
    {
        public void MethodSame() 
        {
            Console.WriteLine("Product MethodSame");
        }

        public abstract void MethodDiff();
    }
}