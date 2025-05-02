using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Globalization;
using ARRAY;

namespace ArrayIndexExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers= { 1,2,4,55,6,8,20,30,40,68};

            //Array.Sort(numbers);
            //int Index = Array.BinarySearch(numbers, 8);
            //Console.WriteLine(Index);




            //bool check = numbers.Contains(8);
            //Console.WriteLine(check);
            //"sum of the elements in the array".
            // int index = Array.IndexOf(fruits,1);

            // if (index >= 0)
            //     Console.WriteLine($"First even is at {index} with element {fruits[index]}");
            // else
            //     Console.WriteLine("'even number' not found");



            //int sum = 0;
            //for(int i = 0; i <numbers.Length; i++)
            //{
            //    Console.WriteLine($"At the position of {i} the element is present {numbers[i]}");
            //    sum += numbers[i];
            //}
            //Console.WriteLine("the sum of the elements in the array is:"+sum)



            //"finding maximum number in the array"
            //int max = numbers[0];           

            //for (int i=0;i<numbers.Length;i++)
            //{
            //    if (max < numbers[i])
            //    {
            //        max = numbers[i];

            //    }
            //    else
            //    {
            //        max = numbers[0];
            //    }
            //}
            //Console.WriteLine($"the maximum number in the array is {max}");



            //clear the required elements in array.
            //Array.Clear(numbers, 0, 2);
            //foreach(var i in numbers)
            //{
            //    Console.WriteLine(i);


            //copy method
            //int[] another = new int[numbers.Length];
            //numbers.CopyTo( another,0);
            //foreach(var j in another)
            //{
            //    Console.WriteLine(j);
            //}



            //arthmetic operations.
            //double average = numbers.Average();
            //Console.WriteLine($"the average of the numbers array elements is:"+average);

            //int max = numbers.Max();
            //Console.WriteLine($"the maximum element in the numbers array is:"+max);

            //int min = numbers.Min();
            //Console.WriteLine($"the minimum value of element in the numbers array is:"+min);


            //int sum = numbers.Sum();
            //Console.WriteLine($"the sum of the numbers array elements is:"+sum);


            //filter method for creating of another array using existed array.
            //int[] filterd = numbers.Where(n => n > 20).ToArray();

            //foreach(var i in  filterd)

            //    {
            //    Console.WriteLine(i);
            //    }



            //"contain method"
            //bool checking = numbers.Contains(29);
            //Console.WriteLine(checking);



            //"sorting(LINQ)"
            //var descending = numbers.OrderByDescending(x => x).ToArray();
            //foreach(var j in descending)
            //{
            //    Console.WriteLine(j);
            //}



            //"Distinct Method".
            //var distinct = numbers.Distinct().ToArray();
            //foreach(var k in numbers)
            //{
            //    Console.WriteLine(k);
            //}



            //"Stack".
            //Stack<int> stack = new Stack<int>();

            //stack.Push(19);
            //stack.Push(22);
            //stack.Push(26);
            //stack.Push(89);
            //stack.Push(30);

            //int first_element = stack.Peek();
            //stack.Pop();
            //stack.Push(86);
            //int count=stack.Count();
            //Console .WriteLine(count);
            //foreach(var i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(first_element);



            //"queue".
            //Queue<string> strings = new Queue<string>();

            //strings.Enqueue("sinchan");
            //strings.Enqueue("keerthi");
            //strings.Enqueue("lakshmi");
            //strings.Enqueue("sudha");
            //strings.Enqueue("moksha");

            //strings.Dequeue();
            //string name = strings.Peek();
            //Console.WriteLine(name);
            //Console.WriteLine();


            //foreach(var i in strings)
            //{
            //    Console.WriteLine(i);
            //}


            //"REVERSE OF AN ARRAY".
            //int[] numbers= {1,2,4,55,6,8,20,30,40,68};
            //int[] reverse = new int[numbers.Length];
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    reverse[i] = numbers[numbers.Length - 1 - i];

            //}
            ////foreach(int j in reverse)
            ////{
            ////    Console.WriteLine(j);
            ////}
            //Array.Reverse(reverse);
            //for (int i = 0; i <reverse.Length;i++)
            //{
            //    Console.WriteLine($"The element at {i} is :"+reverse[i]);
            //}


            //"manuak way of summing of array elemets".
            //int[] numbers = { 12, 23, 32, 12, 45, 56, 67, 87, 87, 432, 1, 12, 2, 3, 4, 5 };
            //int Sum = 0;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Sum = Sum + numbers[i];

            //}
            //Console.WriteLine($"the sum of the elements in the array is:"+Sum);


            //int[] even_array = new int[numbers.Length];
            //int[] odd_array = new int[numbers.Length];

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        even_array[i] = numbers[i];
            //    }
            //    else
            //    {

            //    }
            //}

            //Console.WriteLine("Even array:");
            //foreach(int J in  even_array)
            //{
            //    Console.WriteLine($"even element: "+J);
            //}
            //Console.WriteLine("odd array:");
            //foreach(int l in odd_array)
            //{
            //    Console.WriteLine($" odd element: "+l);
            //}


            //Stack<string> stack = new Stack<string>();

            //stack.Push("h");
            //stack.Push("e");
            //stack.Push("l");
            //stack.Push("l");
            //stack.Push("o");

            //Stack<string> reverse=new Stack<string>();

            //foreach(string i in stack)
            //{
            //    stack.Pop();






            //getting of unique elements in array.
            //int[] array = { 1, 2, 3, 4, 6, 74, 3, 2, 1 };

            //Dictionary<int,int> frequency=new Dictionary<int,int>();

            //foreach(int j in array)
            //{
            //    if (frequency.ContainsKey(j))
            //    {
            //        frequency[j]++;
            //    }
            //    else
            //    {
            //        frequency[j] = 1;
            //    }
            //}

            //Console.WriteLine("the number of duplicate elements in the array:");
            //int total = 0;
            //foreach (var i in frequency)
            //{

            //    if (i.Value ==1)
            //    {

            //        Console.WriteLine($"the unique elemet {i.Key}");
            //        total += 1;
            //    }
            //}
            //Console.WriteLine($"total number of unique elements:"+total);

            Linear linear = new Linear();
            int[] A = { 12, 23, 34, 556, 100 };
            int final = linear.Linearsearch(A, 5, 556);
            Console.WriteLine($"The index of the element is:"+final);
            Console.ReadLine();

        }

    }
}
