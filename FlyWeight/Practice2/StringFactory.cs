using FlyWeight.Practice1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Practice2
{
    internal class StringFactory
    {
        private static StringFactory instance = new StringFactory();
        private Hashtable ht;

        private StringFactory()
        {
            StringStorage stringStorage = new StringStorage("CSharp");
            ht = new Hashtable();
            ht.Add("CSharp", stringStorage);
        }

        public static StringFactory GetInstance()
        {
            return instance;
        }

        public BaseString GetString(string key)
        {
            if (ht.ContainsKey(key))
            {
                return (BaseString)ht[key];
            }
            else
            {
                var newString = new StringStorage(key);
                ht.Add(key, newString);
                return newString;
            }
        }
    }
}
