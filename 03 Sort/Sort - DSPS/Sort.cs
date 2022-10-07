using System;
using System.Collections.Generic;
using System.Text;

namespace Sort___DSPS
{
    public class Sort
    {
        public void Bubble(int[] array)
        {
            for (int i = 0; i < array.Length; i++)  //O(n)
            {
                for (int j = 0; j < array.Length-1-i; j++) // 0(n) --> inside eachother O(n^2)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];    
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void Bubble(KeyValuePair<string,int>[] array)
        {
            for (int i = 0; i < array.Length; i++)  //O(n)
            {
                for (int j = 0; j < array.Length - 1 - i; j++) // 0(n) --> inside eachother O(n^2)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

    }
}
