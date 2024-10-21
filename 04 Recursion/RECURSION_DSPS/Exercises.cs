using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSION_DSPS
{
    internal class Exercises
    {
        //Compute the sum of the first n natural numbers
        public int Sum(int n)
        { 
            if (n == 0) return 0;

            return n + Sum(n - 1);
        }

        //Count Digits: count the number of digits in a number
        public int Count(int number)
        {
            //return number.ToString().Length;
            if (number == 0) return 0;
            return 1 + Count(number / 10);
        }


        //Reverse String: recursively reverse the characters in a string.
        public string Reverse(string text)
        {
            if (text.Length == 0) return "";

            return text[text.Length - 1] + Reverse(text.Substring(0,text.Length-1));
        }

        public string Reverse1(string text)
        {
            if (text.Length == 0) return "";

            return Reverse1(text.Substring(1)) + text[0];
        }

    }
}
