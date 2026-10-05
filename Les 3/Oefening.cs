using System;
using System.IO;

namespace Recursie
{  
    class Oefening
    {

        /*Faculteit(n) --> output n!
        Som(array) à output som
        Max(array) --> output grootste element
        IsPalindroom(woord) --> output true/false
        Fibonacci(n) + Teller --> aantal oproepen voor n = 10, 20, 30, 40*/

        public int Faculteit(int n)
        {
            if (n <= 1) return 1;
            //Console.WriteLine(n);
            return n * Faculteit(n-1);
        }

        public int Som(int[] array, int index=0)
        {
            if (index == array.Length) return 0;
            return array[index] + Som(array, index+1); //NOOIT post increment doen index++
        }

        public int Max(int[] array, int max = Int32.MinValue, int index = 0)
        {
            if (index == array.Length) return max;
            if (array[index] > max) max = array[index];
            return Max(array, max, ++index);
        }

        public bool IsPalindroom(string woord, int index=0)
        {
            if (woord.Length/2 <= index) return true;
            if (woord[index] != woord[woord.Length-1-index]) return false;
            return IsPalindroom(woord, index+1);
        } 

        public int teller = 0;
        public int Fibonacci(int n)
        {
            teller++;
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n-1) + Fibonacci(n-2);
        }

    }
}