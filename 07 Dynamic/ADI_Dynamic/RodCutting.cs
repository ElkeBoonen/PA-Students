using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ADI_Dynamic
{
    internal class RodCutting
    {
        private int[] Prices = { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30};

        public int Recursion(int n)
        {
            //Console.WriteLine("call with " + n);

            if (n <= 1) return n;

            int max = Int32.MinValue;
            for (int i = 1; i <= n; i++)
            {
                max = Math.Max(max, Prices[i] + Recursion(n-i));
            }
            return max;
        }

        public int Memoization(int n, int[] array)
        {
            //Console.WriteLine("call with " + n);

            if (n <= 1) return n;
            if (array[n] > 0) return array[n];

            array[n] = Int32.MinValue;
            for (int i = 1; i <= n; i++)
            {
                array[n] = Math.Max(array[n], Prices[i] + Memoization(n - i, array));
            }
            return array[n];
        }

        public int Tabulation(int number)
        {
            int[] array = new int[number + 1];

            array[0] = 0;

            for (int n = 1; n <= number; n++)
            {
                array[n] = Int32.MinValue;
                for (int i = 1; i <= n; i++)
                {
                    array[n] = Math.Max(array[n], Prices[i] + array[n-i]);
                }
            }
            return array[number];
        }

        public int Binary(int n)
        {
            int[] array = new int[(int)Math.Pow(2, n - 1)];

            for (int i = 0; i < array.Length; i++)
            {
                string bin = Convert.ToString(i, 2).PadLeft(n-1,'0');
                Console.WriteLine(i + " --> " + bin);
                
            }
            return 0;
        }
    }
}
