using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example2
{
    internal class CipherMachine
    {
        public string Encrypt(string planText) 
        {
            Console.WriteLine("數據加密");

            string es = "";
            char[] chars = planText.ToCharArray();
            foreach (var ch in chars) 
            {
                string c = (ch % 7).ToString();
                es += c;
            }

            Console.WriteLine(es);
            return es;
        }
    }
}
