using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TM.ProgrammingAdvanced;

namespace DC___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { -3, 5, 12, 9, 1, 0, 20, -4, 7, 3};

            DC dc = new DC();
            Console.WriteLine(array.Sum());
            Console.WriteLine(dc.SumIt(array));
            Console.WriteLine(dc.SumRL(array.ToList()));
            Console.WriteLine(dc.SumRA(array));

            List<int> list = dc.QuickSort(array.ToList());
            Console.WriteLine(String.Join(" ", list));

            array = new int[] { -3, 5, 12, 9, 1, 0, 20, 0, -3, 12, 12, 12, -4, 7, 3 };
            list = dc.QuickSortD(array.ToList());
            Console.WriteLine(String.Join(" ", list));

            array = Data.RandomNumbers();
            dc.Count = 0;
            dc.QuickSort(array.ToList());
            Console.WriteLine("QUICK SORT: " + dc.Count);

            dc.Count = 0;
            dc.Selection(array);
            Console.WriteLine("SELECTION SORT: " + dc.Count);

            Console.WriteLine("3 DISKS");
            dc.Hanoi(3, 'A', 'C', 'B');
            Console.WriteLine("4 DISKS");
            //dc.Hanoi(4, 'A', 'C', 'B');
            //Console.WriteLine("4 DISKS");
            //dc.Hanoi(10, 'A', 'C', 'B');

        }
    }
}
