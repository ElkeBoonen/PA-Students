using System;
using System.Security.Cryptography;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Array.ConvertAll(File.ReadAllLines(@"Files/numbers.txt"), int.Parse).ToList<int>();


            //Console.WriteLine(String.Join(" ", list));

            QuickSort qs = new QuickSort();
            qs.Count = 0;
            list = qs.Sort(list);
            Console.WriteLine("Count = " + qs.Count);
            Console.WriteLine(String.Join(" ", list));


            Hanoi hanoi = new Hanoi();
            hanoi.Solve(5, 'A', 'C', 'B');
        }
    }
} 