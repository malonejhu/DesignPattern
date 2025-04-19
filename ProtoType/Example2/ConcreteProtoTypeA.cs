using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Example2
{
    internal class ConcreteProtoTypeA
    {
        private Member member;
        public ConcreteProtoTypeA() 
        {
            member = new Member();
        }

        public Member Member 
        {
            get { return member; }
            set { member = value; }
        }


        public ConcreteProtoTypeA Clone() 
        {
            return (ConcreteProtoTypeA)this.MemberwiseClone();
        }
    }
}