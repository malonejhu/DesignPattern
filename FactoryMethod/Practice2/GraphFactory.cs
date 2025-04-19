using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice2
{
    internal class GraphFactory : IChartFactory
    {
        public IChart GetChart()
        {
            return new GraphChart();
        }
    }
}
