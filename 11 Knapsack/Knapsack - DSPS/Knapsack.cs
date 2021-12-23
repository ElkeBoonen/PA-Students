using System;
using System.Collections.Generic;
using System.Text;

namespace Knapsack___DSPS
{
    class Knapsack
    {
        public List<Item> Items { get; set; }
        public int MaxWeight { get; set; }

        public Knapsack(List<Item> items, int maxweight)
        {
            Items = items;
            MaxWeight = maxweight;
        }

        public int Greedy()
        {
            Items.Sort();
            Items.Reverse();  //45-10 40-8 10-1 5-2

            int value = 0;
            int weight = 0;

            for (int i = 0; i < Items.Count; i++)
            {
                if (weight + Items[i].Weight <= MaxWeight)
                {
                    weight += Items[i].Weight;
                    value += Items[i].Value;
                }
            }
            return value;
        }

        public int BruteForce()
        {
            int bestvalue = Int32.MinValue;

            for (int i = 0; i < Math.Pow(Items.Count,2); i++)
            {
                string binary = Convert.ToString(i, 2).PadLeft(Items.Count,'0');

                int value = 0, weight = 0;
                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                    {
                        value += Items[j].Value;
                        weight += Items[j].Weight;
                    }
                }
                if (weight <= MaxWeight && value > bestvalue)
                {
                    bestvalue = value;
                }
            }
            return bestvalue;
        }

        public int DivideAndConquer(int current, int weight)
        {
            if (current >= Items.Count) return 0;

            int selected = 0;
            int notselected = 0;

            notselected = DivideAndConquer(current+1, weight);
            if (weight + Items[current].Weight <= MaxWeight)
            {
                selected = Items[current].Value 
                    + DivideAndConquer(current + 1, weight + Items[current].Weight);

            }
            return Math.Max(selected, notselected);
        }

        public int Dynamic()
        {
            int[,] T = new int[Items.Count + 1, MaxWeight + 1];

            for (int i = 1; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    if (Items[i - 1].Weight > j)
                        T[i, j] = T[i - 1, j];
                    else
                    {
                        T[i, j] = Math.Max(T[i - 1, j], T[i - 1, j - Items[i - 1].Weight] + Items[i - 1].Value);
                    }

                }
            }
            return T[Items.Count, MaxWeight];
        }

    }
}
