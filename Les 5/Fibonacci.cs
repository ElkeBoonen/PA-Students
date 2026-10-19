using System;
using System.IO;
using System.Collections.Generic;

namespace Les5
{
    class Fibonacci
    {
        public int Teller { set; get; }

        private Dictionary<int, int> cache = new Dictionary<int, int>();

        public int FibRecursie(int n)
        {
            if (n < 2) return n;
            Teller++;
            return FibRecursie(n-1) + FibRecursie(n-2);
        }

        public int FibMemo(int n)
        {
            if (n < 2) return n;
            if (cache.ContainsKey(n)) return cache[n];
            Teller++;
            cache[n] = FibMemo(n-1) + FibMemo(n-2);
            return cache[n];
        }


    }
}