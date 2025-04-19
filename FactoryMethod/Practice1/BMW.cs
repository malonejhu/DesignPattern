using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice1
{
    internal class BMW : ICar
    {
        public void Show()
        {
            Console.WriteLine("I'm BMW");
        }
    }
}
