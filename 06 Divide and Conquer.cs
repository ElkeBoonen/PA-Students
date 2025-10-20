using System;

namespace PAStudents
{
    class QuickSort
    {

        public List<int> Sort(List<int> list)
        {

            if (list.Count <= 1) return list;

            List<int> small = new List<int>();
            List<int> big = new List<int>();
            List<int> same = new List<int>();

            int pivot = list[0];

            foreach (int element in list)
            {
                if (pivot > element) small.Add(element);
                else if (pivot < element) big.Add(element);
                else same.Add(pivot);
            }

            return Sort(small).Concat(same).Concat(Sort(big)).ToList<int>();
            //return Solve(small).Union(new List<int>() { pivot }).Union(Solve(big)).ToList<int>();
            //Union verwijdert duplicaten

        }

    }
}