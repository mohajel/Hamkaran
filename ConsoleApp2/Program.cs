using ConsoleApp2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void func(ref Cat c)
        {
            c.Gender = 12345;
        }

        static void Main(string[] args)
        {
            //System.Console.WriteLine("salam");
            //MyClass c1 = new MyClass();
            //c1.Name = "Test";
            //System.Console.WriteLine(c1.Name);



            // lets see ...

            Cat cat1 = new Cat(1, "smelly cat");

            Animal animal1 = cat1; // upcast always possible

            //Cat cat2 = (Cat)animal1; //If a downcast fails, an InvalidCastException is thrown.

            //// The as operator performs a downcast that evaluates to null (rather than throwing
            ////an exception) if the downcast fails
            //Cat sub3 = animal1 as Cat; // downcast with as

            //// best to use this approach for downcasting 
            //if (animal1 is Cat) 
            //{
            //    //.....
            //    ;
            //}

            // or better:
            if (animal1 is Cat c)
            {
                c.EeatFish();
            }

            // this is comman usage taht s used u can define with new(why should we)
            System.Console.WriteLine(cat1.MakeSound());     // MEOW
            System.Console.WriteLine(animal1.MakeSound());  // MEOW



            System.Console.WriteLine(cat1);



            // lets change one and see waht happens to other one is it pointer to same Object?

            Cat c3 = new Cat(2, "kitten");
            Cat c4 = c3;

            c3.Number = 8182;

            System.Console.WriteLine(c4.Number);

            Cat cat = new Cat(333, "hhh");
            System.Console.WriteLine(cat.Gender);

            func (ref cat);

            System.Console.WriteLine(cat.Gender);











        }
    }
}
