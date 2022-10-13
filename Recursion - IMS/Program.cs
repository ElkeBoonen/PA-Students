using System;
using System.Collections.Generic;
using System.Linq;
using TM.ProgrammingAdvanced;

namespace Recursion___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string basefolder = Data.Folders(@"C:\");
            Recursion recursion = new Recursion();
            recursion.count = 0;
            Console.WriteLine(recursion.FindKey(@"C:\2bwlvm0zqla") + " " + recursion.count);
            recursion.count = 0;

            Console.WriteLine(recursion.FindKeyREC(@"C:\2bwlvm0zqla") + " " + recursion.count);

            Console.WriteLine($"5! = {recursion.FactorialREC(5)}");
            Console.WriteLine($"10! = {recursion.FactorialREC(10)}");

            Console.WriteLine($"5³ = {recursion.Pow(5,3)}");

            Console.WriteLine(recursion.Print(1, 50));
            Console.WriteLine(recursion.Print(19, 99));

            int[] array = new int[] { 2, 7, 9, 10, 5, 20 };
            Console.WriteLine(array.Sum());
            Console.WriteLine(recursion.Sum(array));
            Console.WriteLine(recursion.Sum(array.ToList()));

            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(7);
            stack.Push(9);
            stack.Push(10);
            stack.Push(5);
            stack.Push(20);

            Console.WriteLine(recursion.Sum(stack));


        }
    }
}
