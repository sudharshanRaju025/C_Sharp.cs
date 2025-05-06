using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice
{
    class Factorial
    {
        public int Factorialiterative(int n)//iterative method.
        {
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
            
        }
        public int Factorialrecursive(int n)//recursion method(tail).
        {
            if (n == 0)
            {
                return 1;
            }
            return Factorialrecursive(n - 1) * n;
        }
    }
}
