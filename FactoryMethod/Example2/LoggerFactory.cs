using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2
{
    internal interface LoggerFactory
    {
        Logger CreateLogger();
    }
}
