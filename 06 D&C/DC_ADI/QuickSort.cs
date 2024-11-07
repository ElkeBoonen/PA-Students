
using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace DC_ADI
{
    internal class QuickSort
    {
        internal List<int> Sort(List<int> list)
        {
            if (list.Count <= 1) return list;

            int pivot = list[0];

            List<int> less = new List<int>();
            List<int> more = new List<int>();

            foreach (int item in list)
            {
                if (item < pivot) less.Add(item);
                else if (item > pivot) more.Add(item);
            }

            return Sort(less).Union(new List<int> { pivot }).Union(Sort(more)).ToList();
        }

        internal List<int> Sort2(List<int> list)
        {
            if (list.Count <= 1) return list;

            int pivot = list[0];

            List<int> less = new List<int>();
            List<int> more = new List<int>();
            List<int> equal = new List<int>();


            foreach (int item in list)
            {
                if (item < pivot) less.Add(item);
                else if (item > pivot) more.Add(item);
                else equal.Add(item);
            }

            return Sort2(less).Concat(equal).Concat(Sort2(more)).ToList();
        }

        // Sorts a (portion of an) array, divides it into partitions, then sorts those
        public void Wikipedia(int[] array, int lo, int hi)
        {
            if (lo >= hi || lo < 0) return;

            int p = Partition(array, lo, hi);

            Wikipedia(array, lo, p - 1);
            Wikipedia(array, p + 1, hi);

        }

        private int Partition(int[] array, int lo, int hi)
        {
            int pivot = array[hi];
            int i = lo;

            int temp;

            for (int j = lo; j < hi - 1; j++)
            {
                if (array[j] <= pivot)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }
            temp = array[i];
            array[i] = array[hi];
            array[hi] = temp;
            return i;
        }
    }
}