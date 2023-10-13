using System;
using TM.ProgrammingAdvanced;

namespace DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\shrhydmsm4t";//Data.Folders(@"C:\");
            Console.WriteLine("Base folder: "+ folder);

            FindKey find = new FindKey();
            find.Count = 0;
            Console.WriteLine("File found: " + find.Algorithm1(folder) + " count " + find.Count);
            find.Count = 0;
            Console.WriteLine("File found: " + find.Algorithm2(folder) + " count " + find.Count);

            Factorial factorial = new Factorial();
            Console.WriteLine("10! = " + factorial.Iterative(10));
            Console.WriteLine("10! = " + factorial.Recursion(10));

            Exercises ex = new Exercises();
            Console.WriteLine(ex.Sum(9));
            Console.WriteLine(ex.Reverse("programming"));

            Console.WriteLine(ex.Digits(10000));


        }
    }
}