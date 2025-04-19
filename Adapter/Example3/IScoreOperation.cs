using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example3
{
    internal interface IScoreOperation
    {
        int[] Sort(int[] array);
        int Search(int[] array, int key);
    }
}
