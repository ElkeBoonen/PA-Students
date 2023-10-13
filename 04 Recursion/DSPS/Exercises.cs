using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    class Exercises
    {

        //Sum of Natural Numbers: compute the sum of the first n natural numbers recursively.
        public int Sum(int n)
        {
            if (n <= 0) return 0;
            return n + Sum(n - 1);
        }

        //Count Digits: count the number of digits in a number using a recursive approach.

        public int Digits(int n)
        {
            if (n < 10) return 1;

            return 1 + Digits(n / 10);
        }


        //Reverse
        public string Reverse(string s)
        {
            if (s.Length == 1) return s;

            //return Reverse(s.Substring(1, s.Length - 1)) + s[0];

            return s[s.Length-1] + Reverse(s.Substring(0, s.Length - 1));
        }
    }
}
