using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Les2
{
    class Selection
    {

        public int Count { private set; get; }

        public int FindSmallest(List<int> list)
        {
            int smallest = list[0];
            int index_smallest = 0;

            for (int i = 1; i < list.Count; i++)
            {
                Count++;
                if (list[i] < smallest)
                {
                    smallest = list[i];
                    index_smallest = i;
                }
            }
            return index_smallest;
        }

        public List<int> Sort(List<int> list)
        {
            Count = 0;
            List<int> sorted_list = new List<int>();

            while (list.Count > 0)
            {
                Count++;
                int index = FindSmallest(list);
                sorted_list.Add(list[index]);
                list.RemoveAt(index);
            }

            return sorted_list;
        }

        public List<int> Sort2(List<int> list) //in place veranderen!!!
        {
            Count = 0;

            for (int i =0; i < list.Count; i++)
            {
                int smallest = list[i];
                int smallest_index = i; 
                for (int j = i+1; j < list.Count; j++)
                {
                    Count++;
                    if (list[j] < smallest)
                    {
                        smallest = list[j];
                        smallest_index = j;
                    }
                }

                int temp = list[i];
                list[i] = list[smallest_index];
                list[smallest_index] = temp;
            }

            return list;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {    
	        int[] array = Array.ConvertAll(File.ReadAllText("random_1000.txt").Trim().Split(" "), int.Parse);

            Console.WriteLine(String.Join(" ",array));

            Selection selection = new Selection();
            Console.WriteLine(String.Join(" ", selection.Sort(array.ToList())) + " in " + selection.Count + " stappen");
            Console.WriteLine(String.Join(" ", selection.Sort2(array.ToList())) + " in " + selection.Count + " stappen");


        }
    }
}