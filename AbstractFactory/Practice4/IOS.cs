using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice4
{
    internal class IOS : IMobileFactory
    {
        public IOperation CreateOperation()
        {
            return new IOSOperation();
        }

        public IUI CreateUI()
        {
            return new IOSUI();
        }
    }
}
