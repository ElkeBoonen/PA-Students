using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACK_ADI
{
    internal class Subset
    {
        internal List<List<int>> Solve(int[] ints)
        {
            List<List<int>> subsets = new List<List<int>>();
            List<int> set = new List<int>();
            int index = 0;

            CreateSubsets(index, ints, set, subsets);

            return subsets;
        }

        private void CreateSubsets(int index, int[] ints, List<int> set, List<List<int>> subsets)
        {
            subsets.Add(new List<int>(set));
            for (int i = index; i < ints.Length; i++)
            {
                set.Add(ints[i]);
                CreateSubsets(i+1, ints, set, subsets);
                set.Remove(ints[i]);
            }
        }
    }
}
