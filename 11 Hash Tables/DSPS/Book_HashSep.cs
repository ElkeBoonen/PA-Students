namespace DSPS
{
    internal class Book_HashSep
    {
        private int v;
        private List<KeyValuePair<string,double>>[] book;

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
        public Book_HashSep(int items)
        {
            //Let M be the next prime larger than 1.3 times the number of keys
            double size = items * 1.3;
            book = new List<KeyValuePair<string, double>>[NextPrime((int)Math.Ceiling(size))];
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
            if (book[index] == null)
            {
                book[index] = new List<KeyValuePair<string, double>>();
            }
            book[index].Add(new KeyValuePair<string,double>(product, price));
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < book.Length; i++)
            {
                s += i + ": ";
                if (book[i] != null)
                {
                    foreach (var item in book[i])
                    {
                        s += item.Key + " " + item.Value + " --> ";
                    }
                }
                s += "\n";
            }
            return s;
        }

        internal double GetPrice(string product)
        {
            int index = HashFunction(product);
            foreach (var item in book[index])
            {
                if (item.Key == product) return item.Value;
            }
            return -1;

        }
    }
}