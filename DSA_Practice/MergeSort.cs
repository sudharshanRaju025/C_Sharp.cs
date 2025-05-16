using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice
{
     class MergeSort
    {
        public void MergeSorting(int[] A, int left,int right)
        {
             left = A[0];
             right = A[A.Count()];
            if (left < right)
            {
               int mid = (left + right) / 2;
                MergeSorting(A, left, mid);
                MergeSorting(A, right, mid+1);
            }
        }
        public void Merge(int[] A,int left,int right,int mid)
        {
            int i = left;
            int j = right;

        }
    }
}
