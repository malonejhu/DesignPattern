using Singleton.Example1;
using Singleton.Example2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example1.Singleton singleton1 = Example1.Singleton.GetInstance();

            Example1.Singleton singleton2 = Example1.Singleton.GetInstance();

            if (singleton1 == singleton2) 
            {
                Console.WriteLine("一樣");
            }

            LoadBalancer balancer1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer balancer2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer balancer3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer balancer4 = LoadBalancer.GetLoadBalancer();

            balancer1.AddServer("Server 1");
            balancer1.AddServer("Server 2");
            balancer1.AddServer("Server 3");
            balancer1.AddServer("Server 4");


            for (int i = 0; i < 100; i++) 
            {
                string server = balancer1.GetServer();
                Console.WriteLine("分發至server" + server);
            }


            Console.Read();
        }
    }
}