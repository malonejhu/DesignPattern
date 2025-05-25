using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Practice2
{
    internal abstract class Boss
    {
        protected string name;
        protected Boss signUser;

        public Boss(string name, Boss nextSignUser=null)
        {
            this.name = name;
            signUser = nextSignUser;
        }

        public abstract void SignForm(int leaveDays);
    }
}
