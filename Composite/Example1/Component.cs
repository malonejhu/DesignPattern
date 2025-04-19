using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example1
{
    internal abstract class Component
    {
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract Component GetChild(int i);
        public abstract void Operation();
    }
}
