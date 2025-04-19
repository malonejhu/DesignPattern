using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2
{
    internal class DataBaseLoggerFactory : LoggerFactory
    {
        public Logger CreateLogger()
        {
            return new DataBaseLogger();
        }
    }
}
