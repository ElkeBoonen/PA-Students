using System;

namespace Datastructures___DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.InsertFront("apple");
            list.InsertFront("banana");
            list.InsertFront("lemon");

            Console.WriteLine(list);
        }
    }
}
