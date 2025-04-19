using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2
{
    internal interface SkinFactory
    {
        Button CreateButton();
        Text CreateText();
        Combox CreateCombox();
    }
}
