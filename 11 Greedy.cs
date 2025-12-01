namespace PAStudents
{
    class Greedy
    {
        public List<string> Activities(string[] classes, double[] start, double[] end)
        {
            List<string> act = new List<string>();

            act.Add(classes[0]);
            double hour = end[0];

            for (int i = 1; i < classes.Length; i++)
            {
                if (start[i] >= hour)
                {
                    act.Add(classes[i]);
                    hour = end[i];
                }
            }

            return act;
        }

        public List<int> Coins(int target, int[] coins)
        {
            List<int> chosen = new List<int>();
            Array.Sort(coins);
            Array.Reverse(coins);

            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] <= target)
                {
                    chosen.Add(coins[i]);
                    target = target - coins[i];
                }
            }
            return chosen;
        }
    }
}