
namespace DSPS_Hashtables
{
    internal class Book_Hash
    {
        double[] book;

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

        public Book_Hash(int items)
        {
            int size = NextPrime(Convert.ToInt32(items * 1.3));
            book = new double[size];
        }

        internal void AddItem(string product, double price)
        {
            int index = HashFunction(product);
            Console.WriteLine(index + " " + product + " " + price); 
            book[index] = price;
        }

        private int HashFunction(string product)
        {
            /*int sum = 0;
            foreach (char c in product)
            { 
                sum += (int)c;
            }
            return sum % book.Length;*/

            
            long h = 0;
            foreach (char c in product)
            {
                h = (31 * h) + (int)c;
            }
            return (int)(h % book.Length);
            
        }

        public override string ToString()
        {
            return String.Join("\n", book);
        }

        internal double GetPrice(string product)
        {
            return book[HashFunction(product)];
        }
    }
}