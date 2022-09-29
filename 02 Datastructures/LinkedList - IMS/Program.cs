using System;

namespace LinkedList___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.InsertFront("appel");
            list.InsertFront("banaan");
            list.InsertFront("citroen");

            Console.WriteLine(list);

            list.InsertFront("peer");
            list.InsertFront("mango");

            Console.WriteLine(list);

            list.InsertLast("kokosnoot");
            list.InsertLast("papaya");

            Console.WriteLine(list);



        }
    }
}
