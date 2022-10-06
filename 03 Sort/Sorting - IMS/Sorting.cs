using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting___IMS
{
    public class Sorting
    {
        public void Bubble(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }

        public void Bubble(KeyValuePair<string,int>[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].Value > array[j + 1].Value)
                    {
                        KeyValuePair<string, int> temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void Selection(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min_index])
                    {
                        min_index = j;
                    }
                }
                int temp = array[i];
                array[i] = array[min_index];
                array[min_index] = temp;
            }
        }

    }
}
