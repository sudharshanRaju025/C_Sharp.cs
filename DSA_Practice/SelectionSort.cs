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

        public void Triplesum(int[] A, int[] B, int k, int l)
        {
            for (int i = 0; i <= k - 1; i++)
            
               
                if (A[i] == B[i])
                {
                    Console.WriteLine((A[i] + B[i]) * 3);
                }
                else
                {
                    Console.WriteLine(A[i] + B[i]);
                }

            
        }
        public void AbsoluteDiff(int[] A,int l)   //{ 12, 34, 57, 87, 23, 46 }
        {
            for(int i = 0; i <= l - 1; i++)
            {
                if (A[i] > 51)    //39 17 18 - 6 108 - 36 28 5
                {
                    Console.WriteLine((A[i] - 51) * 3);
                }
                else
                {
                    Console.WriteLine(51 - A[i]);
                }
            }
        }

        public void Checking(int[] A,int k)
        {
            for(int i = 0; i <= k-1; i++)
            {
                if (A[i]>=90 && A[i] <= 110)
                {
                    Console.WriteLine("True");
                }
                else if (A[i]>=190 && A[i] <= 210)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
       

    }
}
