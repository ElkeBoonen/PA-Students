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
            Search search = new Search();

            int[] nrs = Data.Numbers; //new int[] { -3, -1, 0, 1, 4, 7, 8 };

            int count;

            int number = 4;
            int pos = search.Simple(nrs, number, out count);
            Console.WriteLine($"Simple search: position of {number} is {pos} - loopcount {count}");

            pos = search.Stupid(nrs, number, out count);
            Console.WriteLine($"Stupid search: position of {number} is {pos} - loopcount {count}");

            pos = search.Binary(nrs, number, out count);
            Console.WriteLine($"Binary search: position of {number} is {pos} - loopcount {count}");
        }
    }
}
