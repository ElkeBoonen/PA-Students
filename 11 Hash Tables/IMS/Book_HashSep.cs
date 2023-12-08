namespace IMS
{
    internal class Book_HashSep
    {
        private List<KeyValuePair<string,double>>[] book;

        private int NextPrime(double d)
        {
            int nr = (int)d;
            bool isPrime = false;
            while (!isPrime)
            {
                isPrime = true;
                for (int i = 2; i < nr / 2; i++)
                {
                    if (nr % i == 0) isPrime = false;
                }
                nr++;
            }
            return nr - 1;
        }
        public Book_HashSep(int keys)
        {
            book = new List<KeyValuePair<string, double>>[NextPrime(keys * 1.3)];
        }

        private int HashFunction(string key)
        {
            long index = 0;
            foreach (char c in key) index = (31 * index) + (int)c;
            return (int)(index % book.Length);
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < book.Length; i++)
            {
                s += i + " ";
                if (book[i] != null)
                {
                    foreach (var item in book[i])
                    {
                        s += item.Key + ":" + item.Value + " - ";
                    }
                }
                else s += "null";
                s += "\n";
            }
            return s;
        }

        internal void AddItem(string product, double price)
        {
            int index = HashFunction(product);

            if (book[index] == null)
            {
                book[index] = new List<KeyValuePair<string, double>>();
            }
            book[index].Add(new KeyValuePair<string, double>(product,price));
        }

        internal double GetPrice(string product)
        {
            int index = HashFunction(product);
            foreach (var item in book[index])
            {
                if (item.Key == product) return item.Value;
            }
            return 0 ;
        }
    }
}