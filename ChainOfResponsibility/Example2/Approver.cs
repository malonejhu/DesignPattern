using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example2
{
    internal abstract class Approver
    {
        protected Approver successor;
        protected string name;

        public Approver(string name)
        {
            this.name = name;
        }

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(PurchaseRequest request);
    }
}