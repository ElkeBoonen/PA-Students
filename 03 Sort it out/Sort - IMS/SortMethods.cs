using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort___IMS
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
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    int swap;
                    if (array[j] > array[j + 1])
                    {
                        swap = array[j];
                        array[j] = array[j+1];
                        array[j + 1] = swap; 
                    }
                    //Print(array);
                }
            }
        }

        public void Selection(int[] array)
        {
            int smallest;
            for (int i = 0; i < array.Length; i++)
            {
                smallest = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }

                int swap = array[smallest];
                array[smallest] = array[i];
                array[i] = swap;
                Print(array);
            }
        }

        public void Insertion(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];

                int j = i;
                for (j = i; j > 0; j--)
                {
                    if (array[j - 1] < temp) break;
                    
                    array[j] = array[j - 1];
                }
                array[j] = temp;
                Print(array);
            }
        }

        public void Bubble(KeyValuePair<string, int>[] songs)
        {

            for (int i = 0; i < songs.Length; i++)
            {
                for (int j = 0; j < songs.Length - i - 1; j++)
                {
                    KeyValuePair<string, int> swap;

                    if (songs[j].Value > songs[j+1].Value)
                    {
                        swap = songs[j];
                        songs[j] = songs[j + 1];
                        songs[j + 1] = swap;
                        
                    }
                }
            }
        }
    }
}
