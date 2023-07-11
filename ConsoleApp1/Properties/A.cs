using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Properties
{
    internal class A
    {
        // static read only vs const
        // static read only can change in each run time and is initilied only in constructor or declration
        // const is replaced in compile time exactuly like #define in c++(I guess)
        const int x = 12;
        readonly int y = 13; // Field initializations occur before the constructor is executed

        // constructor
        public A(int m)
        {
            y = m;
            System.Console.WriteLine($"inside A FIRST constructor x={x}, y={y} ");
        }

        //stupid deconstructor in c#
        public void Deconstruct(out int width, out int height)
        {
            width = x;
            height = this.y;
        }
        // overloading constructor
        public A(int m, int n)
            :
            this(m) // calling first constructor
        {
            System.Console.WriteLine($"inside A SECOND constructor");
        }

        public string NonCoalescingOperator()
        {
            string s1 = null;
            return s1 ?? "NOTHING";
        }

        public string a;

        // Property initializers
        public decimal CurrentPrice { get; set; } = 123;

        decimal currentPrice;
        public decimal Worth
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }
    }

}
