using System;
using System.Collections.Generic;
using System.Text;

namespace Rod_Cutting___IMS
{
    class RodCutting
    {
        public int[] Prices { get; set; }
        private int[] _memoization;

        public RodCutting(int[] prices)
        {
            Prices = prices;
        }

        public int Recursion(int n)
        {
            Console.WriteLine("call met " + n);
            if (n == 0) return 0;

            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                max = Math.Max(max, Prices[i] + Recursion(n-i-1));
            }
            return max;
        }


        public int Memoization(int n)
        { 
            _memoization = new int[n+1];
            return Memoization_R(n);
        }

        private int Memoization_R(int n)
        {
            Console.WriteLine("call met " + n);
            if (n == 0) return 0;
            if (_memoization[n] != 0) return _memoization[n];

            _memoization[n] = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                _memoization[n] = Math.Max(_memoization[n], Prices[i] + Memoization_R(n - i - 1));
            }
            return _memoization[n];
        }

        public int Tabulation(int n)
        {
            int[] tabulation = new int[n + 1];

            tabulation[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                int max = int.MinValue;
                for (int j = 1; j <= i; j++)
                {
                    max = Math.Max(max, Prices[j - 1] + tabulation[i - j]);
                }
                tabulation[i] = max;
            }
            return tabulation[n];
        }

    }
}
