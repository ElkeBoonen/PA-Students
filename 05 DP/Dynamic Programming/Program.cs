using System;

namespace Dynamic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            DP dp = new DP();
            //Console.WriteLine($"F(0) = {dp.FibonacciI(0)}");
            //Console.WriteLine($"F(1) = {dp.FibonacciI(1)}");
            //Console.WriteLine($"F(5) = {dp.FibonacciI(5)}");
            //Console.WriteLine($"F(6) = {dp.FibonacciI(6)}");
            //Console.WriteLine($"F(13) = {dp.FibonacciI(13)}");
            //Console.WriteLine($"F(50) = {dp.FibonacciI(50)}");

            //Console.WriteLine($"F(0) = {dp.FibonacciR(0)}");
            //Console.WriteLine($"F(1) = {dp.FibonacciR(1)}");
            //Console.WriteLine($"F(5) = {dp.FibonacciR(5)}");
            //Console.WriteLine($"F(6) = {dp.FibonacciR(6)}");
            //Console.WriteLine($"F(13) = {dp.FibonacciR(13)}");
            //Console.WriteLine($"F(50) = {dp.FibonacciR(50)}");

            //Console.WriteLine($"F(13) = {dp.FibonacciM(13)}");

            //Console.WriteLine($"F(13) = {dp.FibonacciT(13)}");

            Console.WriteLine(dp.RodCuttingR(4));
            Console.WriteLine(dp.RodCuttingM(4));

        }
    }
}
