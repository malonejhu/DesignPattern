using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Practice2
{
    internal class Espresso : Beverage
    {
        public override int GetCost()
        {
            return 25;
        }

        public override string GetDescription()
        {
            return "濃縮咖啡";
        }
    }
}
