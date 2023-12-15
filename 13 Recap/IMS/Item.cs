using System.Reflection.Metadata.Ecma335;

namespace IMS
{
    internal class Item : IComparable<Item>
    {
        public int Weight { get; set; }
        public int Value { get; set; }
        public Item(int value, int weight)
        {
            Value = value;
            Weight = weight;
        }

        public int CompareTo(Item other)
        {
            if (this.Value < other.Value) return -1;
            if (this.Value > other.Value) return 1;
            return 0;
        }

        public override string ToString()
        {
            return $"{Value}:{Weight}";
        }
    }
}