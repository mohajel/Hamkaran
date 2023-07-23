using ClassLibrary1;
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

            // or
            //var x = list.GetEnumerator();

            //while (x.MoveNext())
            //{
            //    Console.WriteLine(x.Current);
            //}


            //IEnumerable<Cat> iEnumerableOfCats = (IEnumerable<Cat>)list;

            //foreach (var catty in iEnumerableOfCats)
            //{
            //    Console.WriteLine(catty);
            //}


            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net"); // uniqe values
            dct.Add(4, "vb.net");
            //foreach (KeyValuePair<int, string> kvp in dct)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);
            //}
            Console.WriteLine(dct[1]);

            //Students s = new Students();
            //Console.WriteLine(s.GetName());








        }
    }
}
