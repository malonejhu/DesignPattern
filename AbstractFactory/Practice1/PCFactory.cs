using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice1
{
    internal class PCFactory : IComponentFactory
    {
        public ICPU CreateCPU()
        {
            return new PCCPU();
        }

        public IRAM CreateRAM()
        {
            return new PCRAM();
        }
    }
}
