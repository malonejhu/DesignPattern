using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example2
{
    internal class LoadBalancer
    {
        private static LoadBalancer instance = null;

        private ArrayList arrayList = null;

        private LoadBalancer() 
        {
            arrayList = new ArrayList();
        }

        public static LoadBalancer GetLoadBalancer() 
        {
            if (instance == null) 
            {
                instance = new LoadBalancer();
            }

            return instance;
        }

        public void AddServer(string server)
        {
            arrayList.Add(server);
        }

        public void RemoveServer(string server) 
        {
            arrayList.Remove(server);
        }

        public string GetServer() 
        {
            Random random = new Random();
            int i = random.Next(arrayList.Count);
            Console.WriteLine(i);
            return arrayList[i].ToString();
        }
    }
}