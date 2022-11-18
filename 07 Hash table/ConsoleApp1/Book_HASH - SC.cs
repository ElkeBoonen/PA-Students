using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable_DSPS
{
    class Book_Hash
    {
        private double[] book;

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

        public Book_Hash(int maxkey)
        {
            int length = NextPrime((int)(maxkey * 1.3));
            book = new double[length];
            Console.WriteLine(length);
        }

        private int HashSimple(string key)
        {
            int sum = 0;
            foreach (var item in key) sum += item;
            return sum % book.Length;
        }

        private int Hash(string key)
        {
            long sum = 0;
            foreach (char item in key) sum = (31*sum) + (int)item;
            return (int)(sum % book.Length);
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
            string s = "";
            for (int i = 0; i < book.Length; i++)
            {
                s += i + " --> " + book[i] + "\n";
            }
            return s;
        }

    }
}
