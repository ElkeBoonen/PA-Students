using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//C:\3orhyvogped\5sgv1p1r5a0\m5g31zw2mn4\bvep55pmtcl\d13p2vos05n\ktq3yytklla --> hier zit file!

namespace PAStudents
{
    class Recursion
    {
        public string Algorithmn1(string basefolder)
        {
            List<string> folders = new List<string>();
            folders.Add(basefolder);

            while (folders.Count != 0)
            {
                string folder = folders.First();
                folders.RemoveAt(0);
                if (File.Exists(Path.Combine(folder, "key.txt")))
                {
                    return "found in " + folder;
                }

                folders.AddRange(Directory.GetDirectories(folder));
            }
            return "not found";

        }

    }
}