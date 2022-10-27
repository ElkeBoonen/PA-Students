using System;

namespace Fibonacci___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();
            Console.WriteLine("\nITERATIEF: " + fib.Iterative(10));
            Console.WriteLine("\nRECURSIEF: " + fib.Recursive(10));
            Console.WriteLine("\nMEMOIZATION: " + fib.Memoization(10));
            Console.WriteLine("\nTABULATION: " + fib.Tabulation(10));



            //Console.WriteLine(fib.Iterative(40));
            //Console.WriteLine(fib.Recursive(40));



        }
    }
}
