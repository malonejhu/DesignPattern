﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice5
{
    internal class WindowsButton:IOSButton
    {
        public WindowsButton() 
        {
            Console.WriteLine("WindowsButton");
        }
    }
}
