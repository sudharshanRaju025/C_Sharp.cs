using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
     class Methods
    {
        public void Add() //"In this Add method we are adding the elements to the list with various ways.
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(456);
            numbers.Add(679);
            numbers.Add(890);
            numbers.Insert(2, 234);
            int[] integers= { 2, 34, 45, 6, 6 };
            numbers.AddRange(integers);
            numbers.Sort();

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            int check = numbers.Find(n => n == 6);
            Console.WriteLine(check);

          
            
            
        }
    }
}
