using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Exampl1
{
    public abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler Successor) 
        {
            this.Successor = Successor;
        }

        public abstract void HandleRequest(string request);
    }
}