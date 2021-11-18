using System;
using System.Collections.Generic;
using System.Linq;

namespace DC___IMS
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
            Console.WriteLine(dc.Squares(168, 64));
            Console.WriteLine(dc.SquaresSlides(168, 64));
            Console.WriteLine(dc.SquaresIterative(168, 64));

            int[] array = { 2, 6, 4 };
            Console.WriteLine(dc.SumIterative(array));
            Console.WriteLine(dc.Sum(0, array));
            Console.WriteLine(dc.SumAron(array, 0));
            Console.WriteLine(dc.SumSlides(array.ToList()));

            array = new int[] { 10, -5, 7, 9, -1, 5, 4, 3, 15, 2, -2};
            Print(array);
            List<int> sortedlist = dc.QuickSort(array.ToList());
            Print(sortedlist);

            dc.Hanoi(5, 'A', 'C', 'B');


        }
    }
}
