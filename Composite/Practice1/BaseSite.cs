using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Practice1
{
    internal abstract class BaseSite
    {
        protected string Name { get; set; }
        public BaseSite(string name)
        {
            Name = name;
        }

        public abstract void Operation();
        public abstract void AddSite(BaseSite site);
    }
}