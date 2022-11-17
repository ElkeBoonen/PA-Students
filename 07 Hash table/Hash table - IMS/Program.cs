using System;

namespace Hash_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Book_KVP book = new Book_KVP(5);
            book.AddItem("apple", 0.67);
            book.AddItem("pear", 0.79);
            book.AddItem("eggs", 2.49);
            book.AddItem("milk", 1.49);
            book.AddItem("avocado", 1.49);
            Console.WriteLine(book.ToString());
            Console.WriteLine("Price of eggs: " + book.GetPrice("eggs"));
            */

            Book_Hash book = new Book_Hash(5);
            book.AddItem("apple", 0.67);
            book.AddItem("pear", 0.79);
            book.AddItem("eggs", 2.49);
            book.AddItem("milk", 1.49);
            book.AddItem("avocado", 1.49);
            Console.WriteLine(book.ToString());
            Console.WriteLine("Price of eggs: " + book.GetPrice("eggs"));
        }
    }
}
