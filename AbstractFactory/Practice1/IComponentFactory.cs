using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice1
{
    internal interface IComponentFactory
    {
        ICPU CreateCPU();
        IRAM CreateRAM();
    }
}
