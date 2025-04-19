using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2
{
    internal class SprinFactory : SkinFactory
    {
        public Button CreateButton()
        {
            return new SprinButton();
        }

        public Combox CreateCombox()
        {
            return new SprinCombox();
        }

        public Text CreateText()
        {
            return new SprinText();
        }
    }
}
