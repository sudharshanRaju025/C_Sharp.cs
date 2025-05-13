using System;
using System.ComponentModel.Design;
using System.Linq;
using DSA_Practice;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursion r = new Recursion();
            //r.Calculateiterative(6);
            //Console.WriteLine("tail recursive:");

            //r.CalculateTailrecursive(6);

            //Console.WriteLine("Head Recursive:");
            //r.CalculateHeadrecursive(6);
            //Console.WriteLine("head recusrion");
            //r.CalculateTreerecursive(6);
            //Console.ReadKey();

            //Factorial obj1 = new Factorial();
            //Console.WriteLine(obj1.Factorialiterative(3));

            //Console.WriteLine(obj1.Factorialrecursive(3));

            //SelectionSort sort = new SelectionSort();
            //int[] num = {1,22,3,4,11,45,76};

            //sort.Selectionsort(num, 7);
            //sort.display(num, 7);


            //int[] num1 = { 1, 2, 3 };
            //int[] num2 = { 1, 4, 6 };
            //sort.Triplesum(num1, num2, 3, 3);
            //Console.ReadLine();

            //int[] ints = { 87,92,90,199,190,203,84,66,189};
            //sort.Checking(ints, ints.Count());

            r.TreeRecursive(2);
        }
    }
}