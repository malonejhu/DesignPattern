using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Example1
{
    internal class ConcreteFlyweight : Flyweight
    {
        private string intrinsicState;
        public ConcreteFlyweight(string intrinsicState) 
        {
            this.intrinsicState = intrinsicState;
        }

        public override void Operation(string extrinsicState)
        {
            throw new NotImplementedException();
        }
    }
}
