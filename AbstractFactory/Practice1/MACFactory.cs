using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice1
{
    internal class MACFactory : IComponentFactory
    {
        public ICPU CreateCPU()
        {
            return new MACCPU();
        }

        public IRAM CreateRAM()
        {
            return new MACRAM();
        }
    }
}
