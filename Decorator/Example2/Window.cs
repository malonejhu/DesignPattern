using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example2
{
    internal class Window : VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("顯示窗體");
        }
    }
}
