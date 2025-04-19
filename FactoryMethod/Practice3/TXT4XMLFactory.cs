using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice3
{
    internal class TXT4XMLFactory : IConvertFactory
    {
        public IConvertToXML GetConvertObject(string source)
        {
            return new TXT4XML(source);
        }
    }
}
