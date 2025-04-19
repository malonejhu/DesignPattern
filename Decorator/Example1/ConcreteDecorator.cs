using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example1
{
    internal class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Addbehavior();
        }

        public void Addbehavior() 
        {
            
        }
    }
}
