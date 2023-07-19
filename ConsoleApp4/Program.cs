using ConsoleApp4.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void StringFuncs()
        {
            System.Console.WriteLine("...string .NET...");
            char[] chars = "hello".ToCharArray();

            string input = "Hello,world;foo|bar";
            char[] delimiters = { ',', ';', '|' };
            string[] parts = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
            int x = 2;
            System.Console.WriteLine($"x = {x}");



        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("salam");
            Cat cat = new Cat(12, "swalam");

            //StringFuncs();    
            List<Cat> list = new List<Cat>
            {
                { new Cat(12, "pishyy")},
                { new Cat(11, "pishyy")},
                { new Cat(122, "pishyy")},
                { new Cat(1233, "pishyy")},
                { new Cat(112, "pishyy")}
            };

            list.Sort();

            foreach (var catty in list)
            {
                Console.WriteLine(catty);
            }
            
        }   
    }
}
