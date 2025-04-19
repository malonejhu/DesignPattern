using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice4
{
    internal class JPGFactory : IPICFactory
    {
        public IImageReader GetPICReader()
        {
            return new JPGReader();
        }
    }
}
