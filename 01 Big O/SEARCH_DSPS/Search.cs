using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEARCH_DSPS
{
    internal class Search
    {
        public int Count { get; set; }
        public Search() { }

        public int Stupid(int[] array, int target)
        {
            Count = 0;
            Random random = new Random();

            int guesses = 5 * array.Length;

            while (guesses > 0)
            {
                Count++;
                int index = random.Next(array.Length);
                if (array[index] == target)
                {
                    return index;
                }
                guesses--;
            }
            return -1;
        }

        public int Linear(int[] array, int target)
        {
            Count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Count++;
                if (array[i] == target) return i;
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
                int mid = (start + end + 1) / 2;

                if (array[mid] == target) return mid;
                else if (array[mid] < target)
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
