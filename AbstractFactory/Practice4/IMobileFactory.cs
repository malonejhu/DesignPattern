﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice4
{
    internal interface IMobileFactory
    {
        IOperation CreateOperation();
        IUI CreateUI();
    }
}
