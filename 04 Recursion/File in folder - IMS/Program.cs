using System;
using System.Collections.Generic;
using System.Linq;
using TM.ProgrammingAdvanced;

namespace File_in_folder___IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string basefolder = @"C:\xeiry0xqo5b"; //Data.Folders(@"C:\");

            Recursion rec = new Recursion(basefolder);
            Console.WriteLine(rec.Algorithm1());
            Console.WriteLine(rec.Algorithm2(basefolder));
            Console.WriteLine($"2!= {rec.Faculteit(2)}");
            Console.WriteLine($"0!= {rec.Faculteit(0)}");
            Console.WriteLine($"5!= {rec.Faculteit(5)}");

            Console.WriteLine("\n");
            Console.WriteLine($"2!= {rec.FaculteitR(2)}");
            Console.WriteLine($"0!= {rec.FaculteitR(0)}");
            Console.WriteLine($"5!= {rec.FaculteitR(5)}");

            Console.WriteLine("\n");
            Console.WriteLine($"2!= {rec.FaculteitS(2)}");
            Console.WriteLine($"0!= {rec.FaculteitS(0)}");
            Console.WriteLine($"5!= {rec.FaculteitS(5)}");

            string[] woorden  = Data.RandomWords(10);
            rec.Print(woorden);
            rec.PrintR(0,woorden);

            List<string> lijstwoorden = woorden.ToList();
            rec.PrintL(lijstwoorden);
        }
    }
}
