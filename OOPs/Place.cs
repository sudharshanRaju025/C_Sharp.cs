using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_practice
{

    class Place
    {
        public virtual void Method(string name,double phone_no,string place, string comapny_name,int id)
        {
         
        }
    }

    //class Company : Place
    //{
    //    public override void Method(string name,string place, int id = 12002011)
    //    {
    //        Console.WriteLine("Name of the employee:"+name);
    //        Console.WriteLine($"{name} born place is:"+place);
            
    //    }
    //}

    class Company2 : Place 
    {
        public override void Method(string name,double phone_no,string place, string comapny_name = "P99SOFT", int id = 12002008)
        {
            comapny_name = comapny_name.ToUpper();
            Console.WriteLine("enter the company_name:");
            string NAME=Console.ReadLine()!;
                if (NAME == "P99SOFT")
                {
                    Console.WriteLine("entering into the comapny website.....");
                }
                else
                {
                   Console.WriteLine("check the company_name");
                   Environment.Exit(0);
                }
            Console.WriteLine("enter the id of the employee:");
            int num = Convert.ToInt32(Console.ReadLine());
                if (num == 12002008)
                {
                    Console.WriteLine("login successful");
                }
                else
                {
                    Console.WriteLine("please eneter the valid id.");
                    Environment.Exit(0);
                }
            Console.WriteLine($"employee name is:" + name.Trim());
            Console.WriteLine($"{name} phone number is "+phone_no);
            Console.WriteLine($"{name} is born in:" + place);
            Console.WriteLine($"{name} id :-" + id);
            Console.WriteLine($"Company name:" + comapny_name);
            
            
        }

    }
}
