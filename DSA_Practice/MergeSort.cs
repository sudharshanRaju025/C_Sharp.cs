using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice
{
     class MergeSort
    {
        public void Merge(int[] A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int[] B = new int[right + 1];
            while (i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i++;
                    k++;
                }
                else
                {
                    B[k] = A[j];
                    j++;
                    k++;
                }

            }
            while (i <= mid)
            {
                B[k] = A[i];
                i++;
                k++;
            }
            while (j <= right)
            {
                B[k] = A[j];
                j++;
                k++;
            }
            for (int x = left; x <= right; x++)
            {
                A[x] = B[x];
            }


        }
        public void MergeSorting(int[] A, int left,int right)
        {
           
            if (left < right)
            {
               int mid = (left + right) / 2;
                MergeSorting(A,left, mid);
                MergeSorting(A,mid+1,right);
                Merge(A, left, mid, right);
            }
        }
       
        public void display(int[] A,int n)
        {
            for(int i = 0; i < A.Count(); i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}
