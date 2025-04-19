using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice3
{
    internal class OracleConnection:IConnection
    {
        public OracleConnection() 
        {
            Console.WriteLine("Oracle Connection");
        }
    }
}
