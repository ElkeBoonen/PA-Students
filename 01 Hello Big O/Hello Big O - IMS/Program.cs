using System;
using TM.ProgrammingAdvanced;

namespace Hello_Big_O
{
    class Program
    {
        static void Print(int[] array)
        {
            foreach (var item in array) Console.Write(item + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] nrs = Data.Numbers;
            //Print(nrs);

            Search search = new Search();
            int number = 0;

            int count;

            Console.WriteLine($"SIMPLE: position of {number} is {search.Simple(nrs, number, out count)} - loopcount {count}");
            Console.WriteLine($"STUPID: position of {number} is {search.Stupid(nrs, number, out count)} - loopcount {count}");
            Console.WriteLine($"BINARY: position of {number} is {search.Binary(nrs, number, out count)} - loopcount {count}");

        }
    }
}
