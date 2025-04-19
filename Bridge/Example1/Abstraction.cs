using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example1
{
    internal abstract class Abstraction
    {
        protected IImplementor impl;

        public void SetImpl(IImplementor impl) 
        {
            this.impl = impl;
        }

        public abstract void Operation();
    }
}