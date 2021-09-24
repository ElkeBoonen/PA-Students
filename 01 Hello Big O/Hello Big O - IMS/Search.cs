using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Big_O
{
    class Search
    {
        //SIMPLE SEARCH
        //parameters: int array and number we are looking for
        //return: position of number
        public int Simple(int[] array, int number, out int count)
        {
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
                if (array[i] == number) return i;
            }
            return -1;
        }

        public int Stupid(int[] array, int number, out int count)
        {
            count = 0;
            Random rd = new Random();
            int position;

            while (count < array.Length * 2)
            {
                count++;

                position = rd.Next(0, array.Length);
                if (array[position] == number) return position;
                count++;
            }
            return -1;
        }


        public int Binary(int[] array, int number, out int count)
        {
            count = 0;

            int lower = 0;
            int upper = array.Length - 1;
            int middle;

            while (lower <= upper)
            {
                count++;

                middle = (lower + upper) / 2;

                if (number == array[middle]) return middle;
                else if (number > array[middle]) lower = middle + 1;
                else upper = middle - 1;
            }

            return -1;
        }
    }
}
