using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example2
{
    internal class Logger
    {
        public void Log(string userId) 
        {
            Console.WriteLine("用戶" + userId + "查詢次數+1");
        }
    }
}
