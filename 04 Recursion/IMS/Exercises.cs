using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Exercises
    {
        /*  Sum of Natural Numbers: compute the sum of the first n natural numbers recursively.
            Count Digits: count the number of digits in a number using a recursive approach.
            Reverse String: recursively reverse the characters in a string.*/

        public int Sum(int n)
        {
            if (n <= 0) return 0;
            return n + Sum(n - 1);
        }

        public int Count(int n)
        {
            if (n < 10) return 1;
            return 1 + Count(n / 10);
        }

        //print array af
        public void For(int[] array, int i=0)
        {
            Console.WriteLine(array[i]);
            if (i == array.Length - 1) 
            {
                return;
            }
            For(array,i+1);
        }

        //print alle getallen af tot n
        public string For(int n, int start)
        {
            if (start == n) return n.ToString();
            return start + " " + For(n, start + 1);
        }

        public string Reverse(string word)
        {
            if (word.Length == 1) return word;

            return word[word.Length - 1] + Reverse(word.Remove(word.Length - 1));
        }

    }
}
