using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example2
{
    internal class RealSearcher : Searcher
    {
        public string DoSearch(string userId, string keyword)
        {
            Console.WriteLine("查詢訊息");

            return "返回查詢資料";
        }
    }
}
