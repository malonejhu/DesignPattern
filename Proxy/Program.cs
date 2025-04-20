using Proxy.Example1;
using Proxy.Example2;
using Proxy.Practice1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject proxy = new Example1.Proxy();
            proxy.Request();

            Searcher proxySearch = new ProxySearch();
            Console.WriteLine(proxySearch.DoSearch("BB", "123"));


            SalesObject proxyObject = new ProxySales();
            proxyObject.Method();

            Console.Read();
        }
    }
}
