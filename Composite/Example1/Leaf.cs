using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example1
{
    internal class Leaf : Component
    {
        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override Component GetChild(int i)
        {
            return null;
        }

        public override void Operation()
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
