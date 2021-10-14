using System;
using System.Collections.Generic;
using System.Text;

namespace Sort___DSPS
{
    class SortMethods
    {

        public void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void Bubble(int[] array)
        {
            Console.WriteLine("\nBUBBLE");
            for (int i = 0; i < array.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = false;
                    }
                    Print(array);
                }
                if (flag) return;
            }  
        }

        public void Selection(int[] array)
        {
            Console.WriteLine("\nSELECTION");
            for (int i = 0; i < array.Length; i++)
            {
                int smallest_index = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[smallest_index])
                    {
                        smallest_index = j;
                    }
                }

                int temp = array[i];
                array[i] = array[smallest_index];
                array[smallest_index] = temp;
                Print(array);
            }

        }

        public void Insertion(int[] array)
        {

            Console.WriteLine("\nINSERTION");
            Print(array);
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                int j;
                for (j = i; j > 0; j--)
                {
                    if (array[j-1] > temp) array[j] = array[j-1];
                    else break;
                }
                array[j] = temp;
                Print(array);

            }
        }

        public void Bubble(KeyValuePair<string, int>[] songs)
        {
            for (int i = 0; i < songs.Length; i++)
            {
                for (int j = 0; j < songs.Length-1-i; j++)
                {
                    if (songs[j].Value > songs[j + 1].Value)
                    {
                        KeyValuePair<string, int> temp = songs[j];
                        songs[j] = songs[j + 1];
                        songs[j + 1] = temp;
                    }
                }
            }
        }

    }
}
