using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Fibonacci
    {
        public int Recursion(int n)
        {
            Console.Write("call " + n + " ");

            if (n < 0) throw new Exception("Crazy input!");

            if (n == 0) return 0;
            if (n == 1) return 1;

            return Recursion(n-1) + Recursion(n-2);
        }

        public int Memoization(int n, int[] array)
        {
            Console.Write("call " + n + " ");

            if (n < 0) throw new Exception("Crazy input!");

            if (n == 0) return 0;
            if (n == 1) return 1;
            if (array[n] != 0) return array[n];

            array[n] = Memoization(n - 1, array) + Memoization(n - 2, array);
            return array[n];
        }

        public int Tabulation(int n)
        {
            Console.Write("call " + n + " ");
            if (n < 0) throw new Exception("Crazy input!");

            int[] array = new int[n + 1];
            array[0] = 0;
            array[1] = 1;

            for (int i = 2; i <= n ; i++)
            {
                Console.Write(" -> " + i + " ");
                array[i] = array[i - 1] + array[i - 2];
            }
            
            return array[n];
        }

        public int Iterative(int n)
        {
            Console.Write("call " + n + " ");
            if (n < 0) throw new Exception("Crazy input!");

            int fib0 = 0;
            int fib1 = 1;
            int fib = fib0+fib1;

            for (int i = 2; i < n; i++)
            {
                Console.Write(" -> " + i + " ");
                fib0 = fib1;
                fib1 = fib;
                fib = fib1 + fib0;
            }

            return fib;
        }
    }
}
