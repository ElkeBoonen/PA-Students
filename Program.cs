using System;
using System.Security.Cryptography;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {

            RodCutting rc = new RodCutting(new int[] { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 }); //index komt overeen met unit size);
            int n = 4;
            Console.WriteLine("\n Oplossing recursie: " + rc.Solve(n));
            Console.WriteLine("\n Oplossing memo: " + rc.Memoization(n));
            Console.WriteLine("\n Oplossing tab: " + rc.Tabulation(n));

            /*
            /*
            Fibonacci fib = new Fibonacci();
            int n = 10;
            Console.WriteLine("Gewone recursie :" + fib.Solve(n));

            Console.WriteLine("Memoization :" + fib.Memoization(n, new int[n + 1]));
             
             Console.WriteLine("Tabulation :" + fib.Tabulation(n));*/
        }
    }
} 