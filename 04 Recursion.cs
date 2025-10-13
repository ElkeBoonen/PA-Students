using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//C:\3orhyvogped\5sgv1p1r5a0\m5g31zw2mn4\bvep55pmtcl\d13p2vos05n\ktq3yytklla --> hier zit file!

namespace PAStudents
{
    class Recursion
    {
        public int Count { get; set; }
        public string Algorithmn1(string basefolder)
        {

            List<string> folders = new List<string>();
            folders.Add(basefolder);

            while (folders.Count != 0)
            {
                Count++;
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

        public string Algorithmn2(string basefolder)
        {
            Count++;
            foreach (string entry in Directory.GetFileSystemEntries(basefolder))
            {
                if (Directory.Exists(entry))
                {
                    string result = Algorithmn2(entry);
                    if (result != "not found") return result;
                }
                else return "found in " + basefolder;
            }
            return "not found";

        }

        public int Factorial(int n)
        {
            if (n <= 2) return n;
            int result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        public int FactorialRec(int n)
        {
            if (n <= 1) return 1;
            return n * FactorialRec(n - 1);
        }

        //Sum of Natural Numbers: compute the sum of the first n natural numbers recursively.
        /*int result = 0;
        for (int i =0; i<n; i++)
        {
            result += 1;
        }*/
        public int Sum(int n)
        {
            if (n <= 0) return 0;
            return n + Sum(n - 1);
        }

        //Count Digits: count the number of digits in a number using a recursive approach.
        //int n = 145;
        //n.toString().Length

        public int Digits(int n)
        {
            if (n < 10) return 1;
            return 1 + Digits(n / 10);
        }

        //Reverse String: recursively reverse the characters in a string.
        public string Reverse(string s)
        {
            if (s.Length == 1) return s;
            return Reverse(s.Substring(1)) + s[0];

        }

        public int CountChar(string word, char c)
        {
            if (word.Length == 0) return 0;

            if (word[0] == c) return 1 + CountChar(word.Substring(1), c);
            return CountChar(word.Substring(1), c);
        }

        public int CountChar2(string word, char c, int index = 0)
        {
            if (index == word.Length) return 0;

            if (word[index] == c) return 1 + CountChar2(word, c, ++index);  //index++ --> post increment zorgt voor stack overflow!!!
            return CountChar2(word, c, ++index);                            //dus gebruik ALTIJD ++index of index+1 in zo'n geval!
        }

    }
}