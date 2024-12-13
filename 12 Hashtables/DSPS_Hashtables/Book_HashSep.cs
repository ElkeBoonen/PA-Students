
using System;

namespace DSPS_Hashtables
{
    internal class Book_HashSep
    {
        List<KeyValuePair<string, double>>[] book;

        public Book_HashSep(int items)
        {
            int size = NextPrime((int)(items*1.3));
            book = new List<KeyValuePair<string, double>>[size];
            for (int i = 0; i < size; i++)
            {
                book[i] = new List<KeyValuePair<string, double>>();
            }
        }

        private int NextPrime(int nr)
        {
            while (true)
            {
                nr += 1;
                bool flag = true;
                for (int i = 2; i < nr / 2; i++)
                {
                    if (nr % i == 0) flag = false;
                }
                if (flag) return nr;
            }
        }

        private int HashFunction(string product)
        {
            long h = 0;
            foreach (char c in product)
            {
                h = (31 * h) + (int)c;
            }
            return (int)(h % book.Length);

        }
        internal void AddItem(string product, double price)
        {
            int index = HashFunction(product);
            book[index].Add(new KeyValuePair<string, double>(product, price));
        }

        internal string GetPrice(string product)
        {
            int index = HashFunction(product);

            foreach (KeyValuePair<string, double> kvp in book[index])
            {
                if (product == kvp.Key) return kvp.Value.ToString();
            }
            return "not found";
        
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < book.Length; i++)
            {
                s += i + " --> ";
                foreach (KeyValuePair<string, double> kvp in book[i])
                {
                    s += kvp.Key + ":" + kvp.Value + " --> ";
                }
                s += "\n";
            }
            return s;
        }
    }
}