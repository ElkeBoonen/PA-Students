using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace FIBONACCI___DSPS
{
    internal class Fibonacci
    {
        public int Iterative(int n)
        {
            if (n <= 1) return n;
            int fn_2 = 0, fn_1 = 1, fn = 0;
            for (int i = 2; i <= n ; i++)
            {
                //Console.Write($"Call {i} ");
                fn = fn_1 + fn_2;
                fn_2 = fn_1;
                fn_1 = fn;
            }
            return fn;
        }

        public int Recursive(int n)
        {
            Console.Write($"Call {n} ");
            if (n <= 1) return n;
            return Recursive(n - 1) + Recursive(n-2);
        }

        public int Memoization(int n)
        {
            int[] memo = new int[n + 1];
            return Memoization_R(n, memo);
        }

        private int Memoization_R(int n, int[] memo)
        {
            Console.Write($"Call {n} ");
            if (n <= 1) return n;
            if (memo[n] != 0) return memo[n];
            memo[n] = Memoization_R(n - 1, memo) + Memoization_R(n - 2, memo);
            return memo[n];
        }

        public int Tabulation(int n)
        {
            int[] memo = new int[n + 1];
            memo[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
            }
            return memo[n];
        }
    }
}
