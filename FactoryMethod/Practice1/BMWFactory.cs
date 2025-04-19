using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice1
{
    internal class BMWFactory : ICarFactory
    {
        public BMWFactory() 
        {
            Console.WriteLine("產生BMW");
        }

        public ICar GetCar()
        {
            return new BMW();
        }
    }
}
