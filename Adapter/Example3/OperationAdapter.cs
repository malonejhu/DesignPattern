using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example3
{
    internal class OperationAdapter:IScoreOperation
    {
        private QuickSortClass QuickSortClass;
        private BinarySearchClass BinarySearchClass;

        public OperationAdapter() 
        {
            QuickSortClass = new QuickSortClass();
            BinarySearchClass = new BinarySearchClass();
        }

        public int[] Sort(int[] array) 
        {
            return QuickSortClass.QuickSort(array);
        }

        public int Search(int[] array, int key) 
        {
            return BinarySearchClass.BinarySearch(array, key);
        }
    }
}
