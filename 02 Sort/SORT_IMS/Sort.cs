using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SORT_IMS
{
    internal class Sort
    {
        public int Count { get; set; }

        public void Bubble(int[] array)
        {
            Count = 0;
            for (int i = 0; i < array.Length; i++)
            {

                bool flag = true;

                for (int j = 0; j < array.Length - 1 -i; j++)
                {
                    Count++;
                    if (array[j] > array[j + 1])
                    {
                        flag = false;
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                if (flag) return; 
            }
        }

        /*
        public void Bubble(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j][0] > array[j + 1][0])
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }*/

        //https://learn.microsoft.com/en-us/dotnet/api/system.string.compare?view=net-8.0
        public void Bubble(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    /*
                        array[j] < array[j+1]) --> String.compare geeft -1
                        array[j] > array[j+1]) --> String.compare geeft 1
                        array[j] == array[j+1]) --> String.compare geeft 0
                     */

                    if (String.Compare(array[j], array[j + 1]) > 0)
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void Selection(int[] array) 
        {
            Count = 0;
            for (int i = 0; i < array.Length; i++) 
            { 
                int min = array[i];
                int index = i;
                for (int j = i + 1; j < array.Length; j++) 
                {
                    Count++;
                    if (array[j] < min) 
                    { 
                        min = array[j];
                        index = j;
                    } 
                } 
                int temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
        }

        public void Insertion(int[] array)
        {
            Count = 0;
            for (int i = 1; i < array.Length; i++)
            {
                int x = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > x)
                {
                    Count++;
                    array[j+1] = array[j];
                    j--;
                }
                array[j + 1] = x;
            }
        }

    }
}
