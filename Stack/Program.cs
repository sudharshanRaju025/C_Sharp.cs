using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(134);
            stack.Push(1321);
            stack.Push(198);
            stack.Push(364);
            stack.Push(100);

            int check=stack.Peek();
            Console.WriteLine(check);
            int remove = stack.Pop();
            Console.WriteLine(remove);


        }
    }
}
