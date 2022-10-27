using System;

namespace Fibonacci___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();
            Console.WriteLine("\nITERATIEF: " + fib.Iterative(20));
            Console.WriteLine("\nRECURSIEF: " + fib.Recursive(20));
            Console.WriteLine("\nMEMOIZATION: " + fib.Memoization(20));
            Console.WriteLine("\nTABULATION: " + fib.Memoization(20));



            //Console.WriteLine(fib.Iterative(40));
            //Console.WriteLine(fib.Recursive(40));



        }
    }
}
