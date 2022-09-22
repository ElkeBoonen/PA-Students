using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Big_O___DSPS
{
    internal class Search
    {
        private Random _random = new Random();
        public int Simple(int[] array, int number, out int count)
        {
            count = 0;
            for (int i = 0; i < array.Length; i++)  //O(n)
            {
                count++;
                if (number == array[i]) return i;
            }
            return -1;
        }

        public int Stupid(int[] array, int number, out int count)
        {
            count = 0;
            int limit = array.Length;
            while (limit > 0)  //O(n)
            {
                int guess = _random.Next(0, 1000);
                limit--;
                count++;

                if (array[guess] == number) return guess;
            }
            return -1;
        }

        //binary search
        public int Smart(int[] array, int number, out int count)
        {
            count = 0;

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2; //O(log n)
                count++;

                if (number == array[mid]) return mid;

                if (number < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }

        public int SmartPaul(int[] array, int number, out int count)
        {
            count = 0;

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                count++;

                if (number == array[mid]) return mid;

                if (number < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

                //addition of Paul!
                if (number < array[left] || number > array[right]) return -1;
            }
            return -1;
        }

        public void Method(int[] array)
        {
            for (int i = 0; i < array.Length; i++)      //n
            {
                for (int j = 0; j < array.Length; j++)  //n --> O(n^2)
                {
                    //do something
                }
            }
        }

    }
}
