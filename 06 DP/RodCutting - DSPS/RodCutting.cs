using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace RodCutting___DSPS
{
    internal class RodCutting
    {
        public int[] Prices { get; set; }
        public Dictionary<int,double> Ratio { get; set; }
        //1 5 8 9 10 17 17 20 24 30
        public RodCutting(int[] prices)
        {
            Prices = prices;
            /*Ratio = new Dictionary<int,double>();   
            for (int i = 1; i < Prices.Length; i++)
            {
                Ratio.Add(i,Prices[i]/(double)i);
            }
            Ratio.OrderByDescending(x => x.Value);*/
        }

        public int Recursive(int n)
        {
            Console.WriteLine($"Call {n}");
            if (n == 0) return 0;

            int max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                max = Math.Max(max, Prices[i - 1] + Recursive(n - i));
            }
            return max;
        }

        public int Memoization(int n)
        {
            int[] memo = new int[n + 1];
            return Memoization_R(n, memo);
        }
        public int Memoization_R(int n, int[] memo)
        {
            if (n == 0) return 0;
            if (memo[n] != 0) return memo[n];

            memo[n] = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                memo[n] = Math.Max(memo[n], Prices[i - 1] + Memoization_R(n - i, memo));
            }
            return memo[n];
        }

        public int Tabulation(int n)
        {
            int[] memo = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                memo[i] = int.MinValue;
                for (int j = 1; j <= i; j++)
                {
                    memo[i] = Math.Max(memo[i], Prices[j-1] + memo[i-j]);
                }
            }
            return memo[n];
        }
    }
}
