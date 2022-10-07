using System;
using System.Collections.Generic;
using System.IO;

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
            Dictionary<string, int> data = ReadData("data.csv");
            foreach (var item in data)
            {
                Console.WriteLine(item.Key + " --> " + item.Value);
            }
        }
    }
}
