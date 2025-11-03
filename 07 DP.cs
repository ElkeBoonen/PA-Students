using System;

namespace PAStudents
{
    class RodCutting
    {
        int[] _memoization;
        public int[] Prices { get; private set; }

        public RodCutting(int[] prices)
        {
            Prices = prices;
            _memoization = new int[prices.Length];
        }

        
        public int Solve(int n)
        {
            Console.Write(" SOLVE " + n);
            if (n == 0) return 0;

            int max_r = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(" In de loop ;) ");
                max_r = Math.Max(max_r, Prices[i] + Solve(n - i));
            }

            return max_r;
        }

        public int Memoization(int n)
        {
            Console.Write(" MEM " + n);

            if (n == 0) return 0;
            if (_memoization[n] > 0) return _memoization[n];

            int max_r = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                max_r = Math.Max(max_r, Prices[i] + Memoization(n - i));
                _memoization[n] = max_r;
            }

            return _memoization[n];
        }
        
        public int Tabulation(int n)
        {
            int[] tabulation = new int[n + 1];
            tabulation[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int max_r = int.MinValue;
                for (int j = 0; j <= i; j++)
                {
                    max_r = Math.Max(max_r, Prices[j] + tabulation[i-j]);
                } 
                tabulation[i] = max_r;
            }

            return tabulation[n];
        }
    }

    class Fibonacci
    {
        public int Solve(int n)
        {
            Console.Write("SOLVE " + n + " ");
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Solve(n - 1) + Solve(n - 2);

        }

        public int Memoization(int n, int[] array)
        {
            Console.Write("MEMO " + n + " ");

            if (n == 0) return 0;
            if (n == 1) return 1;
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
                Console.Write("TAB " + i + " ");
                array[i] = array[i - 1] + array[i - 2];
            }
            return array[n];
        }

        public int Iteration(int n)
        {
            int temp_n_2 = 0;
            int temp_n_1 = 1;
            int temp = 0;

            for (int i = 2; i <= n; i++)
            {
                temp = temp_n_1 + temp_n_2;
                temp_n_2 = temp_n_1;
                temp_n_1 = temp;
            }
            return temp;
        }
    }
}