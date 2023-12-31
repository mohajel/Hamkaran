﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        // Multiuse attribute.
        [System.AttributeUsage(System.AttributeTargets.Class |
                               System.AttributeTargets.Struct,
                               AllowMultiple = true)  // Multiuse attribute.
        ]
        public class AuthorAttribute : System.Attribute
        {
            string Name;
            public double Version;

            public AuthorAttribute(string name)
            {
                Name = name;

                // Default value.
                Version = 1.0;
            }

            public string GetName() => Name;
        }

        // Class with the Author attribute.
        [Author("P. Ackerman")]
        public class FirstClass
        {
            // ...
        }

        // Class without the Author attribute.
        public class SecondClass
        {
            // ...
        }

        // Class with multiple Author attributes.
        [Author("P. Ackerman"), Author("R. Koch", Version = 2.0)]
        public class ThirdClass
        {
            // ...
        }

        public class TestAuthorAttribute
        {
            public static void Test()
            {
                PrintAuthorInfo(typeof(FirstClass));
                PrintAuthorInfo(typeof(SecondClass));
                PrintAuthorInfo(typeof(ThirdClass));
            }

            private static void PrintAuthorInfo(System.Type t)
            {
                System.Console.WriteLine($"Author information for {t}");

                // Using reflection.
                System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.

                // Displaying output.
                foreach (System.Attribute attr in attrs)
                {
                    if (attr is AuthorAttribute a)
                    {
                        System.Console.WriteLine($"   {a.GetName()}, version {a.Version:f}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            TestAuthorAttribute.Test();
        }
        /* Output:
        Author information for FirstClass
           P. Ackerman, version 1.00
        Author information for SecondClass
        Author information for ThirdClass
           R. Koch, version 2.00
           P. Ackerman, version 1.00
*/
    }
}
