using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example1
{
    internal class Decorator : Component
    {
        private Component component;

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            component.Operation();
        }

        public void Display() 
        {
        
        }
    }
}
