using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class SubsetProblem
    {
        /*
         
        Start with empty subset and add to result list.
        iterate through the elements of input:
        Include current element in the subset.
        Recursively call yourself with the updated subset and the next index.
        Exclude the current element from the subset (backtrack)
         
         */
        public List<List<int>> Solve(int[] ints)
        {
            List<List<int>> results = new List<List<int>>();
            List<int> list = new List<int>();

            CreateSubset(ints, 0, results, list);

            return results;
        }

        private void CreateSubset(int[] array, int index, List<List<int>> results, List<int> subset)
        {
            results.Add(new List<int>(subset)); //nieuwe lijst anders referentie opgeslagen
            for (int i = index; i < array.Length; i++)
            {
                subset.Add(array[i]);
                CreateSubset(array, i+1, results, subset);
                subset.RemoveAt(subset.Count-1);
            }

        
        }
    }
}
