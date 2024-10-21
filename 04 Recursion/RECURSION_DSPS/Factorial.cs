using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSION_DSPS
{
    internal class Factorial
    {
        //iterative 
        public int Algorithm1(int n)
        {
            int value = 1;
            for (int i = 1; i <= n; i++)
            {
                value *= i;
            }
            return value;
        }

        //recursive
        public int Algorithm2(int n)
        {
            Console.WriteLine("Call with " + n);
            if (n <= 1) return 1;
            int value = n * Algorithm2(n - 1);
            Console.WriteLine(value);
            return value;


            /*
                if (n <= 1) return 1;
                return n * Algorithm2(n - 1);;
             */
        }
    }
}
