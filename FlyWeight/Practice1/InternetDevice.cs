using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Practice1
{
    internal abstract class InternetDevice
    {
        public abstract void Display();
        public abstract void Display(Port port);
    }
}