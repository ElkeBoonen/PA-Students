using System;
using System.Collections.Generic;

namespace Knapsack___DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(10, 1));     //value 10, weight 1
            items.Add(new Item(5, 2));      //value 5, weight 2
            items.Add(new Item(40, 8));     //value 40, weight 8
            items.Add(new Item(45, 10));    //value 45, weight 10

            Knapsack knapsack = new Knapsack(items, 10);
            Console.WriteLine(knapsack.Greedy());
            Console.WriteLine(knapsack.BruteForce());
            Console.WriteLine(knapsack.DivideAndConquer(0,0));
            Console.WriteLine(knapsack.Dynamic());
        }
    }
}
