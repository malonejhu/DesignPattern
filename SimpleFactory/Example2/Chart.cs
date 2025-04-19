using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Example2
{
    internal abstract class Chart
    {
        /// <summary>
        /// 也可以把建立物件的方法放到基類中，可以省去一個工廠方法類
        /// </summary>
        public static Chart GetChart(string args)
        {
            Chart chart = null;

            if (args == "histogram")
            {
                chart = new HistogramChart();
            }
            else if (args == "linechart")
            {
                chart = new LineChart();
            }
            else if (args == "piechart")
            {
                chart = new PieChart();
            }

            return chart;
        }

        public abstract void Display();
    }
}
