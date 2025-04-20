using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example1
{
    internal class Proxy : Subject
    {
        private RealSubject realSubject = new RealSubject();

        public void PreRequest() 
        {
            Console.WriteLine("PreRequest");
        }


        public override void Request()
        {
            PreRequest();
            realSubject.Request();
            PostRequest();
        }

        public void PostRequest() 
        {
            Console.WriteLine("PostRequest");
        }
    }
}
