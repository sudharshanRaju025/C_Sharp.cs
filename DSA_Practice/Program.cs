using System;
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

            Factorial obj1 = new Factorial();
            Console.WriteLine(obj1.Factorialiterative(3));

            Console.WriteLine(obj1.Factorialrecursive(3));
        }
    }
}