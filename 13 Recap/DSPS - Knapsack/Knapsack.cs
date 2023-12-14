namespace DSPS___Knapsack
{
    public class Knapsack
    {
        private List<Item> items;
        private int maxWeight;

        public Knapsack(List<Item> list, int v)
        {
            items = list;
            maxWeight = v;
        }

        public override string ToString()
        {
            string s = "";
            foreach (var item in items)
            {
                s += item.ToString() + "\n";
            }
            return s;
        }
    }
}