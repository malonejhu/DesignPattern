using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Practice1
{
    internal class Office : BaseSite
    {
        public Office(string name) : base(name) { }
        public override void AddSite(BaseSite site)
        {
            Console.WriteLine("不支援該方法");
        }

        public override void Operation()
        {
            Console.WriteLine(this.Name);
        }
    }
}
