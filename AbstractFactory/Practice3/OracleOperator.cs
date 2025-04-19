using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice3
{
    internal class OracleOperator : IDataBaseOperator
    {
        public ICommand CreateCommand()
        {
            return new OracleCommand();
        }

        public IConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
