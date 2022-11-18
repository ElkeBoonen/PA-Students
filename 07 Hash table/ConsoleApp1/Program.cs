using System;

namespace Hashtable_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Book_KVP book = new Book_KVP(20);
            book.AddItem("apple", 0.67);
            book.AddItem("pear", 0.78);
            book.AddItem("eggs", 2.49);
            book.AddItem("milk", 1.49);
            book.AddItem("avocado", 1.49);
            Console.WriteLine(book);
            Console.WriteLine(book.GetPrice("eggs"));*/

            Book_Hash_SC book = new Book_Hash_SC(6);
            book.AddItem("apple", 0.67);
            book.AddItem("pear", 0.78);
            book.AddItem("eggs", 2.49);
            book.AddItem("milk", 1.49);
            book.AddItem("avocado", 1.49);
            book.AddItem("oranges", 1.50);
            Console.WriteLine(book);
            Console.WriteLine(book.GetPrice("eggs"));



        }
    }
}
