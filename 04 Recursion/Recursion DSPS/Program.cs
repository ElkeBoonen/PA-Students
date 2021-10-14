using System;
using TM.ProgrammingAdvanced;

namespace Recursion_DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //string basefolder = Data.Folders(@"C:\Users\u0116591\Desktop");
            //this creates a folder of folders of folders and somewhere is a key.txt hidden!
            string basefolder = @"C:\Users\u0116591\Desktop\3orhyvogped";

            Recursion rec = new Recursion(basefolder);
            Console.WriteLine(rec.FindTheKey());
            Console.WriteLine(rec.FindTheKeyR(rec.Path));

            Console.WriteLine("FACTORIAL");
            Console.WriteLine($"0! = {rec.Factorial(0)}");
            Console.WriteLine($"1! = {rec.Factorial(1)}");
            Console.WriteLine($"2! = {rec.Factorial(2)}");
            Console.WriteLine($"6! = {rec.Factorial(6)}");

            Console.WriteLine($"0! = {rec.FactorialR(0)}");
            Console.WriteLine($"1! = {rec.FactorialR(1)}");
            Console.WriteLine($"2! = {rec.FactorialR(2)}");
            Console.WriteLine($"6! = {rec.FactorialR(6)}");

            Console.WriteLine($"0! = {rec.FactorialS(0)}");
            Console.WriteLine($"1! = {rec.FactorialS(1)}");
            Console.WriteLine($"2! = {rec.FactorialS(2)}");
            Console.WriteLine($"6! = {rec.FactorialS(6)}");

            Console.WriteLine("FACTORIAL");
            string[] words = Data.RandomWords(15);
            rec.Print(words);
            rec.PrintR(words,0);
        }
    }
}
