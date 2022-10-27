using System;

namespace Rod_Cutting___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RodCutting rc = new RodCutting(new int[] { 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 });

            Console.WriteLine(rc.Recursion(4));
            Console.WriteLine(rc.Memoization(4));
            Console.WriteLine(rc.Tabulation(4));



        }
    }
}
