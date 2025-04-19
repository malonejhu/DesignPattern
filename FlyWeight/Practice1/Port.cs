using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Practice1
{
    internal class Port
    {
        public Port(string portNumber)
        {
            this.PortNumber = portNumber;
        }
        public string PortNumber { get; set; }
    }
}
