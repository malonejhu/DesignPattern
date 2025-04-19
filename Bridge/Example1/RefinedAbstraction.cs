using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example1
{
    internal class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            impl.OperationImp();
        }
    }
}