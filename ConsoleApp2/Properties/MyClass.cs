using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Properties
{
    //Adding the ref modifier to a struct’s declaration ensures that it can only ever reside
    //on the stack.Attempting to use a ref struct in such a way that it could reside on the
    //heap generates a compile-time error.

    ref struct Point { public int X, Y; } // cant be used in heap (classes) 

    internal class MyClass
    {
        public MyClass() { }
        public string Name { get; set; }

        // indexer 
        public string[] sth = "a,b,c,d,e,f".Split();
        public string this[int i] { get { return sth[i]; } set { sth[i] = value; } }

        // destructor is called finalizer here
        ~MyClass() 
        {
            Console.WriteLine("finalizer");
        }


    }
}
