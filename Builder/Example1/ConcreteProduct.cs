using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example1
{
    internal class ConcreteProduct : Builder
    {
        public override void BuildPartA()
        {
            product.PartA = "A1";
        }

        public override void BuildPartB()
        {
            product.PartB = "B1";
        }

        public override void BuildPartC()
        {
            product.PartC = "C1";
        }
    }
}
