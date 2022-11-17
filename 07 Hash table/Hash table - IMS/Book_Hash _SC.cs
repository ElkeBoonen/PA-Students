using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Hash_table
{
    class Book_Hash_SC
    {
        private List<KeyValuePair<string,double>>[] book;

        private int NextPrime(int start)
        {
            while (true)
            {
                bool prime = true;
                for (int i = 2; i <= start/2; i++)
                {
                    if (start % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime) return start;
                start++;
            }
        }
        public Book_Hash_SC(int maxkeys)
        {
            //perfect grootte hashtable
            //volgende priemgetal na 1.3 * maxkeys

            double size = maxkeys * 1.3;
            book = new  List<KeyValuePair<string, double>>[NextPrime((int)size)];
        }

        private int Hash(string key)
        {
            //simpele hash functie
            /*int sum = 0;
            foreach (char c in key) sum += c;
            return sum % book.Length;*/

            //horner's methode
            int sum = 0;
            for (int i = 0; i < key.Length; i++)
            {
                sum += key[i] * (int)Math.Pow(31, i);
            }
            return sum % book.Length;

        }
        public void AddItem(string key, double value)
        {
            int hash = Hash(key);
            if (book[hash] == null)
            {
                book[hash] = new List<KeyValuePair<string, double>>();
            }
            book[hash].Add(new KeyValuePair<string, double>(key, value));
        }
        public double GetPrice(string key)
        {
            int hash = Hash(key);
            foreach (var item in book[hash])
            {
                if (item.Key == key) return item.Value;
            }
            return -1;
        }
        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i < book.Length; i++)
            {
                s += i;
                if (book[i] != null)
                {
                    foreach (var item in book[i])
                    {
                        s += " --> " + item.Key + ":" + item.Value;
                    }
                }
                s += "\n";

            }
            return s;
        }
    }
}
