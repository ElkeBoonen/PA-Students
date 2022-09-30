using System;

namespace Datastructures___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine(list.Delete("apple"));

            list.InsertLast("lime");
            Console.WriteLine(list);

            list.InsertFront("apple");
            list.InsertFront("banana");
            list.InsertFront("lemon");

            //Console.WriteLine(list.ToString());
            Console.WriteLine(list);

            list.InsertLast("strawberry");
            Console.WriteLine(list);

            Console.WriteLine(list.Delete("apple"));
            Console.WriteLine(list.Delete("strawberry"));
            Console.WriteLine(list.Delete("lemon"));

            list.InsertFront("apple");
            Console.WriteLine(list);
            list.InsertLast("apple");
            Console.WriteLine(list);

            Console.WriteLine(list.Delete("apple"));

            Console.WriteLine("\n\n\n");


        }
    }
}
