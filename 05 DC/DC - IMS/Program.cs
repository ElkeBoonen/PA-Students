using System;
using System.Collections.Generic;
using System.Linq;
using TM.ProgrammingAdvanced;

namespace DC___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 2, -3, 4, 4, -6, 10, 52, 36, 24 };

            DC dc = new DC();
            Console.WriteLine(dc.SumI(array));
            Console.WriteLine(dc.SumRL(array.ToList()));
            Console.WriteLine(dc.SumRA(array));

            dc.count = 0;
            List<int> list = dc.QuickSort(array.ToList());
            Console.WriteLine(String.Join(" ", list));
            Console.WriteLine($"QUICKSORT Count: {dc.count}");

            dc.count = 0;
            list = dc.QuickSort(Data.RandomNumbers().ToList());
            Console.WriteLine(String.Join(" ", list));
            Console.WriteLine($"QUICKSORT Count: {dc.count}");


            dc.count = 0;
            array = Data.RandomNumbers();
            dc.Selection(array);
            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine($"SELECTION Count: {dc.count}");

            //# schijven, from, to, other
            dc.Hanoi(3, 'A', 'C', 'B');



        }
    }
}
