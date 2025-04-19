using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice4
{
    internal class GIFFactory : IPICFactory
    {
        public IImageReader GetPICReader()
        {
            return new GIFReader();
        }
    }
}
