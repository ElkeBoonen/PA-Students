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

        public int AddItem(string key, double value)
        {
          
            return -1;
        }

        public double GetPrice(string key)
        {
            
            return -1;
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
