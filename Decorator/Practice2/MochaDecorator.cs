using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Practice2
{
    internal class MochaDecorator : BeverageDecorator
    {
        public MochaDecorator(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "加摩卡";
        }
        public override int GetCost()
        {
            return base.GetCost() + 10;
        }
    }
}
