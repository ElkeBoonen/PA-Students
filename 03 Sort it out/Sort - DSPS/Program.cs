using System;
using System.Collections.Generic;
using System.Linq;
using TM.ProgrammingAdvanced;

namespace Sort___DSPS
{
    class Program
    {

        static int Map(int s, int a1, int a2, int b1, int b2)
        {
            return b1 + (((s - a1) * (b2 - b1)) / (a2 - a1));
        }

        static int[] First(int nr)
        {
            Dictionary<string, int> songs = Data.Songs;

            int a1 = songs.Values.ToArray().Min();
            int a2 = songs.Values.ToArray().Max();

            int[] array = new int[nr];

            for (int i = 0; i < nr; i++)
            {
                array[i] = Map(songs.ElementAt(i).Value, a1,a2,1,100);
            }
            return array;

        }
        static void Main(string[] args)
        {
            int[] array = First(10);
            SortMethods methods = new SortMethods();
            methods.Bubble(array);

            /*KeyValuePair<string, int>[] songs = Data.Songs.ToArray();
            methods.Bubble(songs);
            foreach (var item in songs)
            {
                Console.WriteLine(item.Key + " --> " + item.Value);
            }*/

            array = First(10);
            methods.Selection(array);

            array = First(10);
            methods.Insertion(array);


        }
    }
}
