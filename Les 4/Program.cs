using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Les4
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*DC dc = new DC();
            Console.WriteLine(dc.AantalStukken(1701, 462));
            Console.WriteLine(dc.AantalStukken(21, 13));
            Console.WriteLine(dc.AantalStukken(1000, 10));*/

            
            int[] array = Array.ConvertAll(File.ReadAllText("gesorteerd_10000.txt").Trim().Split(" "), int.Parse);


            List<int> list = array.ToList();
            QuickSort qs = new QuickSort();

            qs.Teller = 0;
            Console.WriteLine(String.Join(" ", qs.Sort(list)) + " --> aantal: " + qs.Teller);
            qs.Teller = 0;
            Console.WriteLine(String.Join(" ", qs.SortRandomPivot(list)) + " --> aantal: " + qs.Teller);
        }
    }
}