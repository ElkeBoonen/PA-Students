using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSION_ADI
{
    internal class KeyInBox
    {
        public int Count { get; set; }
        public string Algorithm1(string folder)
        { 
            List<string> folders = new List<string>();
            folders.Add(folder);

            while (folders.Count > 0)
            {
                Count++;
                folder = folders[0];
                if (Directory.GetFiles(folder).Length > 0) return folder;
                folders.AddRange(Directory.GetDirectories(folder));
                folders.RemoveAt(0);
            }
            return null;
        }

        public string Algorithm2(string folder)
        {
            foreach (var item in Directory.GetFileSystemEntries(folder))
            {
                Count++;
                if (Directory.Exists(item))
                {
                    string result = Algorithm2(item);
                    if (result != null) return result;
                }
                else if (File.Exists(item)) return item;
            }
            return null;
        }
    }
}
