using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice
{
     class MergeSort
    {
        public void Merge(List<int> A, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            List<int> B = new List<int>(new int[right + 1]);

            while (i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i++;
                }
                else
                {
                    B[k] = A[j];
                    j++;
                }
                k++;
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

        public void MergeSorting(List<int> A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSorting(A, left, mid);
                MergeSorting(A, mid + 1, right);
                Merge(A, left, mid, right);
            }
        }


        public void Display(List<int> A)
        {
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
