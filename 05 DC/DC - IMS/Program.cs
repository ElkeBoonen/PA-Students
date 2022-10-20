using System;
using System.Collections.Generic;
using System.Linq;

namespace DC___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 2, -3, 4, -6, 10, 52, 36, 24 };

            DC dc = new DC();
            Console.WriteLine(dc.SumI(array));
            Console.WriteLine(dc.SumRL(array.ToList()));
            Console.WriteLine(dc.SumRA(array));

            List<int> list = dc.QuickSort(array.ToList());
            Console.WriteLine(String.Join(" ", list));

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

        }
    }
}
