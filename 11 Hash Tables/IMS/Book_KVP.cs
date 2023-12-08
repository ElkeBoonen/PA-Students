namespace IMS
{
    internal class Book_KVP
    {
        private KeyValuePair<string, double>[] book;
        int index;

        public Book_KVP(int size)
        {
            book = new KeyValuePair<string, double>[size];
            index = 0;
        }

        internal void AddItem(string v1, double v2)
        {
            book[index] = new KeyValuePair<string, double>(v1, v2);
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
            string s = "";
            foreach (var item in book)
            {
                s += item.Key + " - " + item.Value + "\n";
            }
            return s;
        }
    }
}