using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Practice2
{
    internal class BeverageDecorator : Beverage
    {
        protected Beverage beverage;

        public BeverageDecorator(Beverage beverage) 
        {
            this.beverage = beverage;
        }

        public override int GetCost()
        {
            return beverage.GetCost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
    }
}
