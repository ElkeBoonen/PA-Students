using System;

namespace PAStudents
{
    public class Searching
    {
        int[] array;

        public Searching()
        {
            array = new int[] { -10, -7, -5, -2, 0, 1, 2, 4, 5, 7, 9 };
        }

        public int Linear(int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        public int Stupid(int number)
        {
            Random rd = new Random(); //https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-9.0
            int count = 0;
            int i = -1;
            while (count < array.Length)
            {
                i = rd.Next(0, array.Length);
                if (array[i] == number)
                {
                    return i;
                }
                count++;
            }
            return -1;
        }

        public int Binary()
        {
            return -1;
        }
    } 

}