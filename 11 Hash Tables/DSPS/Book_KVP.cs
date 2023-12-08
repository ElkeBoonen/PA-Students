namespace DSPS
{
    internal class Book_KVP
    {
        private KeyValuePair<string, double>[] book;
        private int index = 0;

        public Book_KVP(int items)
        {
            book = new KeyValuePair<string, double>[items];
        }

       

        public void AddItem(string key, double value)
        {
            KeyValuePair<string, double> item = new KeyValuePair<string, double>(key, value);
            book[index] = item;
            index++;
        }

        internal double GetPrice(string v)
        {
            foreach (var item in book)
            {
                if (item.Key == v) return item.Value;
            }
            return -1;
        }

        public override string ToString()
        {
            string s = string.Empty;
            for (int i = 0; i < index; i++)
            {
                s += book[i].Key + ": " + book[i].Value + "\n";
            }
            return s;
        }
    }
}