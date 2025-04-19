using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example1
{
    internal class Facade
    {
        private SubSystemA SubSystemA = new SubSystemA();
        private SubSystemB SubSystemB = new SubSystemB();
        private SubSystemC SubSystemC = new SubSystemC();

        public void Method() 
        {
            SubSystemA.MethodA();
            SubSystemB.MethodB();
            SubSystemC.MethodC();
        }
    }
}
