using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    class Factorial
    {

        //n! = n * (n-1) * (n-2) * (n-3) * .... * 1

        public int Iterative(int n)
        {
            if (n < 0) throw new Exception("Not possible");
            if (n < 2) return 1;

            int result = 1;

            for (int i = 1; i <=n; i++)
            {
                //result *= i;
                result = result * i;
            }
            return result;

        }

        public int Recursion(int n)
        {
            if (n < 0) throw new Exception("Not possible");
            if (n < 2) return 1;

            return n * Recursion(n-1);
        }

    }
}
