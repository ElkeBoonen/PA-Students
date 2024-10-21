using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSION_ADI
{
    internal class Factorial
    {

        public int Algorithm1(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public int Algorithm2(int n)
        {
            Console.WriteLine("call met " + n);

            if (n == 1) return 1;
            int result = n* Algorithm2(n -1);

            Console.WriteLine(result);
            return result;
        }

        /*public int Algorithm2(int n)
        {
            if (n == 1) return 1;
            return n * Algorithm2(n - 1);
        }*/
    }
}
