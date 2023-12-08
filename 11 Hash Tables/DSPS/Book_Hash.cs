namespace DSPS
{
    internal class Book_Hash
    {
        private int v;
        private double[] book;

        private int NextPrime(int nr) 
        {
            nr++;
            while (true)
            {
                bool isPrime = true;
                for (int i = 2; i < nr/2; i++)
                {
                    if (nr % i == 0) isPrime = false;
                }
                if (isPrime) return nr;
                nr++;
            }
        }

        public int GetSize()
        {
            return book.Length;
        }
        public Book_Hash(int items)
        {
            //Let M be the next prime larger than 1.3 times the number of keys
            double size = items * 1.3;
            book = new double[NextPrime((int)Math.Ceiling(size))];
        }

        private int HashFunction(string key)
        {
            double index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index += (int)key[i] + Math.Pow(31,i);
            }
            return (int)(index % GetSize());
        }

        public void AddItem(string product, double price)
        {
            int index = HashFunction(product);
            book[index] = price;
        }

        public override string ToString()
        {
            return String.Join("\n", book);
        }

        internal double GetPrice(string product)
        {
            int index = HashFunction(product);
            return book[index];
        }
    }
}