using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack___IMS
{
    class Item : IComparable<Item>
    {
        public int Weight { get; set; }
        public int Value { get; set; }

        public Item(int weight, int value)
        {
            Weight = weight;
            Value = value;
        }

        public int CompareTo(Item obj)
        {
            return Value.CompareTo(obj.Value);
        }
    }
}
