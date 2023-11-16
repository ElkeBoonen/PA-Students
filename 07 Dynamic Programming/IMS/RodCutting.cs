using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class RodCutting
    {
        

        public int[] Prices { get; set; }

        public RodCutting(int[] prices)
        {
            Prices = prices;
        }

        //r_n = max(p_i + r_n-i) met 0 <= i <= n
        public int Recursion(int n)
        {
            Console.Write("Call met " + n + " ");

            if (n < 0) throw new Exception("Crazy input!");
            if (n == 0) return Prices[0];

            int r = 0;
            for (int i = 1; i <= n; i++)
            {
                r = Math.Max(r, Prices[i] + Recursion(n - i));
            }
            return r;
        }

        public int Memoization(int n, int[] array)
        {
            Console.Write("Call met " + n + " ");

            if (n < 0) throw new Exception("Crazy input!");
            if (n == 0) return Prices[0];
            if (array[n] != 0) return array[n]; 

            for (int i = 1; i <= n; i++)
            {
                array[n] = Math.Max(array[n], Prices[i] + Memoization(n - i, array));
            }
            return array[n];
        }

        public int Tabulation(int n)
        {
            Console.Write("Call met " + n + " ");


            if (n < 0) throw new Exception("Crazy input!");
            if (n == 0) return Prices[0];

            int[] array = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    array[i] = Math.Max(array[i], Prices[j] + array[i-j]);
                }
            }
            return array[n];
        }
    }

}
