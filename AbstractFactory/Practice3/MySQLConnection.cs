using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice3
{
    internal class MySQLConnection : IConnection
    {
        public MySQLConnection()
        {
            Console.WriteLine("MySQL Connection");
        }
    }
}
