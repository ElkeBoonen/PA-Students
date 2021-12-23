using System;
using System.Collections.Generic;
using System.Text;

namespace Knapsack___DSPS
{
    class Item : IComparable
    {
        public int Weight { get; set; }
        public int Value { get; set; }

        public Item(int value, int weight)
        {
            Value = value;
            Weight = weight;
        }

        public int CompareTo(object obj)
        {
            Item a = this;
            Item b = (Item)obj;
            if (a.Value > b.Value) return 1;
            else if (a.Value < b.Value) return -1;
            return 0;
        }
    }
}
