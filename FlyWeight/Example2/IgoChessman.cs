using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Example2
{
    internal abstract class IgoChessman
    {
        public abstract string GetColor();
        public void Display() 
        {
            Console.WriteLine("棋子顏色" + this.GetColor());
        }

        public void Display(Coordinates coord) 
        {
            Console.WriteLine("棋子顏色{0},棋子位置{1},{2}", this.GetColor(), coord.X, coord.Y);
        }
    }
}
