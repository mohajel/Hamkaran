using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static IEnumerable<int> Fibonacci()
        {
            int a = 0;
            int b = 1;
            while (true)
            {
                yield return a;
                int temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine("looping");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci().ElementAt(4)); // nice job
            Console.WriteLine("--BREAK--"); // nice job
            Console.WriteLine(Fibonacci().ElementAt(4)); // nice job
            //foreach (int i in Fibonacci().Take(10))
            //{
            //    Console.WriteLine(i);
            //} 
        }
    }
}
