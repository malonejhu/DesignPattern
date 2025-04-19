using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practice2
{
    internal class HaierFactory : IFactory
    {
        public IConditioner CreateConditioner()
        {
            return new HaierConditioner();
        }

        public ITV CreateTV()
        {
            return new HaierTV();
        }
    }
}
