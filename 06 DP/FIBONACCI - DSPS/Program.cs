using System;

namespace FIBONACCI___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();

            int n = 8;
            Console.WriteLine($"\nITERATIVE {fib.Iterative(n)}");
            Console.WriteLine($"\nRECURSIVE {fib.Recursive(n)}");
            Console.WriteLine($"\nMEMOIZATION {fib.Memoization(n)}");
            Console.WriteLine($"\nTABULATION {fib.Tabulation(n)}");


            //n = 40;
            //Console.WriteLine($"ITERATIVE {fib.Iterative(n)}");
            //Console.WriteLine($"RECURSIVE {fib.Recursive(n)}");

        }
    }
}
