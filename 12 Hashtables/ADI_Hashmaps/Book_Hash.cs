
using System.Numerics;

namespace ADI_Hashmaps
{
    internal class Book_Hash
    {
        private double[] book;

        private int NextPrime(int nr)
        {
            while (true)
            {
                nr+=1;
                bool flag = true;              
                for (int i = 2; i <= (int)Math.Sqrt(nr); i++)
                {
                    if (nr % i == 0) { flag = false; break; }
                }
                if (flag) return nr;
            }
        }

        public Book_Hash(int items)
        {
            int size = NextPrime((int)(items * 1.3)); //item = 5 --> 5*1.3 = 6.5, prime na 6
            book = new double[size];
        }

        private int HashFunction(string value)
        {
            /*int h = 0;
            foreach (char c in value) h += (int)c;
            return h % book.Length;
            */
            long h = 0;
            foreach (char c in value)
                h = (31 * h) + (int)c;
            return (int)(h%book.Length);
            
            }

        internal void AddItem(string product, double price)
        {
            int index = HashFunction(product);
            book[index] = price;
        }

        internal string GetPrice(string product)
        {
            int index = HashFunction(product);
            return book[index].ToString();
        }

        public override string ToString()
        {
            return String.Join("\n", book);
        }
    }
}