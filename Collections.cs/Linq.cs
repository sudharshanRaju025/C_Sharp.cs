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
            //List<int> Names = new List<int>();

            //Names.Add(189);
            //Names.Add(2);
            //Names.Add(2);
            //Names.Add(20);
            //Names.Add(2);
            //Names.Add(45);
            //Names.Add(2);
            //Names.Add(298);
            //Names.Add(13);
            //Names.Add(13);
            //Names.Add(14);
            //Names.Add(14);
            //Names.Add(197);
            //Names.Add(3);
            //Names.Add(3);

            //List<int> list2 = new List<int> { 3, 4, 5, 6 };


            //var result = Names.Union(list2);

            //foreach(int i in result)
            //{
            //    Console.WriteLine($"element :{i}");
            //}
            //order by descending
            //var result = Names.Where(n=>n%2!=0).Distinct().OrderDescending();
            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //square of the each element in the array
            //var result = Names.Select(x => x * x);
            //foreach(int j in result){
            //    Console.WriteLine(j);
            //}

            //var result = Names.Where(n=> n>90 && n<150).OrderBy(n=>n);
            //foreach(int j in result)
            //{
            //    Console.WriteLine(j);
            //}

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


            //List<string> fruits = new List<string>{ "Appley", "Bnanaa", "Cherryt", "Delta-42", "EchoStream", "FriendlyFox", "Green_Tiger",
            //                  "HorizonSky", "IndigoMoon", "JupiterRise", "Kaleidoscope", "LavaLamp", "MysticRiver",
            //                  "NeonNights", "OceanWave", "PixelRain", "QuantumLeap", "RocketFuel", "Sunflower_99",
            //                  "TurboDrive" };

            //List<string> fruits1 = new List<string> {"Umbra_Shade", "VelvetDusk", "WildCanyon", "XenonFlash", "YellowZebra",
            //                  "ZeroGravity", "AlphaByte", "BetaFusion", "CircuitBoard", "DragonFruit", "ElectricSheep",
            //                  "Frostbite", "GalaxyCore", "HyperlinkHero", "IceCreamMan", "JavaBeans", "Kryptonite",
            //                  "LightningBolt", "MarbleMaze", "NutmegDust", "Orbitron", "PrismLight", "QuokkaJump",
            //                  "RainbowDash", "SnowGlider","hiiiii", "ThunderEcho", "UltraNova", "VaporTrail", "WindWhisper",
            //                  "ZenGarden"};

            //var All = fruits.SelectMany(f => f);
            //foreach (var f in All)
            //{
            //    Console.WriteLine(f);
            //}
            //var length=fruits.Single(x=>x.Length==7);

            //Console.WriteLine(length);



            //bool result = fruits1.Any( s => s.StartsWith("C"));
            //Console.WriteLine(result);

            //var result_set = name_set.Union(name_set1).OrderBy(x => x);

            // int count=result_set.Count();
            //Console.WriteLine(count);

            //foreach (string i in result_set)
            //{
            //    Console.WriteLine(i);
            //}


           

            //"getting of the number and their square root"
            //var result = numbers.Select(x => x  *x );
            //var combined = result.Zip(numbers, (number, square_no) => new { number, square_no });
            //List<int> num1 = result.ToList();
            //foreach(var j in combined)
            //{
            //    Console.WriteLine(j);
            //}


            //"counting of the number of times element is repeated."
            //var result = numbers.GroupBy(x => x).Select(group => new { number = group.Key, Count = group.Count() });

            //Console.WriteLine("frequency list");
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}


            //"counting the number of frequncy occurs for the char in string".
            //Console.WriteLine("enter the string:");
            //string name=Console.ReadLine()!;
            //var frequency = name.GroupBy(x => x).Select(group => new { character = group.Key, frequency = group.Count() });

            //foreach (var i in frequency)
            //{
            //    Console.WriteLine(i);
            //}

            List<int> numbers = new List<int> { 1, 2, 3, 43, 5, 45, 32, 3, 567, 876, 654, 568 };

            //var result = numbers.Where(x => x > 80);
            //foreach(var i in result)
            //{
            //    Console.WriteLine(i);
            //}


            //"getting of results from input number"
            //Console.WriteLine("enter the number we want to greater than it:"); 
            //int number=Convert.ToInt32(Console.ReadLine());

            //var result = numbers.Where(x => x > number);
            //foreach(var i in result)
            //{
            //    Console.WriteLine(i);
            //}


           
        }
    }
    
}
