using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Example2
{
    internal class ChartFactory
    {
        public static Chart GetChart(string args)
        {
            Chart chart= null;

            if (args == "histogram") 
            {
                chart = new HistogramChart();
            }
            else if(args=="linechart")
            {
                chart = new LineChart();
            }
            else if (args == "piechart")
            {
                chart = new PieChart();
            }

            return chart;
        }
    }
}