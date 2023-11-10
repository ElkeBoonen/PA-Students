using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    class Fibonacci
    { 

        public int Recursion(int n)
        {
            Console.Write("call n = " + n + " ");

            if (n < 0) throw new Exception("Crazy input!");

            if (n == 0) return 0;
            if (n == 1) return 1;

            return Recursion(n - 1) + Recursion(n - 2);
        }

        public int Memoization(int n, int[] memoization)
        {
            Console.Write("call n = " + n + " ");

            if (n < 0) throw new Exception("Crazy input!");

            if (n == 0) return 0;
            if (n == 1) return 1;
            if (memoization[n] != 0) return memoization[n]; 

            memoization[n] =  Memoization(n - 1, memoization) + Memoization(n - 2, memoization);
            return memoization[n];
        }

        public int Tabulation(int n)
        {

            if (n < 0) throw new Exception("Crazy input!");

            //build the table
            int[] tabulation = new int[n+1];

            tabulation[0] = 0;
            tabulation[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                Console.Write("call n = " + i + " ");
                tabulation[i] = tabulation[i - 1] + tabulation[i - 2];
            }
            return tabulation[n];
        }


        public int Iterative(int n)
        {
            if (n < 0) throw new Exception("Crazy input!");

            int fib0 = 0;
            int fib1 = 1;

            int fib = 0;
            for (int i = 2; i <= n; i++)
            {
                Console.Write("call n = " + i + " ");

                fib = fib0+fib1;
                fib0 = fib1;
                fib1 = fib;
            }
            return fib;

        }

    }
}
