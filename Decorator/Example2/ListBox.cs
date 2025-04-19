using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example2
{
    internal class ListBox : VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("顯示列表框");
        }
    }
}
