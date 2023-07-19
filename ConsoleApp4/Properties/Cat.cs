using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Properties
{
    internal sealed class Cat : Animal, IComparable<Cat>// preventing subclassing Cat is nobodies parent
    {
        private readonly string _name;

        public int Number;


        public int Data { get; private set; }

        // If a constructor in a subclass omits the base keyword, the base type’s parameterless
        // constructor is implicitly called.
        public Cat(int gender, string name)
            :
            base(gender)
        {
            System.Console.WriteLine("CAT CONSTRUCTOR");
            this._name = name;
        }

        public void EeatFish()
        {
            Console.WriteLine("EATING FISH");
        }
        public override string MakeSound() => "MEOW\n";

        public override string ToString()
        {
            return this.Gender.ToString();
        }

        public int CompareTo(Cat other)
        {
            return Gender.CompareTo(other.Gender);
        }
    }
}
