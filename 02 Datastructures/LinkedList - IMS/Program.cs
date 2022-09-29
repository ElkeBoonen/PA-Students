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

            Console.WriteLine("mango: " + list.Search("mango"));
            Console.WriteLine("papaya: " + list.Search("papaya"));
            Console.WriteLine("citroen: " + list.Search("citroen"));
            Console.WriteLine("aardbei: " + list.Search("aardbei"));

            Console.WriteLine(list.Delete("citroen"));
            Console.WriteLine(list.Delete("banaan"));
            Console.WriteLine(list.Delete("mango"));
            Console.WriteLine(list.Delete("papaya"));
            Console.WriteLine(list.Delete("aardbei"));

            list.InsertLast("aardbei");
            Console.WriteLine(list);
            list.InsertLast("druif");
            Console.WriteLine(list);


        }
    }
}
