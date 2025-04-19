using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Practice4
{
    internal class CryptorAdapter
    {
        private Crypto crypto;

        public CryptorAdapter() 
        {
            crypto = new Crypto();
        }


        public void Encode(string data)
        {
            crypto.EncodeText(data);
        }
    }
}
