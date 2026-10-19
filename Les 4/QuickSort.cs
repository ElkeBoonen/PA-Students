using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Les4
{
    // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.union?view=net-10.0
    class QuickSort
    {
        public int Teller = 0;
        private Random rd = new Random();

        public List<int> Sort(List<int> list)
        {
            if (list.Count() < 2) return list;

            Teller++;
            int pivot = list[0];
            List<int> smaller = new List<int>();
            List<int> greater = new List<int>();
            List<int> pivotelements = new List<int>();

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] < pivot) smaller.Add(list[i]);
                else if (list[i] > pivot) greater.Add(list[i]);
                else pivotelements.Add(list[i]);
            }

            /*Console.WriteLine("SMALLER: " + String.Join(" ", smaller));
            Console.WriteLine("PIVOT:" + String.Join(" ", pivotelements));
            Console.WriteLine("GREATER: " + String.Join(" ", greater));*/


            return Sort(smaller).Union(pivotelements).Union(Sort(greater)).ToList();
        }

        public List<int> SortRandomPivot(List<int> list)
        {
            if (list.Count() < 2) return list;

            Teller++;
            
            //werken met random pivot

            int random = rd.Next(list.Count());
            //Console.WriteLine(random);
            int pivot = list[random];
            
            List<int> smaller = new List<int>();
            List<int> greater = new List<int>();
            List<int> pivotelements = new List<int>();

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] < pivot) smaller.Add(list[i]);
                else if (list[i] > pivot) greater.Add(list[i]);
                else pivotelements.Add(list[i]);
            }

            /*Console.WriteLine("SMALLER: " + String.Join(" ", smaller));
            Console.WriteLine("PIVOT:" + String.Join(" ", pivotelements));
            Console.WriteLine("GREATER: " + String.Join(" ", greater));*/


            return SortRandomPivot(smaller).Union(pivotelements).Union(SortRandomPivot(greater)).ToList();

        }
    }
}