using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Practice1
{
    internal class BenzFactory : ICarFactory
    {
        public BenzFactory() 
        {
            Console.WriteLine("產生Benz");
        }

        public ICar GetCar()
        {
            return new Benz();
        }
    }
}
