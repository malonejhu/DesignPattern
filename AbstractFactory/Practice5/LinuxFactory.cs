using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice5
{
    internal class LinuxFactory : IOSFactory
    {
        public IOSButton CreateButton()
        {
            return new LinuxButton(); 
        }

        public IOSText CreateOSText()
        {
            return new LinuxText();
        }
    }
}
