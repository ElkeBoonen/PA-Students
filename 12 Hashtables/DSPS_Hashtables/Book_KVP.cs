
namespace DSPS_Hashtables
{
    internal class Book_KVP
    {
        KeyValuePair<string, double>[] book;
        int index = 0;

        public Book_KVP(int nr)
        {
            book = new KeyValuePair<string, double>[nr];
        }

        internal void AddItem(string v1, double v2)
        {
            if (index < book.Length)
            {
                book[index] = new KeyValuePair<string, double>(v1, v2);
                index++;
            }
        }

        internal string GetPrice(string v)
        {
            foreach (KeyValuePair<string, double> kvp in book)
            { 
                if (kvp.Key.Equals(v)) return kvp.Value.ToString();
            }
            return "not found";
        }

        public override string ToString()
        {
            string s = "";
            foreach (KeyValuePair<string, double> kvp in book)
            {
                if (!String.IsNullOrEmpty(kvp.Key)) s += kvp.Key + ": " + kvp.Value + "\n";
            }
            return s;
        }


    }
}