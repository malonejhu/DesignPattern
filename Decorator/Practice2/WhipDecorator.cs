using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Practice2
{
    internal class WhipDecorator : BeverageDecorator
    {
        public WhipDecorator(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "加奶泡";
        }
        public override int GetCost()
        {
            return base.GetCost() + 8;
        }
    }
}
