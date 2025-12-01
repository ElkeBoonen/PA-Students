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
    }
}