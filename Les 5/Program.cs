using System;
using System.IO;
using System.Collections.Generic;


namespace Les5
{
    class Program
    {
        static void Main(string[] args)
        {   
            //priemgetallen zijn de max!! 
            /*HashTable table = new HashTable(13);
            table.AddProduct("appel", 0.78);
            table.AddProduct("Appel", 0.78);
            table.AddProduct("banaan", 0.80);
            table.AddProduct("peer", 0.24);
            table.AddProduct("kiwi", 1.02);
            table.AddProduct("venkel", 1.08);

            Console.WriteLine(table.GetPrice("appel"));
            Console.WriteLine(table.GetPrice("banaan"));
            Console.WriteLine(table.GetPrice("venkel"));
            Console.WriteLine(table.GetPrice("kiwi"));
            Console.WriteLine(table.GetPrice("banaan"));
            Console.WriteLine(table.GetPrice("venkel"));
            Console.WriteLine(table.GetPrice("Appel"));

            Fibonacci fib = new Fibonacci();

            fib.Teller = 0;
            Console.WriteLine(fib.FibRecursie(20) + " --> teller: " + fib.Teller);
            fib.Teller = 0;
            Console.WriteLine(fib.FibMemo(20) + " --> teller: " + fib.Teller);*/

            Oefeningen oef = new Oefeningen();
            Console.WriteLine(oef.TwoSum(new int[]{2, 7, 11, 15, 1, 8, 3}, 4)) ;
            Console.WriteLine(oef.TwoSumDict(new int[]{2, 7, 11, 15, 1, 8, 3}, 4)) ;
            Console.WriteLine(oef.Anagram(new string[] { "melk", "reep", "klem", "peer", "kaas" }));
        }
    }
}