using ConsoleApp1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hello world in c#
            System.Console.WriteLine("hello world");

            //creating class!
            A a = new A(1234, 56);

            // NonCoalescingOperator assigns to sth else if value == null
            Console.WriteLine(a.NonCoalescingOperator());

            // Deconstructing
            var (_, m) = a;

            Console.WriteLine(a.NonCoalescingOperator()); //still exists!

        }


    }
}
