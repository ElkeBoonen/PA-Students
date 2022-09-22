using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Big_O___IMS
{
    class Search
    {
        private int[] _array;

        public Search(int[] array)
        {
            _array = array;
        }

        public int Simple(int number, out int count) //O(n)
        {
            count = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                count++;
                if (_array[i] == number) return i;
            }
            return -1;
        }

        public int Stupid(int number, out int count)
        {
            int guesses = _array.Length;
            count = 0;

            Random rd = new Random();

            while (guesses > 0) //O(n) maar stel guesses is vast getal --> O(1)
            {
                int guess = rd.Next(0, 1000);
                guesses--;
                count++;
                if (_array[guess] == number) return guess;
            }
            return -1;
        }

        public int Smart(int number, out int count)
        {
            count = 0;

            int left = 0;
            int right = _array.Length-1;

            while (left <= right) //bepaalt O
            {
                int mid = (left+right) / 2;     // delen 2 --> O(log n)
                count++;

                if (_array[mid] == number) return mid;

                if (_array[mid] < number)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

    }
}
