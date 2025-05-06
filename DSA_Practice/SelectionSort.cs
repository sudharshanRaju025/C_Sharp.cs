using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice
{
    class SelectionSort
    {
        public void Selectionsort(int[] A,int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int position = i;
                for (int j = i+1; j < n; j++)
                {

                    if (A[j] < A[position])
                    {

                        position = j;
                    }
                }
                int temp = A[i]; ;
                A[i] = A[position];
                A[position] = temp;
                
            }
        }
        public void display(int[] A,int n)
        {
            for(int i=0;i< n ; i++)
            {
                Console.WriteLine(A[i]+" ");
                Console.WriteLine();

            }
        }
    }
}
