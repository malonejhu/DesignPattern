using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice2
{
    internal class TCLFactory : IFactory
    {
        public IConditioner CreateConditioner()
        {
            return new TCLConditioner();
        }

        public ITV CreateTV()
        {
            return new TCLTV();
        }
    }
}
