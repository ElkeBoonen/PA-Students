using System;
using System.Linq;
using TM.ProgrammingAdvanced;

namespace Recursion___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tree /f in powershell (in folder) to check structure
            //string basefolder = Data.Folders(@"C:\");

            Recursion recursion = new Recursion();

            string path = @"C:\dxuj0efs4c2";
            Console.WriteLine(recursion.FindKeyAlgorithm1(path));
            Console.WriteLine(recursion.FindKeyAlgorithm2(path));
            Console.WriteLine(recursion.FindKeyAlgorithm3(path));


            path = @"C:\bvampgqpi2f";
            Console.WriteLine(recursion.FindKeyAlgorithm1(path));
            Console.WriteLine(recursion.FindKeyAlgorithm2(path));
            Console.WriteLine(recursion.FindKeyAlgorithm3(path));

            Console.WriteLine("5! = " + recursion.FactorialIterative(5));
            Console.WriteLine("0! = " + recursion.FactorialIterative(0));
            Console.WriteLine("10! = " + recursion.FactorialIterative(10));

            Console.WriteLine("5! = " + recursion.FactorialRecursive(5));
            Console.WriteLine("0! = " + recursion.FactorialRecursive(0));
            Console.WriteLine("10! = " + recursion.FactorialRecursive(10));

            Console.WriteLine("5! = " + recursion.FactorialStack(5));
            Console.WriteLine("0! = " + recursion.FactorialStack(0));
            Console.WriteLine("10! = " + recursion.FactorialStack(10));

            Console.WriteLine(Math.Pow(5,4));
            Console.WriteLine(recursion.Power(5, 4));

            Console.WriteLine(Math.Pow(5, -4));
            Console.WriteLine(recursion.Power(5, -4));

            Console.WriteLine(recursion.Count(1, 50));
            Console.WriteLine(recursion.Count2(20, 30));

            int[] array = new int[] { 2, 4, 18, 9, 13 };
            Console.WriteLine(recursion.Sum(array));
            Console.WriteLine(recursion.Sum(array.ToList()));

        }
    }
}
