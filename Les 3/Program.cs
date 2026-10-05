using System;
using System.IO;

namespace Recursie
{  
    class Program
    {
        static void Main(string[] args)
        {    
            Search search = new Search();
            Console.WriteLine(search.Binary(new int[]{1,2,4,5,8,9,10,12,20,25}, 5));      
            Console.WriteLine(search.Binary(new int[]{1,2,4,5,8,9,10,12,20,25}, 15));


            /*OefeningBord oefening = new OefeningBord();
            oefening.Aftellen(3);
            oefening.Tellen(3);
            oefening.Ga(3);
            Console.WriteLine(oefening.Som(3));
            Console.WriteLine(oefening.Macht(2,3));

            Oefening oefening = new Oefening();
            Console.WriteLine(oefening.Faculteit(3));
            Console.WriteLine(oefening.Som(new int[]{1,2,4,5,8,9,10}));
            Console.WriteLine(oefening.Max(new int[]{1,2,4,5,8,9,10}));
            Console.WriteLine("lepel " + oefening.IsPalindroom("lepel"));
            Console.WriteLine("kook " + oefening.IsPalindroom("kook"));
            Console.WriteLine("codegrade " + oefening.IsPalindroom("codegrade"));
            Console.WriteLine(oefening.Fibonacci(40) + " --> " + oefening.teller);*/

        }
    }
}