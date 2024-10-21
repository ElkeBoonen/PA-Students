using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSION_ADI
{
    internal class Exercises
    {
        // Compute the sum of the first n numbers.
        

        //n = 5
        public int Sum(int n)
        {
            if (n == 1) return 1;
            return n + Sum(n - 1);         // 5 + 4 + 3 + 2 + 1
        }
        
        public int Sum1(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i; // 0 + 1 + 2 + 3 + 4 + 5
            }
            return sum;
        }

        public int Sum2(int n, int i, int sum) 
        {
            sum += i;
            if (n == i) return sum;
            return Sum2(n, i+1, sum);
        }


        //Count the number of digits in a number
        public int Count(int nr)
        {
            return nr.ToString().Length;
        }

        public int Count1(int nr)
        {
            if (nr < 10) return 1;
            return 1 + Count1(nr / 10);
        }


        //Reverse the characters in a string.*/

        public string Reverse(string text)
        {
            if (String.IsNullOrEmpty(text)) return "";
            return text[text.Length-1] + Reverse(text.Substring(0, text.Length-1));
        }

        public string Reverse1(string text)
        {
            if (text.Length == 1) return text;
            return Reverse(text.Substring(1)) + text[0];
        }
    }
}
