using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example2
{
    internal interface Searcher
    {
        string DoSearch(string userId, string keyword);
    }
}
