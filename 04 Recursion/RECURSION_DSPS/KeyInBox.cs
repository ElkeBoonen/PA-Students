using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RECURSION_DSPS
{
    internal class KeyInBox
    {
        /*
            Open the folder and make a list of folders inside
            Take a folder and look trough it
            If you find a file iside: you are done!
            Otherwise add - the folders inside - to the list
            Repeat as long as list isn't empty!
            or stop when file is found!
         */

        public int Count { get; set; }
        public string Algorithm1(string basefolder)
        {
            List<string> folders = new List<string>();
            folders.Add(basefolder);

            while (folders.Count > 0)
            {
                Count++;
                string folder = folders.First();
                if (Directory.GetFiles(folder).Length > 0)
                {
                    return folder;
                }
                folders.AddRange(Directory.GetDirectories(folder));
                folders.Remove(folder);
            }
            return null;
        }


        /*
            Check every item in folder
            if it is a box --> return to step 1
            if it is a file: you are done!
         */
        public string Algorithm2(string basefolder)
        {
            foreach (var item in Directory.EnumerateFileSystemEntries(basefolder))
            {
                Count++;
                if (Directory.Exists(item))
                {
                    string value = Algorithm2(item);
                    if (value != null) return value;
                }
                else if (File.Exists(item)) return item;
            }
            return null;
        }
    }
}
