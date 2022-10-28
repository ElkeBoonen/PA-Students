using System;

namespace RodCutting___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RodCutting rc = new RodCutting(new int[] { 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 });
            Console.WriteLine(rc.Recursive(4));
            Console.WriteLine(rc.Memoization(4));
            Console.WriteLine(rc.Tabulation(4));

        }
    }
}
