using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        public async void ComputeSth(int number)
        {
            int result = await Func(23);
            Console.WriteLine(result);
        }

        public static Task<int> Func(int number) 
        {
            //wth!
        }

        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++) // threads share inputs
            //    new Thread(() => Console.Write(i)).Start();

            // thread pool
            //Task<int> result = Task.Run(() => { Console.WriteLine("\nsalaam bala jan"); return 12; }); 
            //int res = result.Result;
            //Console.WriteLine(res);
        }
    }
}
