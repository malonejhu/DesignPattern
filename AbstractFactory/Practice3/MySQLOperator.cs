﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice3
{
    internal class MySQLOperator : IDataBaseOperator
    {
        public ICommand CreateCommand()
        {
            return new MySQLCommand();
        }

        public IConnection CreateConnection()
        {
            return new MySQLConnection();
        }
    }
}
