using System;

namespace Linked_list
{
    class Program 
    
    {
        static void Main(string[] args)
        {
            //LinkedList<string> linklist = new LinkedList<string>();

            //linklist.AddLast("sinchan");
            //linklist.AddFirst("sudha");
            //linklist.AddLast("lakshmi");
            //linklist.AddLast("seshu");
            //linklist.AddLast("krishna");
            //linklist.AddLast("geethika");
            //linklist.AddLast("chandra");

            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //list.Remove("lakshmi");
            //list.RemoveFirst();
            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.RemoveLast();
            //foreach(string i in list)
            //{
            //    Console.WriteLine(i);
            //}


            //"reverse of linkedlist"
            //Console.Write("linklist elements:\n");
            //foreach (string l in linklist) 
            //{ 

            //        Console.WriteLine(l);
            //    }

            //LinkedList<string> reverse = new LinkedList<string>();


            //foreach(string j in linklist)
            //{
            //    reverse.AddFirst(j);
            //}


            //Console.WriteLine("reverse linkedlist elements:");
            //foreach (string name in reverse)
            //{ 

            //            Console.WriteLine( name);

            //}



            //"merging of linkedlist".
            LinkedList<int> linklist1 = new LinkedList<int>();
            linklist1.AddFirst(1);
            linklist1.AddFirst(2);
            linklist1.AddFirst(89);
            linklist1.AddFirst(9);
            linklist1.AddFirst(10);
            linklist1.AddFirst(98);
            linklist1.AddFirst(67);

           
            LinkedList<int> linklist2=new LinkedList<int>();
            linklist2.AddFirst(110);
            linklist2.AddFirst(124);
            linklist2.AddFirst(131);
            linklist2.AddFirst(130);
            linklist2.AddFirst(143);
            linklist2.AddFirst(193);


            foreach (int i in linklist1)
            {
                linklist2.AddFirst(i);
            }


            List<int> list = new List<int>(linklist2);

            list.Sort();

            LinkedList<int> final = new LinkedList<int>(list);

            foreach(int j in final)
            {
                Console.WriteLine(j);
            }
           


        }
    }

}