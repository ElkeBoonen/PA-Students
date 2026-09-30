using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Les1
{
    class Oefening
    {
        public int Som(int[] array) //O(1) ruimte, O(n) ruimte
        {
            int som = 0;
            foreach (int element in array)
            {
                som += element;
            }
            return som;
        }

        public string MinMax(int[] array)
        {
            int min = array[0];
            int max = array[0];

            foreach (int element in array)
            {
                if (element < min) min = element;
                if (element > max) max = element;
            }
            return min + " " + max;
        }

        public string MinMax2(int[] array)
        {
            Array.Sort(array);
            int min = array[0];
            int max = array[array.Length-1];
            return min + " " + max;
        }

        //4 7 4 1 7 9 8 8
        public List<int> Uniek1(int[] array)
        {
            //dictionary
            //tijd --> O(n), plaats --> O(n)
            Dictionary<int,int> dictionary = new Dictionary<int,int>();

            foreach(int element in array)
            {
                if (dictionary.ContainsKey(element)) dictionary[element]++;
                else dictionary[element] = 1;
            }

            return dictionary.Keys.ToList();
        }

        public List<int> Uniek2(int[] array)
        {
            //1 loop met contains
            //O(n²) contains heeft onderliggende for-loop!!
            List<int> list = new List<int>();
            foreach(int element in array)
            {   
                if (!list.Contains(element)) list.Add(element);
            }
            return list;
        }

        public List<int> Uniek3(int[] array)
        {
            //2 loops
            List<int> list = new List<int>();
            for (int i =0; i < array.Length; i++)
            {   
                int count = 0;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]==array[j]) count++;
                }
                if (count == 0) list.Add(array[i]);
            }
            return list;
        }

        public List<int> Uniek4(int[] array)
        {
            //sorteren
            List<int> list = new List<int>();
            Array.Sort(array);

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i-1]!=array[i])
                {
                    list.Add(array[i-1]);
                    if (i==array.Length-1) list.Add(array[i]);
                }
            }

            return list;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {    
            int[] array = Array.ConvertAll(Console.ReadLine().Split(" "), Int32.Parse);
            int target = Convert.ToInt32(Console.ReadLine());

            Search search = new Search();

            //Console.WriteLine(search.Linear(array, target) + " aantal stappen: " + search.Teller);
            //Console.WriteLine(search.Binary(array, target) + " aantal stappen: " + search.Teller);

            Oefening oef = new Oefening();
            //Console.WriteLine(oef.Som(array));
            //Console.WriteLine(oef.MinMax(array));
            //Console.WriteLine(oef.MinMax2(array));

            Console.WriteLine(String.Join(" ", oef.Uniek1(array)));
            Console.WriteLine(String.Join(" ", oef.Uniek2(array)));
            Console.WriteLine(String.Join(" ", oef.Uniek3(array)));
            Console.WriteLine(String.Join(" ", oef.Uniek4(array)));





        }
    }
}