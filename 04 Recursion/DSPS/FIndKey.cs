using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    class FindKey
    {
        public int Count { get; set; }

        public string Algorithm1(string basefolder)
        {
            /*
                Open the folder and make a list of folders inside
                Take a folder and look trough it
                If you find a file iside: you are done!
                Otherwise add - the folders inside - to the list
                Repeat as long as list isn't empty!
                or stop when file is found!
             */

            Queue<string> folders = new Queue<string>();
            folders.Enqueue(basefolder);
            while (folders.Count > 0)
            {
                Count++;
                string folder = folders.Dequeue();

                if (Directory.Exists(folder))
                {
                    if (Directory.GetFiles(folder).Length > 0) return folder;

                    foreach (string item in Directory.GetDirectories(folder))
                        folders.Enqueue(item);
                }
            }
            return "not found";
        }

        public string Algorithm2(string folder)
        {
            /*
             * Check every item in folder
             * if it is a box --> return to step 1
             * if it is a file: you are done!
             * */

            Count++;

            foreach (string item in Directory.EnumerateFileSystemEntries(folder))
            {
                if (Directory.Exists(item))
                {
                    string result = Algorithm2(item);
                    if (result != "not found") return result;
                }
                if (File.Exists(item))
                {
                    return item;
                }
            }
            return "not found";
        }
    }
}
