using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP__DSPS
{
    class Fibonacci
    {
        Dictionary<int, int> _memoization = new Dictionary<int, int>();

        public int Iterative(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int number = 0, n_1 = 1, n_2 = 0;
            for (int i = 2; i <= n; i++)
            {
                Console.Write(i + " ");
                number = n_1 + n_2;
                n_2 = n_1;
                n_1 = number;
            }
            return number;
        }

        public int Recursive(int n)
        {
            Console.Write(n + " ");
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Recursive(n - 1) + Recursive(n - 2);
        }

        public int Memoization(int n)
        {
            Console.Write(n + " ");
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (_memoization.ContainsKey(n)) return _memoization[n];

            _memoization[n] = Memoization(n - 1) + Memoization(n - 2);
            return _memoization[n];
        }

        public int Tabulation(int n)
        {
            int[] tabulation = new int[n + 1];
            tabulation[0] = 0;
            tabulation[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                Console.Write(i + " ");
                tabulation[i] = tabulation[i-1] + tabulation[i-2];
            }
            return tabulation[n];
        }
    }
}
