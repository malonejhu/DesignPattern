using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2
{
    internal class SummerFactory : SkinFactory
    {
        public Button CreateButton()
        {
            return new SummerButton();
        }

        public Combox CreateCombox()
        {
            return new SummerCombox();
        }

        public Text CreateText()
        {
            return new SummerText();
        }
    }
}
