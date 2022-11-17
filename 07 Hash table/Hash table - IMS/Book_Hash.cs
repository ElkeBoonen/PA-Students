using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Hash_table
{
    class Book_Hash
    {
        private double[] book;

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
        public Book_Hash(int maxkeys)
        {
            //perfect grootte hashtable
            //volgende priemgetal na 1.3 * maxkeys

            double size = maxkeys * 1.3;
            book = new double[NextPrime((int)size)];
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
            book[Hash(key)] = value;
        }
        public double GetPrice(string key)
        {
            return book[Hash(key)];
        }
        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i < book.Length; i++)
            {
                s += i + ": " + book[i] + "\n";
            }
            return s;
        }
    }
}
