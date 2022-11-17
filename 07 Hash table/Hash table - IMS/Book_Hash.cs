using System;
using System.Collections.Generic;
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
    }
}
