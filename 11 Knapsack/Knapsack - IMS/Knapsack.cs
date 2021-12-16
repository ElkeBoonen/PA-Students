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
    }
}
