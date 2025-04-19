using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Practice3
{
    internal class CryptoAdapter :Crypto ,ICrypto
    {
        public void Encode(string data)
        {
            EncodeText(data);
        }
    }
}
