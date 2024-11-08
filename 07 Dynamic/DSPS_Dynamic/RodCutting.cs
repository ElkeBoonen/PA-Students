using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS_Dynamic
{
    internal class RodCutting
    {
        public int[] Prices { get; set; }
        public RodCutting(int[] prices)
        {
            Prices = prices; 
        }

        public int Solve(int n)
        {
            //r_n = max(p_i + r_n−i) for 1 <= 1 <= n

            Console.WriteLine("call with " + n);

            if (n == 0) return 0;
            if (n == 1) return 1;

            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                result = Math.Max(result, Prices[i] + Solve(n-i));
            }

            return result; 
        }

        public int Memoization(int n, int[] array)
        {
            Console.WriteLine("call with " + n);
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (array[n] > 0) return array[n];

            for (int i = 1; i <= n; i++)
            {
                array[n] = Math.Max(array[n], Prices[i] + Memoization(n - i, array));
            }

            return array[n];
        }

        public int Tabulation(int n)
        {
            int[] array = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int max = int.MinValue;

                for (int j = i; j >= 0; j--)
                {
                    max = Math.Max(max, Prices[j] + array[i-j]);
                }
                array[i] = max;
            }
            return array[n];
        }

        public int Binary(int n)
        {
            int[] array = new int[(int)Math.Pow(2, n - 1)];

            for (int i = 0; i < array.Length; i++)
            {
                string s = Convert.ToString(i, 2).PadLeft(n-1,'0');
                Console.WriteLine(s);
                //add code...
            }
            return 0;
        }
    }
}
