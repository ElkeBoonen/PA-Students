using System;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {
            Sorting sorting = new Sorting();
            int[] array = Array.ConvertAll(File.ReadAllLines(@"Files/numbers.txt"), Convert.ToInt32);
            //Console.WriteLine(String.Join(" ", array));
            sorting.Bubble(array);
            Console.WriteLine("Bubble --> " + sorting.Count);

            array = Array.ConvertAll(File.ReadAllLines(@"Files/numbers.txt"), Convert.ToInt32);
            sorting.Selection(array);
            Console.WriteLine("Selection --> " + sorting.Count);

            array = Array.ConvertAll(File.ReadAllLines(@"Files/numbers.txt"), Convert.ToInt32);
            sorting.Insertion(array);
            Console.WriteLine("Insertion --> " + sorting.Count);



        }
    }
}