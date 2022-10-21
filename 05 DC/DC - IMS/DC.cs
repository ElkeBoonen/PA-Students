using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DC___IMS
{
    class DC
    {
        public int count { get; set; }

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

        public void Selection(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    count++;
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

        public List<int> QuickSort(List<int> list)
        {
            //als mijn list max 1 element bevat RETURN!! = basecase
            if (list.Count <= 1) return list;

            List<int> smaller = new List<int>();
            List<int> greater = new List<int>();
            List<int> pivotList = new List<int>();

            int pivot = list[0];

            for (int i = 0; i < list.Count(); i++)
            {
                count++;
                if (list[i] > pivot) greater.Add(list[i]);
                else if (list[i] < pivot) smaller.Add(list[i]);
                else pivotList.Add(list[i]);
            }

            return QuickSort(smaller)
                    .Concat(pivotList)
                    .Concat(QuickSort(greater)).ToList();
        }

        public void Hanoi(int number, char from, char to, char other)
        {
            if (number == 1) Console.WriteLine($"{number}: {from} {to}");
            else if (number > 1)
            {
                //1: A to B
                Hanoi(--number, from, other, to);
                //2: A to C
                Console.WriteLine($"{number}: {from} {to}");
                //1: B to C
                Hanoi(number, other, to, from);
            }
        }

    }
}
