using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TM.ProgrammingAdvanced;

namespace Sort___DSPS
{
    internal class Program
    {
        static public Dictionary<string, int> ReadData(string file)
        { 
            Dictionary<string, int> data = new Dictionary<string, int>();
            foreach (var item in File.ReadAllLines(file))
            {
                //rank,uri,artist_names,track_name,source,peak_rank,previous_rank,weeks_on_chart,streams
                string[] items = item.Replace(", ", " ").Split(",");
                string title = items[3].Replace("\"", "");
                int streamcount;

                if (Int32.TryParse(items[8].Replace("\"", ""), out streamcount))
                {
                    data[title] = streamcount;
                }
                
            }
            return data;
        }

        static void Main(string[] args)
        {
            //Dictionary<string, int> data = Data.Songs;
            Dictionary<string, int> data = ReadData("data.csv");
            /*foreach (var item in data)
            {
                Console.WriteLine(item.Key + " --> " + item.Value);
            }*/

            Sort sort = new Sort();

            int[] int_array = new int[] { 5, 3, 7, 1, 8 };
            Console.WriteLine($"unsorted: {String.Join(" ", int_array)}");
            sort.Bubble(int_array);
            Console.WriteLine($"bubble sort: {String.Join(" ", int_array)}");

            KeyValuePair<string, int>[] songs = data.ToArray();
            sort.Bubble(songs);
            Console.WriteLine(String.Join("\n", songs));

            int_array = new int[] { 5, 3, 7, 1, 8 };
            Console.WriteLine($"unsorted: {String.Join(" ", int_array)}");
            sort.Selection(int_array);
            Console.WriteLine($"selection sort: {String.Join(" ", int_array)}");

            int_array = new int[] { 5, 3, 7, 1, 8 };
            Console.WriteLine($"unsorted: {String.Join(" ", int_array)}");
            sort.Insertion(int_array);
            Console.WriteLine($"insertion sort: {String.Join(" ", int_array)}");

            sort.Count = 0;
            int_array = Data.Numbers;
            sort.Bubble(int_array);
            Console.WriteLine("bubble: " + sort.Count);

            sort.Count = 0;
            int_array = Data.Numbers;
            sort.Selection(int_array);
            Console.WriteLine("selection: " + sort.Count);

            sort.Count = 0;
            int_array = Data.Numbers;
            sort.Insertion(int_array);
            Console.WriteLine("insertion: " + sort.Count);


        }
    }
}
