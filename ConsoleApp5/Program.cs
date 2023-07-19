using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static public void Looping()
        {
            string s = "salam";

            // option A:
            IEnumerator enumerator = s.GetEnumerator();

            // enumerator. MoveNext() 
            // enumerator. Current() returns Object
            // enumerator. Reset() returns beginning

            while (enumerator.MoveNext()) 
            {
                char c = (char)enumerator.Current;
                Console.WriteLine(c + "-");
            }

            // option B:
            foreach (char c in s)
                Console.WriteLine(c + "-");
        }
        static void Main(string[] args)
        {
            Looping();
        }
    }
}
