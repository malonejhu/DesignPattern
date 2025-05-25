using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Practice2
{
    internal class Manager : Boss
    {
        public Manager(string name, Boss nextSignUser) : base(name, nextSignUser)
        {
        }

        public override void SignForm(int leaveDays)
        {
            if (leaveDays >= 3 && leaveDays<10)
            {
                Console.WriteLine($"請假天數{leaveDays}，{name}同意請假");
            }
            else
            {
                signUser.SignForm(leaveDays);
            }
        }
    }
}
