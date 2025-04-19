using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1
{
    internal class ConcreteFactory : Factory
    {
        public override Product GetProduct()
        {
            return new ConcreteProduct();
        }
    }
}
