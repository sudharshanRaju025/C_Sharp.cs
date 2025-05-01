using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace oop_practice
{
    internal class C
    {
        public static void Method()
        {
            Console.WriteLine("enter the number:");
            int num1 =Convert.ToInt32( Console.ReadLine())!;
            Console.WriteLine("enter the number:");
            int num2 = Convert.ToInt32(Console.ReadLine())!;

            Console.WriteLine("enter the operation:");
            string NUM = Console.ReadLine()!;

            if (NUM == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (NUM == "-")
            {
                
                Console.WriteLine(num1 - num2);
            }
            else if (NUM == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                if (num2 == 0)
                {
                    Console.WriteLine("the value is undefined");
                }
                else
                {
                    Console.WriteLine(num1 / num2);
                }
            }
        }

    }
    }

