using System;
using System.IO;
using System.Collections.Generic;

namespace Les5
{
    class Oefeningen
    {
        public string TwoSum(int[] array, int target)
        {
            for (int i=0; i < array.Length; i++)
            {
                for (int j=i+1; j < array.Length; j++)
                {
                    if (array[i]+array[j]==target)
                    {
                        return array[i] + " + " + array[j] + " = " + target;
                    }
                }
            }
            return "geen paar gevonden!";
        }

        public string TwoSumDict(int[] array, int target)
        {
            Dictionary<int,int> dictionary = new Dictionary<int, int>();
            for (int i=0; i < array.Length; i++)
            {
                int match = target - array[i];
                if (dictionary.ContainsKey(match))
                {
                    return array[i] + " + " + match + " = " + target; 
                }
                else dictionary.Add(array[i],0);

            }
            return "geen paar gevonden!";
        }

        //: [melk, reep, klem, peer, kaas
        public string Anagram(string[] woorden)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            foreach (string woord in woorden)
            {
                char[] letters = woord.ToCharArray();
                Array.Sort(letters);
                string gesorteerd = new string(letters);
                if (!dictionary.ContainsKey(gesorteerd))
                {
                    dictionary.Add(gesorteerd, new List<string>());
                }
                dictionary[gesorteerd].Add(woord);
            }

            string s = "";
            foreach (List<string> list in dictionary.Values)
            {
                s += String.Join(" ", list) + "\n";
            }
            return s;
        }
    }
}