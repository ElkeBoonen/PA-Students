﻿using System;
using System.Collections.Generic;
using System.Linq;
using TM.ProgrammingAdvanced;

namespace Sorting___IMS
{
    class Program
    {
        static int[] MapValues(int[] array, int b1, int b2)
        {
            int a1 = array.Min(); int a2 = array.Max();
            int[] newValues = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newValues[i] = b1 + ((array[i] - a1) * (b2 - b1) / (a2 - a1));
            }
            return newValues;
        }

        static void Main(string[] args)
        {
            Dictionary<string, int> songs = Data.Songs;
            /*foreach (KeyValuePair<string, int> pair in songs)
            { 
                Console.WriteLine(pair.Value);
            }*/

            int[] array = MapValues(songs.Values.ToArray(), 0, 100);
            //Console.WriteLine(String.Join(" ", array));

            Console.WriteLine("BUBBLE");
            Sorting sorting = new Sorting();
            int[] int_array = new int[] { 8, 9, 4, 1, 7 };
            sorting.Bubble(int_array);
            Console.WriteLine(String.Join(" ", int_array));

            KeyValuePair<string, int>[] songs_array = songs.ToArray();
            sorting.Bubble(songs_array);
            Console.WriteLine(String.Join("\n", songs_array));

            Console.WriteLine("SELECTION");
            int_array = new int[] { 8, 9, 4, 1, 7 };
            Console.WriteLine(String.Join(" ", int_array));
            sorting.Selection(int_array);
            Console.WriteLine(String.Join(" ", int_array));

            Console.WriteLine("INSERTION");
            int_array = new int[] { 8, 9, 4, 1, 7 };
            Console.WriteLine(String.Join(" ", int_array));
            sorting.Insertion(int_array);
            Console.WriteLine(String.Join(" ", int_array));
        }
    }
}