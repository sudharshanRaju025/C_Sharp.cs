using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.cs
{
    class Linq
    {
        public static void Main(string[] args)
        {
            List<int> Names = new List<int>();

            Names.Add(189);
            Names.Add(2);
            Names.Add(24);
            Names.Add(20);
            Names.Add(237);
            Names.Add(45);
            Names.Add(234);
            Names.Add(298);
            Names.Add(13);
            Names.Add(197);
            Names.Add(37);


            var result = Names.OrderBy(n=>n).Reverse();
          foreach(int j in result)
            {
                Console.WriteLine(j);
            }

            //var result = Names.Where(n => n % 2 == 0);

            //var result = Names.OrderByDescending(n => n).Select(n => $"numbers:{n}");

            //int result = Names.Count(n => n %2!=0);

            //var result = Names.ElementAt(3);
            //var result = Names.Single(n => n == 19);


            //var result = Names.OrderBy(n=>n);
            //foreach(var i in result)
            //{
            //    Console.WriteLine(i);   
            //}


           // int[] result = Names.ToArray();
           //foreach(int j in result)
           // {
           //     Console.WriteLine(j);
            //}
            
        }
    }
}
