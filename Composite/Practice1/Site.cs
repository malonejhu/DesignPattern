using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Practice1
{
    internal class Site : BaseSite
    {
        private List<BaseSite> site = new List<BaseSite>();
        public Site(string name):base(name) { }

        public override void AddSite(BaseSite site)
        {
            this.site.Add(site);
        }

        public override void Operation()
        {
            Console.WriteLine(this.Name+"：");
            foreach (var item in site) 
            {
                item.Operation();
            }
        }
    }
}
