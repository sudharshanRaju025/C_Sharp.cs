using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_practice
{
    class Poly2
    {
        public virtual void Method1()   //here we initiated one method.
        {
            Console.WriteLine("hii everyone");
        }
    }

    class Andhra_Pradesh : Poly2
    {
        public override void Method1() // here we are overriding the method of the Poly2 class.
        {
            Console.WriteLine("Namaskaram.");
        }
    }

    class Tamilnadu : Poly2
    {
      public override void Method1()  //herer also we are overriding the Poly2 classs method.
        {
            Console.WriteLine("vanakam");
        }
    }
}
