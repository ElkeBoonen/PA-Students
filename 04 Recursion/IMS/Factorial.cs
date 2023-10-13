using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Factorial
    {
        public int Iterative(int n)
        {
            //n! = n*(n-1)(n-2)*...*1

            if (n < 2) return 1;

            int result = 1;
            for (int i = n; i > 0 ; i--)
            {
                result *= i;
            }
            return result;
        }

        public int Recursive(int n)
        {
            if (n < 2) return 1;
            return n * Recursive(n - 1);
        }
    }
}
