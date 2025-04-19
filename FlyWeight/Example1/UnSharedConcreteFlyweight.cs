using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Example1
{
    internal class UnSharedConcreteFlyweight : Flyweight
    {
        public override void Operation(string extrinsicState)
        {
            throw new NotImplementedException();
        }
    }
}
