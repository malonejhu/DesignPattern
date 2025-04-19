using ProtoType.Example2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Example3
{
    internal class ConcreteProtoTypeB : ICloneable
    {
        private Member member;

        public Member Member 
        {
            get { return member; }
            set { member = value; }
        }
        public object Clone()
        {
            ConcreteProtoTypeB copy = (ConcreteProtoTypeB)this.MemberwiseClone();
            Member newMember = new Member();
            copy.Member = newMember;
            return copy;
        }
    }
}
