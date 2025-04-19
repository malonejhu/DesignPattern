using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice4
{
    internal class Android : IMobileFactory
    {
        public IOperation CreateOperation()
        {
            return new AndroidOperation();
        }

        public IUI CreateUI()
        {
            return new AndroidUI();
        }
    }
}
