using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example2
{
    internal class ComponentDecoreator : VisualComponent
    {
        private VisualComponent visualComponent;

        public ComponentDecoreator(VisualComponent visualComponent)
        {
            this.visualComponent = visualComponent;
        }

        public override void Display()
        {
            visualComponent.Display();
        }
    }
}
