using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Practice1
{
    internal class PhoneDecorator : Phone
    {
        private Phone phone;

        public PhoneDecorator(Phone phone)
        {
            this.phone = phone;
        }

        public override void Display()
        {
            phone.Display();
        }
    }
}
