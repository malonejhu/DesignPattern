using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example2
{
    internal class Congress : Approver
    {
        public Congress(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            Console.WriteLine($"董事會{this.name}簽核採購單，{request.Number}金額{request.Amount}元，目的{request.Purpose}");
        }
    }
}
