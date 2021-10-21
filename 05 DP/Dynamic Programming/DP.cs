using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    class DP
    {
        Dictionary<int, int> _memoization = new Dictionary<int, int>();
        Dictionary<int, int> _memoizationRC = new Dictionary<int, int>();
        int[] _prices = new int[] { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
        public int FibonacciI(int number)
        {
            //iteratieve oplossing
            int nmin2 = 0;
            int nmin1 = 1;

            if (number == 0) return nmin2;
            if (number == 1) return nmin1;

            int n = 0;
            for (int i = 2; i <= number; i++)
            {
                Console.Write($"I {i}");
                n = nmin1 + nmin2;
                nmin2 = nmin1;
                nmin1 = n;
            }
            return n;
        }

        public int FibonacciR(int number)
        {
            //recursieve oplossing
            Console.Write($"R {number}");
            if (number == 0) return 0;
            if (number == 1) return 1;

            return FibonacciR(number - 1) + FibonacciR(number - 2);
        }

        public int FibonacciM(int number)
        {
            //recursieve oplossing met memoization
            Console.Write($"M {number}");
            if (number == 0) return 0;
            if (number == 1) return 1;
            if (_memoization.ContainsKey(number)) return _memoization[number];

            _memoization[number] = FibonacciM(number - 1) + FibonacciM(number - 2);

            return _memoization[number];
        }

        public int FibonacciT(int number)
        {
            //oplossing met tabulation
            int[] tabulation = new int[number+1];

            tabulation[0] = 0;
            tabulation[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                tabulation[i] = tabulation[i - 1] + tabulation[i - 2];
            }

            return tabulation[number];
        }

        public int RodCuttingR(int n)
        {
            //Console.Write(n + " ");
            if (n == 0) return 0;

            int max = Int32.MinValue;
            for (int i = 1; i <= n; i++)
            {
                max = Math.Max(max, _prices[i] + RodCuttingR(n - i));
            }
            return max;
        }

        public int RodCuttingM(int n)
        {
            //Console.Write(n + " ");
            if (n == 0) return 0;
            if (_memoizationRC.ContainsKey(n)) return _memoizationRC[n];
            
            int max = Int32.MinValue;
            for (int i = 1; i <= n; i++)
            {
                max = Math.Max(max, _prices[i] + RodCuttingR(n - i));
                _memoizationRC[n] = max;
            }
            return max;
        }

        public int RodCuttingT(int n)
        {
            int[] tabulation = new int[n + 1];

            tabulation[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                int max = Int32.MinValue;
                for (int j = 1; j <= i; j++)
                {
                    max = Math.Max(max, _prices[j] + tabulation[]);
                    tabulation[] = max;             
                }
            }
            return tabulation[n];
        }
    }
}
