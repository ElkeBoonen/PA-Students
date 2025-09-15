using System;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {
            Searching search = new Searching();

            Console.WriteLine($"LINEAR: {search.Linear(5)}");
            Console.WriteLine($"STUPID: {search.Stupid(5)}");
            Console.ReadLine();
        }
    }
}