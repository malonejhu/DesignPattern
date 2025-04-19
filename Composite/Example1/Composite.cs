using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example1
{
    internal class Composite : Component
    {
        private List<Component> component = new List<Component>();

        public override void Add(Component c)
        {
            component.Add(c);
        }

        public override Component GetChild(int i)
        {
            return component[i];
        }

        public override void Operation()
        {
            foreach (var item in component) 
            {
                item.Operation();
            }
        }

        public override void Remove(Component c)
        {
            component.Remove(c);
        }
    }
}
