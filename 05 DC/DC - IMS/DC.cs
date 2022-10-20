using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DC___IMS
{
    class DC
    {
        public int SumI(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}

            return sum;
        }
        public int SumRL(List<int> list)
        {
            if (list.Count == 0) return 0;
            int number = list[0];
            list.RemoveAt(0);
            return number + SumRL(list);
        }

        public int SumRA(int[] array, int index = 0)
        {
            if (index == array.Length) return 0;

            return array[index] + SumRA(array, ++index);
        }

        public List<int> QuickSort(List<int> list)
        { 
            
        }
    }
}
