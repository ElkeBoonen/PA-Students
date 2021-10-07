using System;
using System.Collections.Generic;
using System.Linq;
using TM.ProgrammingAdvanced;

namespace Sort___IMS
{
    class Program
    {

        const int b1 = 1;
        const int b2 = 50;

        static int Map(int s, int a1, int a2)
        {
            return (int)(b1 + (((s - a1) * (b2 - b1)) / (a2 - a1)));
        }
        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(KeyValuePair<string,int>[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, int> songs = Data.Songs;
            int a1 = songs.Values.ToArray().Min();
            int a2 = songs.Values.ToArray().Max();

            /*foreach (var item in songs)
            {
                Console.WriteLine(item.Key + " " + Map(item.Value, a1, a2));
            }*/

            int[] array = new int[] { 24, 32, 58, 1, 5, 9, 16 };
            Print(array);
            SortMethods methods = new SortMethods();
            methods.Bubble(array);
            Print(array);

            KeyValuePair<string, int>[] arraySongs = songs.ToArray();
            methods.Bubble(arraySongs);
            Print(arraySongs);


        }
    }
}
