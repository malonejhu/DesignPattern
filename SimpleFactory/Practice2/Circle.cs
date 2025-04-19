using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Practice2
{
    internal class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("顯示Circle");
        }

        public override void Erase()
        {
            Console.WriteLine("清除Circle");
        }
    }
}
