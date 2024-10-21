

namespace BACK_DSPS
{
    internal class Subset
    {
        internal List<List<int>> Solve(List<int> input)
        {
            List<int> subset = new List<int>();
            List<List<int>> result = new List<List<int>>();
            int index = 0;

            CreateSubsets(index, input, subset, result);

            return result;

        }

        private void CreateSubsets(int index, List<int> input, List<int> subset, List<List<int>> result)
        {
            result.Add(new List<int>(subset));

            for (int i = index; i < input.Count; i++)
            {
                subset.Add(input[i]);
                CreateSubsets(i+1, input, subset, result);
                subset.Remove(input[i]);
            }

        }
    }
}