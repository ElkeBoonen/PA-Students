using System;
using System.IO;

namespace PAStudents
{
    
    public class Searching
    {
        int[] array;
        public int Count { get; set; }

        public Searching()
        {
            //array = new int[] { -10, -7, -5, -2, 0, 1, 2, 4, 5, 7, 9 };
            string[] numbers = File.ReadAllLines("sorted_numbers.txt");
            array = Array.ConvertAll(numbers, int.Parse);
        }

        public int Linear(int number)
        {
            Count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Count++;
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Stupid(int number)
        {
            Count = 0;
            Random rd = new Random(); //https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-9.0
            int i = -1;
            while (Count < array.Length)
            {
                i = rd.Next(0, array.Length);
                if (array[i] == number)
                {
                    return i;
                }
                Count++;
            }
            return -1;
        }

        public int Binary(int number)
        {
            Count = 0;

            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2; //integer deling !!! afgekapt!
                Count++;

                if (array[mid] == number)
                {
                    return mid;
                }
                else if (array[mid] < number)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
    } 

}