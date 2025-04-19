using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example2
{
    internal class ScrollDecorator : ComponentDecoreator
    {
        public ScrollDecorator(VisualComponent visualComponent) : base(visualComponent)
        {
        }

        public override void Display()
        {
            SetScrollbar();
            base.Display();
        }


        public void SetScrollbar()
        {
            Console.WriteLine("增加捲軸");
        }
    }
}
