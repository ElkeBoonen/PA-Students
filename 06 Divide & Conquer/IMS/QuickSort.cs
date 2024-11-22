using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    internal class QuickSort
    {
        internal List<int> Solve(List<int> list)
        {
            if (list.Count <= 1) return list;

            int pivot = list[0];
            List<int> lower = new List<int>();
            List<int> higher = new List<int>();

            foreach (var item in list)
            {
                if (item < pivot) lower.Add(item);
                else if (item > pivot) higher.Add(item);
            }

            return Solve(lower).Union(new List<int> { pivot }).Union(Solve(higher)).ToList();
        }
    }
}
