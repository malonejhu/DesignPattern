using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Practice1
{
    internal class JarPhone : PhoneDecorator
    {
        public JarPhone(Phone phone) : base(phone)
        {
        }

        public override void Display()
        {
            AddJar();
            base.Display();
        }

        public void AddJar() 
        {
            Console.WriteLine("增加來電震動功能");
        }
    }
}
