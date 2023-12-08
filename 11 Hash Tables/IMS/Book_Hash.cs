namespace IMS
{
    internal class Book_Hash
    {
        private double[] book;

        private int NextPrime(double d)
        {
            int nr = (int)d;
            bool isPrime = false;
            while (!isPrime)
            {
                isPrime = true;
                for (int i = 2; i < nr/2; i++)
                {
                    if (nr % i == 0) isPrime = false;
                }
                nr++;
            }
            return nr-1;
        }
        public Book_Hash(int keys)
        {
            book = new double[NextPrime(keys*1.3)];
        }

        private int HashFunction(string key)
        {
            int index = 0;
            foreach (char c in key)
            {
                index += (int)c;
            }
            return index % book.Length;
        }

        public override string ToString()
        {
            return String.Join("\n", book);
        }

        internal void AddItem(string product, double price)
        {
            int index = HashFunction(product);
            book[index] = price;
        }

        internal double GetPrice(string product)
        {
            return book[HashFunction(product)];
        }

    }
}