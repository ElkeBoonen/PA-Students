using System;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {
            Sorting sorting = new Sorting();
            int[] array = new int[] { -1, -9, 5, 4, 8, 3, -7, 2, 10, -5 };
            Console.WriteLine(sorting.Bubble(array));
        }
    }
}