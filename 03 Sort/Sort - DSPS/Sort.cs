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

        //sort on value --> integer
        public void Bubble(KeyValuePair<string,int>[] array)
        {
            for (int i = 0; i < array.Length; i++)  //O(n)
            {
                for (int j = 0; j < array.Length - 1 - i; j++) // 0(n) --> inside eachother O(n^2)
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

        //sort on key --> string --> String.Compare 
        //https://learn.microsoft.com/en-us/dotnet/api/system.string.compare?view=net-6.0
        public void Bubble(KeyValuePair<string, int>[] array, bool key)
        {
            for (int i = 0; i < array.Length; i++)  //O(n)
            {
                for (int j = 0; j < array.Length - 1 - i; j++) // 0(n) --> inside eachother O(n^2)
                {
                    if (String.Compare(array[j].Key,array[j + 1].Key) > 0)
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
            for (int i = 0; i < array.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }

        public void Selection(KeyValuePair<string, int>[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min].Value > array[j].Value)
                    {
                        min = j;
                    }
                }
                KeyValuePair<string, int> temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }

        public void Insertion(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }
}
