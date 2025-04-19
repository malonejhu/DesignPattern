using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice3
{
    internal class DB4XMLFactory : IConvertFactory
    {
        public IConvertToXML GetConvertObject(string source)
        {
            return new DB4XML(source);
        }
    }
}
