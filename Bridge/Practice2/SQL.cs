using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Practice2
{
    internal class SQL : IDataBase
    {
        public void ShowDataBase()
        {
            Console.WriteLine("SQL");
        }
    }
}
