using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example2
{
    internal abstract class AbstractFile
    {
        public string name { get; set; }
        public abstract void Add(AbstractFile file);
        public abstract void Remove(AbstractFile file);
        public abstract AbstractFile GetChild(int i);
        public abstract void ShowName(string name);
        public abstract void KillVirus();
    }
}
