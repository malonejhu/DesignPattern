using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Practice1
{
    internal class LightPhone : PhoneDecorator
    {
        public LightPhone(Phone phone) : base(phone)
        {
        }

        public override void Display()
        {
            AddLight();
            base.Display();
        }

        public void AddLight() 
        {
            Console.WriteLine("增加閃光功能");
        }
    }
}
