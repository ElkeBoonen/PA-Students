using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADI_Dynamic
{
    internal class Fibonacci
    {
        public int Recursion(int n)
        {
            //Console.WriteLine("call met " + n);
            if (n <= 1) return n;
            return Recursion(n - 1) + Recursion(n-2);
        }

        public int Memoization(int n, int[] array)
        {
            Console.WriteLine("call met " + n);
            if (n <= 1) return n;
            if (array[n] > 0) return array[n];

            array[n] = Memoization(n - 1, array) + Memoization(n - 2, array);
            return array[n];
        }

        public int Tabulation(int n)
        {
            int[] array = new int[n + 1];

            array[0] = 0;
            array[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            return array[n];
        }


        public int Iterative(int number)
        {
            if (number <= 1) return number;

            int fib1 = 0, fib2 = 1, fib3 = 1;

            for (int i = 2; i < number; ++i)
            {
                fib1 = fib2;
                fib2 = fib3;
                fib3 = fib1 + fib2;
            }
            return fib3;
        }

    }
}
