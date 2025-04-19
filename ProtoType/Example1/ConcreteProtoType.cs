using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Example1
{
    internal class ConcreteProtoType : ProtoType
    {
        private string attr;
        public string Attr 
        {
            get { return attr; }
            set { attr = value; }
        }
        public override ProtoType Clone()
        {
            ConcreteProtoType protoType= new ConcreteProtoType();
            protoType.Attr = attr;
            return protoType;
        }
    }
}