using System;
using System.Security.Cryptography;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {
            RodCutting rc = new RodCutting();
            int n = 10;
            Console.WriteLine(rc.Solve(n));
            /*
            Fibonacci fib = new Fibonacci();
            int n = 10;
            Console.WriteLine("Gewone recursie :" + fib.Solve(n));

            Console.WriteLine("Memoization :" + fib.Memoization(n, new int[n + 1]));
             
             Console.WriteLine("Tabulation :" + fib.Tabulation(n));*/
        }
    }
} 