using System;
using System.Collections.Generic;

namespace Knapsack___IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(1, 10)); //weight 1, value 10
            items.Add(new Item(2, 5));  //weight 2, value 5
            items.Add(new Item(8, 40)); //weight 8, value 40
            items.Add(new Item(10, 45));//weight 10, value 45

            Knapsack knapsack = new Knapsack(items, 10);
            Console.WriteLine("GREEDY: " + knapsack.Greedy());
            Console.WriteLine("BRUTE FORCE: " + knapsack.BruteForce());
            Console.WriteLine("DIVIDE & CONQUER: " + knapsack.DivideAndConquer(0,0));
            Console.WriteLine("DYNAMIC: " + knapsack.Dynamic());

        }
    }
}
