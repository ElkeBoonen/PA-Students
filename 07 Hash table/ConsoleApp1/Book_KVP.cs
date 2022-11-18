using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable_DSPS
{
    class Book_KVP
    {
        private KeyValuePair<string, double>[] book;

        public Book_KVP(int length)
        {
            book = new KeyValuePair<string, double>[length];
        }

        public int AddItem(string key, double value)
        {
            for (int i = 0; i < book.Length; i++)
            {
                if (book[i].Key==null)
                {
                    book[i] = new KeyValuePair<string, double>(key, value);
                    return i;
                }
            }
            return -1;
        }

        public double GetPrice(string key)
        {
            foreach (var item in book)
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
                s += i + " --> ";
                if (book[i].Key!=null)  s += book[i].Key+":"+book[i].Value;
                s += "\n";
            }
            return s;
        }

    }
}
