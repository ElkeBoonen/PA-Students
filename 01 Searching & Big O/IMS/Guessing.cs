using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    internal class Guessing
    {
        public int Guesses { get; set; }
        public int Linear(int[] array, int number)
        {
            Guesses = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Guesses++;
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Stupid(int[] array, int number)
        {
            Guesses = 0;
            List<int> guessed = new List<int>();
            Random random = new Random();

            do
            {
                int position = random.Next(0, array.Length);

                Guesses++;
                if (array[position] == number)
                {
                    return position;
                }
                else if (!guessed.Contains(position))
                { 
                    guessed.Add(position);
                }
            }
            while (guessed.Count < array.Length);
            return -1;
        }

        public int Binary(int[] array, int number)
        {
            Guesses = 0;

            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                Guesses++;
                if (array[mid] == number)
                {
                    return mid;
                }
                else if (number < array[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        public static void Example1(int[] array)
        {
            int n = array.Length;
            Random random = new Random();

            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }


        public static int[] Example2(int[] array)
        {
            int n = array.Length;
            int[] result = new int[n];
            result[0] = array[0];

            for (int i = 1; i < n; i++)
            {
                int j = i;
                while (j >= 0)
                {
                    result[i] += array[j];
                    j--;
                }
            }
            return result;
        }

        public static void Example3(int n)
        {
            int[,] matrix = new int[n, n];

            for (int i = 1; i < n; i *= 2)
            {
                matrix[i, i] = 1;
            }
        }

    }
}
