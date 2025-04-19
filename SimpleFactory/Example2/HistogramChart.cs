using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Example2
{
    internal class HistogramChart : Chart
    {
        public HistogramChart()
        {
            Console.WriteLine("產生柱狀圖");
        }

        public override void Display()
        {
            Console.WriteLine("顯示柱狀圖");
        }
    }
}
