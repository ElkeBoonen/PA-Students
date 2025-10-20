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
            //Console.WriteLine(String.Join(" ", list));


            //Hanoi hanoi = new Hanoi();
            //hanoi.Solve(5, 'A', 'C', 'B');

            Exercises ex = new Exercises();
            Console.WriteLine(ex.Multiplication(new List<int>() { 1, 3, 4, 1, 2 }));
            Console.WriteLine(ex.MultiplicationF(new List<int>() { 1, 3, 4, 1, 2 }));

            Console.WriteLine(ex.MultiplicationR(new List<int>() { 1, 3, 4, 1, 2 }));

        }
    }
} 