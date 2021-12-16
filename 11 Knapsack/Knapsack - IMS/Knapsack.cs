using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack___IMS
{
    class Knapsack
    {
        public List<Item> Items { get; set; }
        public int MaxWeight { get; set; }

        public Knapsack(List<Item> items, int weight)
        {
            Items = items;
            MaxWeight = weight;
        }

        //weight 1, value 10
        //weight 2, value 5
        //weight 8, value 40
        //weight 10, value 45
        public int Greedy()
        {
            Items.Sort(); //sorteren op value: 5 10 40 45
            Items.Reverse(); // --> 45 40 10 5

            int weight = 0;
            int value = 0;

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
            List<int> values = new List<int>();
            for (int i = 0; i < (int)Math.Pow(2,Items.Count); i++)
            {
                string binair = Convert.ToString(i, 2).PadLeft(Items.Count,'0');

                int weight = 0;
                int value = 0;
                for (int j = 0; j < binair.Length; j++)
                {
                    if (binair[j]=='1')
                    {
                        weight += Items[j].Weight;
                        value += Items[j].Value;
                    }
                    if (weight <= this.MaxWeight)
                    {
                        values.Add(value);
                    }
                }
            }
            values.Sort();
            return values[values.Count-1];
        }
    }
}
