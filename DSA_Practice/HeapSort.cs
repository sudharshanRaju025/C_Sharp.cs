using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice
{
    class Heap
    {

    }
     class HeapSort
    {
        public void HeapSortMethod(int[] A,int n)
        {
            Heap heap1 = new Heap();
            for(int i=0; i<A.Length; i++)
            {
                heap1.insert(A[i]);
            }

        }
    }
}
