using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Big_O
{
    class Search
    {
        //simple sequential search 
        //input : int[] array and int number to find!
        //return position of number in array
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

        //simple stupid random search--> no for-loop! just random guesses!!!
        //input : int[] array and int number to find!
        //return position of number in array
        public int Stupid(int[] array, int number, out int count)
        {
            count = 0;

            Random rd = new Random();
            int i = 20000;

            while (i > 0 )
            {
                i--;
                count++;
                int value = rd.Next(0, array.Length);
                if (array[value] == number) return value;
                
               
            }
            return -1;
        }

        //binary search
        //input : int[] array and int number to find!
        //return position of number in array
        public int Binary(int[] array, int number, out int count)
        {
            count = 0;

            int upper = array.Length-1;
            int lower = 0;
            int middle;

            while (lower <= upper)
            {
                middle = (upper + lower) / 2; //lower + ((upper - lower) / 2);
                //Console.Write(middle + " ");
                count++;

                if (array[middle] > number) upper = middle - 1;
                else if (array[middle] < number) lower = middle + 1;
                else return middle;

            }
            return -1;
        }
    }
}
