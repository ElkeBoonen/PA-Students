using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci___IMS
{
    class Fibonacci
    {
        private int[] _memoization;

        public int Iterative(int n)
        {
            // 0 1 1 2 3 5 8 13 21 34 55 89...
            if (n <= 1) return n ;
            int f0 = 0, f1 = 1;
            int fn = 0;
            for (int i = 2; i <= n; i++)
            {
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
            }
            return fn;
        }

        public int Recursive(int n)
        {
            Console.Write("Call" + n + " ");
            if (n <= 1) return n;
            return Recursive(n - 1) + Recursive(n-2);
        }

        public int Memoization(int n)
        {
            _memoization = new int[n+1];
            return Memoization_R(n);
        }

        private int Memoization_R(int n)
        {
            Console.Write("Call" + n + " ");
            if (n <= 1) return n;
            if (_memoization[n] != 0) return _memoization[n];
            _memoization[n] = Memoization_R(n - 1) + Memoization_R(n - 2);
            return _memoization[n];
        }

        public int Tabulation(int n)
        {
            int[] tabulation = new int[n + 1];
            tabulation[0] = 0;
            tabulation[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                tabulation[i] = tabulation[i - 1] + tabulation[i - 2];
            }
            return tabulation[n];
        }

    }
}
