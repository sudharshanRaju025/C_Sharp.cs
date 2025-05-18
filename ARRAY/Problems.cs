using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY
{
    class Problems
    {
        public void method()
        {
            int i;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);

            }
        }
        
        public void Sum()
        {
            int sum = 0;
            int i;
            Console.WriteLine("enetr the number:");
            int number=Convert.ToInt32(Console.ReadLine()!);
            for (i = 0; i < number; i++)
            {
                sum += i;
                
            }
            Console.WriteLine(sum);
        }

        public void avg_sum()
        {
            int i; int sum = 0;
            Console.WriteLine("enter the number:");
            int number = Convert.ToInt32(Console.ReadLine()!);
            if (number > 0)
            {
                for (i = 0; i < number; i++)
                {
                    sum += i;

                }
                int avg_sum = sum / number;
                Console.WriteLine("The sum of the enterd numbers is:"+sum);
                Console.WriteLine("the average of the enterd numbers is:" + avg_sum);
                
            }
            else
            {
                Console.WriteLine("enter the proper number for doing the operation.");
            }
        }

        public void Cube(int[] A)
        {
           

            var cube = A.Select(i => i * i * i);
            foreach(int j in cube)
            {
                Console.WriteLine(j);
            }
        }
    }
}
