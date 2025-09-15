using System;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {
            Searching search = new Searching();

            int number = 836;
            Console.WriteLine($"LINEAR: {search.Linear(number)} --> {search.Count}");
            Console.WriteLine($"STUPID: {search.Stupid(number)} --> {search.Count}");
            Console.WriteLine($"BINARY: {search.Binary(number)} --> {search.Count}");

            number = -672;
            Console.WriteLine($"LINEAR: {search.Linear(number)} --> {search.Count}");
            Console.WriteLine($"STUPID: {search.Stupid(number)} --> {search.Count}");
            Console.WriteLine($"BINARY: {search.Binary(number)} --> {search.Count}");
            Console.ReadLine();

            number = -630;
            Console.WriteLine($"LINEAR: {search.Linear(number)} --> {search.Count}");
            Console.WriteLine($"STUPID: {search.Stupid(number)} --> {search.Count}");
            Console.WriteLine($"BINARY: {search.Binary(number)} --> {search.Count}");
            Console.ReadLine();
        }
    }
}