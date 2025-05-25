using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example2
{
    internal class Director : Approver
    {
        public Director(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 50000)
            {
                Console.WriteLine($"主任{this.name}簽核採購單，{request.Number}金額{request.Amount}元，目的{request.Purpose}");
            }
            else 
            {
                this.successor.ProcessRequest(request);
            }
        }
    }
}