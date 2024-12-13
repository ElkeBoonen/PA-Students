
using System.Text;
using System.Linq;

namespace ADI_Hashmaps
{
    internal class Book_KVP
    {
        KeyValuePair<string, double>[] book;
        int index;

        public Book_KVP(int items)
        {
            book = new KeyValuePair<string, double>[items];
            index = 0;
        }

        internal void AddItem(string product, double price)
        {
            if (index < book.Length)
            {
                book[index] = new KeyValuePair<string, double>(product, price);
                index++;
            }
        }

        internal string GetPrice(string product)
        {
            foreach (KeyValuePair<string,double> item in book)
            {
                if (item.Key == product) return item.Value.ToString();
            }
            return "not found";
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in book)
            {
                if (!String.IsNullOrEmpty(item.Key))
                    stringBuilder.Append(item.Key + ":" + item.Value + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}