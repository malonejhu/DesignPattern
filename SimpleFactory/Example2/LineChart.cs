using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Example2
{
    internal class LineChart : Chart
    {
        public LineChart()
        {
            Console.WriteLine("產生折線圖");
        }

        public override void Display()
        {
            Console.WriteLine("顯示折線圖");
        }
    }
}
