using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Properties
{
    internal sealed class Cat : Animal // preventing subclassing Cat is nobodies parent
    {
        private readonly string _name;

        public int Number;

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
            return this._name;
        }
    }
}
