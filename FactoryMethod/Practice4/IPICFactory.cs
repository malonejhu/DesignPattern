using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice4
{
    internal interface IPICFactory
    {
        IImageReader GetPICReader();
    }
}
