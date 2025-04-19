using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example2
{
    internal class Adapter : ITarget
    {
        private Adaptee adaptee;

        public Adapter(Adaptee adaptee) 
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
