using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_practice
{
    public class Encapsulation
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("enter the positive number.");
                }
            }
        }
    }

    //class Access
    //{
    //    public void Method()
    //    {
    //        //Encapsulation obj1 = new Encapsulation();
    //        //obj1.Name = "sudharshan";
    //        //obj1.Age = 23;

    //        //Console.WriteLine(obj1.Name);
    //        //Console.WriteLine(obj1.Age);
    //    }
    //}
}
