using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA_Practice
{   class Recursion
    {
        //public void Calculateiterative(int n)
        //{
        
        //    if (n > 0)
        //    {
        //        int k=n*n;
        //        Console.WriteLine(k);
        //        n = n - 1;

        //    }
        //}

        //public void CalculateTailrecursive(int n)//tail recursion
        //{
        //    if (n > 0)
        //    {
        //        int k=n*n;
        //        Console.WriteLine(k);
        //        CalculateTailrecursive(n - 1);
        //    }
        //}
        //public void CalculateHeadrecursive(int n)//head recusrion
        //{
        //    if (n > 0)
        //    {
        //        CalculateHeadrecursive(n - 1);
        //        int k = n * n;
        //        Console.WriteLine(k);
                
        //    }
        //}
        //public void CalculateTreerecursive(int n)//head recusrion
        //{
        //    if (n > 0)
        //    {
        //        CalculateTreerecursive(n - 1);
        //        int k = n * n;
        //        Console.WriteLine(k);
        //        CalculateTreerecursive(n - 1);

        //    }
        //}

        //public void TreeRecursive(int n)//tail recursion
        //{
        //    if (n > 0)
        //    {
        //        TreeRecursive(n - 1);
        //        int k = n * n;
        //        Console.WriteLine(k);
        //        TreeRecursive(n - 1);
        //    }
        //}
        public void CalculateRecursive(int i)
        {
            if (i > 0)
            {
                CalculateRecursive(i - 1);
                Console.WriteLine(i);
                CalculateRecursive(i - 1);
            }
        }
    }
}
