﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable_DSPS
{
    class Book_Hash_SC
    {
        private List<KeyValuePair<string,double>>[] book;

        private int NextPrime(int nr)
        {
            if (nr % 2 == 0) nr++;
            while (true)
            {
                bool flag = true;
                for (int i = 3; i <= nr/2; i+=2)
                {   
                    if (nr % i == 0) 
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) return nr;
                nr+=2;
            }    
        }

        public Book_Hash_SC(int maxkey)
        {
            int length = NextPrime((int)(maxkey * 1.3));
            book = new List<KeyValuePair<string, double>>[length];
            Console.WriteLine(length);
        }

        private int Hash(string key)
        {
            long sum = 0;
            foreach (char item in key) sum = (31*sum) + (int)item;
            return (int)(sum % book.Length);
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
            string s = "";
            for (int i = 0; i < book.Length; i++)
            {
                s += i;
                if (book[i] != null)
                {
                    foreach (var item in book[i])
                    {
                        s += " --> " + item.Key + ":"+item.Value;
                    }
                }
                s += "\n";
            }
            return s;
        }

    }
}