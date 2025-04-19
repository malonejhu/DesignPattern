using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Example1
{
    internal class Factory
    {
        public static Product GetProduct(string args)
        {
            Product product = null;

            if (args == "A") 
            {
                product = new ConcreteProductA();
            }
            else if(args=="B")
            {
                product=new ConcreteProductB();
            }

            return product;
        }
    }
}