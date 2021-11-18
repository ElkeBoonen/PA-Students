using System;
using System.Collections.Generic;
using System.Linq;

namespace DC___DSPS
{
    class Program
    {
        static void Print(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            DC dc = new DC();

            Console.WriteLine(dc.Squares(168,64));
            Console.WriteLine(dc.Squares(80, 20));

            Console.WriteLine(dc.SquaresIterative(168, 64));
            Console.WriteLine(dc.SquaresIterative(80, 20));

            int[] array = { -1, 5, 8, 7, 10, -5, 6, 3, 4, 1, 2 };
            Console.WriteLine(dc.SumIterative(array));
            Console.WriteLine(dc.Sum(0,array));
            Console.WriteLine(dc.Sum(array.ToList()));
            Console.WriteLine(dc.SumOne(array.ToList()));

            Print(array);
            Print(dc.QuickSort(array.ToList()));

            dc.Hanoi(10, 'A', 'C', 'B');
        }
    }
}
