using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    class Quicksort
    {

        /*Pick an element from the array = the pivot
          Find elements smaller and greater than the pivot = partitioning!
          - A sub-array of all the numbers less than the pivot
          - the pivot
          - A sub-array of all the numbers greater than the pivot
          Sort the subarrays with quicksort and merge everything together!*/
        public List<int> Sort(List<int> list)
        {
            //base case
            if (list.Count <= 1) return list;

            int pivot = list[0];

            List<int> smaller = new List<int>();
            List<int> greater = new List<int>();

            foreach (var item in list)
            {
                if (item < pivot) smaller.Add(item);
                else if (item > pivot) greater.Add(item);
            }

            return Sort(smaller).Union(new List<int> { pivot }).Union(Sort(greater)).ToList<int>();

        }

        public void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(array, low, high);
                Sort(array, low, p);
                Sort(array, p + 1, high);
            }
        }

        public int Partition(int[] array, int low, int high)
        {
            int pivot = array[(high + low) / 2];

            int i = low - 1;
            int j = high + 1;

            while (true)
            {
                do
                {
                    i++;
                }
                while (array[i] < pivot);

                do
                {
                    j--;
                }
                while (array[j] > pivot);

                if (i > j) return j;
                int swap = array[i];
                array[i] = array[j];
                array[j] = swap;
            }
        }
    }
}
