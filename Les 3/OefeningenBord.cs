using System;
using System.IO;

namespace Recursie
{

    class OefeningBord
    {
        public void Aftellen(int n)
        {
            if (n == 0) return;
            Console.WriteLine(n);
            Aftellen(n-1);
        }

        public void Tellen(int n)
        {
            if (n == 0) return;
            Tellen(n-1);
            Console.WriteLine(n);
        }

        public void Ga(int n)
        {
            if (n == 0) return;
            Console.WriteLine("heen " + n);
            Ga(n-1);
            Console.WriteLine("terug " + n);
        }

        public int Som(int n)
        {
            if (n == 0) return 0;
            return n + Som(n-1);
        }

        public int Macht(int b, int e)
        {
            if (e == 0) return 1;
            return b * Macht(b,e-1);
        }
    }
}