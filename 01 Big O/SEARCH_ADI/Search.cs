using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEARCH_ADI
{
    internal class Search
    {
        public int Count { get; private set; }

        public int Stupid(int[] array, int target)
        { 
            Random random = new Random();

            Count = 0;

            while (Count < array.Length*5)
            {
                Count++;
                int index = random.Next(array.Length);
                if (target == array[index])
                {
                    return index;
                }
            }
            return -1;
        }

        public int Linear(int[] array, int target)
        {
            Count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Count++;
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Binary(int[] array, int target)
        {
            Count = 0;

            int start = 0;
            int end = array.Length - 1;

            while (start <= end)
            {
                Count++;

                int mid = (start + end) / 2;
                if (array[mid] == target) return mid;
                else if (target > array[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
