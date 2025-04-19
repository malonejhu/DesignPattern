using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example2
{
    internal class BlackBorder : ComponentDecoreator
    {
        public BlackBorder(VisualComponent visualComponent) : base(visualComponent)
        {
        }

        public override void Display()
        {
            SetBlackBorder();
            base.Display();
        }

        public void SetBlackBorder() 
        {
            Console.WriteLine("為元素增加黑色邊框");
        }
    }
}
