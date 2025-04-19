using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Practice3
{
    internal interface ICrypto
    {
        void Encode(string data);
    }
}
