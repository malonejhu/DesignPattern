using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Example2
{
    internal class PieChart : Chart
    {
        public PieChart() 
        {
            Console.WriteLine("產生圓餅圖");
        }

        public override void Display()
        {
            Console.WriteLine("顯示圓餅圖");
        }
    }
}
