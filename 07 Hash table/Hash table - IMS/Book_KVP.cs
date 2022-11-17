using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hash_table
{
    class Book_KVP
    {
        private KeyValuePair<string, double>[] book;
        private int index = 0;

        public Book_KVP(int items)
        {
            book = new KeyValuePair<string, double>[items];
        }

        public void AddItem(string key, double value)
        {
            KeyValuePair<string, double> item = new KeyValuePair<string, double>(key, value);
            book[index] = item;
            index++;
        }

        public double GetPrice(string find)
        {
            foreach (var item in book)
            {
                if (find == item.Key) return item.Value;
            }
            return -1;
        }

        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i < index; i++)
            {
                s += book[i].Key + ": " + book[i].Value + "\n";
            }
            return s;
        }
    }
}
