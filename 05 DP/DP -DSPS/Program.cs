using System;

namespace DP__DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fibonacci fibonacci = new Fibonacci();
            Console.WriteLine("\n" + fibonacci.Iterative(10));
            Console.WriteLine("\n\n" + fibonacci.Recursive(10));
            Console.WriteLine("\n\n" + fibonacci.Memoization(10));
            Console.WriteLine("\n\n" + fibonacci.Tabulation(10));*/

            RodCutting rodcutting = new RodCutting();
            Console.WriteLine(rodcutting.Recursive(4));
            Console.WriteLine(rodcutting.Memoization(4));
        }
    }
}
