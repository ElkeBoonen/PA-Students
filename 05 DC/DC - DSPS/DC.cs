using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DC___DSPS
{
    class DC
    {

        public int Count { get; set; }

        public int SumIt(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        public int SumRL(List<int> list)
        {
            if (list.Count == 0) return 0;
            int nr = list[0];
            list.RemoveAt(0);
            return nr + SumRL(list);
        }

        public int SumRA(int[] array, int index=0)
        {
            if (index == array.Length) return 0;
            return array[index] + SumRA(array, ++index);
        }

        //unique values
        public List<int> QuickSort(List<int> list)
        {
            if (list.Count <= 1) return list;

            List<int> down = new List<int>();
            List<int> up = new List<int>();

            int pivot = list[0];
            foreach (var item in list)
            {
                Count++;
                if (item > pivot) up.Add(item);
                else if (item < pivot) down.Add(item);

            }
            return QuickSort(down).Union(new List<int> { pivot}).Union(QuickSort(up)).ToList();
        }

        //duplicate values
        public List<int> QuickSortD(List<int> list)
        {
            if (list.Count <= 1) return list;

            List<int> down = new List<int>();
            List<int> up = new List<int>();
            List<int> middle = new List<int>();

            int pivot = list[0];
            foreach (var item in list)
            {
                Count++;
                if (item > pivot) up.Add(item);
                else if (item < pivot) down.Add(item);
                else middle.Add(item);

            }
            //if you have duplicate values: work with concat!!!
            return QuickSortD(down).Concat(middle).Concat(QuickSortD(up)).ToList();
        }

        public void Selection(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool flag = true;
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    Count++;

                    if (flag && array[j - 1] > array[j]) flag = false;

                    if (array[min] > array[j])
                    {
                        Count++;
                        min = j;
                    }
                }
                Count++;
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;

                if (flag) break;
            }
        }

        public void Hanoi(int disk, char from, char to, char other)
        {
            if (disk == 1) Console.WriteLine($"{disk} from {from} to {to}");
            else
            {
                Hanoi(disk-1, from, other, to);
                Console.WriteLine($"{disk} from {from} to {to}");
                Hanoi(disk-1, other, to, from);
            }
        }

    }
}
