using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example3
{
    internal class LazySingleton
    {
        private static LazySingleton instance;
        private static readonly object syncRoot = new object();

        private LazySingleton() 
        {
            
        }


        public static LazySingleton GetInstance() 
        {
            if (instance == null) 
            {
                lock (syncRoot) 
                {
                    if (instance == null)
                    {
                        instance = new LazySingleton();
                    }
                }
            }

            return instance;
        }
    }
}
