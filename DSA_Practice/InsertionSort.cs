using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice
{
    public class InsertionSort
    {
        public void InsertionSortMethod(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int Value = A[i];
                int Position = i;

                while (Position > 0 && A[Position - 1] > Value)
                {
                    A[Position] = A[Position - 1];
                    Position = Position - 1;
                }
                A[Position] = Value;
            }

        }
        public void display(int[] A,int n)
        {
            for(int i = 0;i < n; i++)

                Console.Write(A[i]+" ");

            Console.WriteLine();
        }
        
    }
}
