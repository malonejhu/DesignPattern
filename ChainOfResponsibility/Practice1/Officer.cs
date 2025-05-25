using ChainOfResponsibility.Example2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Practice1
{
    internal abstract class Officer
    {
        protected string Name;
        protected Officer successor;

        public Officer(string name)
        {
            this.Name = name;
        }

        public void SetSuccessor(Officer successor)
        {
            this.successor = successor;
        }

        public abstract void SendMessage(int enemy);
    }
}