using System;

namespace PAStudents
{
    class RodCutting
    {

        int[] prices = new int[] { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 }; //index komt overeen met unit size
        public int Solve(int n)
        {
            Console.Write(" SOLVE met " + n);
            if (n == 0) return 0;

            int max_r = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(" In de loop ;) ");
                max_r = Math.Max(max_r, prices[i] + Solve(n - i));
            }

            return max_r;
        }
        
        public int Memoization(int n)
        {
            Console.Write( " SOLVE met " + n);
            if (n == 0) return 0;

            int max_r = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                //Console.Write("Loop ;) ");
                max_r = Math.Max(max_r, prices[i] + Memoization(n - i));
            }

            return max_r;
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