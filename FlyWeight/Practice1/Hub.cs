using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Practice1
{
    internal class Hub : InternetDevice
    {
        public override void Display()
        {
            Console.WriteLine("集線器");
        }

        public override void Display(Port port)
        {
            Console.WriteLine("集線器,port{0}", port.PortNumber);
        }
    }
}
