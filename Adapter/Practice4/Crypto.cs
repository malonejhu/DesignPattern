using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Practice4
{
    internal class Crypto
    {
        public void EncodeText(string data) 
        {
            Console.WriteLine($"加密{data}");
        }
    }
}
