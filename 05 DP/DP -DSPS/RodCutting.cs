using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__DSPS
{
    class RodCutting
    {
        int[] _prices = new int[] { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
        Dictionary<int, int> _memoization = new Dictionary<int, int>();

        public int Recursive(int n)
        {
            if (n == 0) return _prices[0];

            int max = Int32.MinValue;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                max = Math.Max(max, _prices[i] + Recursive(n - i));
            }
            return max;
        }

        public int Memoization(int n)
        {
            if (n == 0) return _prices[0];

            if (_memoization.ContainsKey(n)) return _memoization[n];

            int max = Int32.MinValue;
            for (int i = 1; i <= n; i++)
            {
                max = Math.Max(max, _prices[i] + Memoization(n - i));
            }
            _memoization[n] = max;
            return max;
        }

        public int Tabulation(int n)
        {
            int[] tabulation = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int max = Int32.MinValue;
                for (int j = 0; j <= n-i ; j++)
                {
                    max = Math.Max(max, _prices[] + );
                }
                tabulation[] = max;
            }
            
            return tabulation[n];
        }
    }
}
