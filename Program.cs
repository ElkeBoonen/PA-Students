using System;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 12, 56, 34, 78, 23, 89, 12, 45, 12, 67, 90, 21 };
            Console.WriteLine(String.Join(" ", list));

            QuickSort qs = new QuickSort();
            list = qs.Solve(list);
            Console.WriteLine(String.Join(" ", list));
        }
    }
} 