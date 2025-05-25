using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Exampl1
{
    internal class ConcreteHandler : Handler
    {
        public override void HandleRequest(string request)
        {
            if (true)
            {

            }
            else 
            {
                Successor.HandleRequest(request);
            }
        }
    }
}