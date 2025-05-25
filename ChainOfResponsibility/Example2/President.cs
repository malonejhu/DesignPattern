using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Example2
{
    internal class President : Approver
    {
        public President(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 500000)
            {
                Console.WriteLine($"董事長{this.name}簽核採購單，{request.Number}金額{request.Amount}元，目的{request.Purpose}");
            }
            else
            {
                this.successor.ProcessRequest(request);
            }
        }
    }
}
