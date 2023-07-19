using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Properties
{
    internal abstract class Animal : Interface
    {
        public enum Direction { Left, Right }
        public int Gender { get; set; }

        public void InterfaceFunc()
        {
            System.Console.WriteLine("INTERFACE FUNCTION");
        }


        public abstract string MakeSound();
        public Animal(int gender) 
        {
            this.Gender = gender;
            System.Console.WriteLine("ANIMAL CONSTRUCTOR");
        }
    }
}
