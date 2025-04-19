using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice5
{
    internal class WindowsFactory : IOSFactory
    {
        public IOSButton CreateButton()
        {
            return new WindowsButton(); 
        }

        public IOSText CreateOSText()
        {
            return new WindowsText();
        }
    }
}
