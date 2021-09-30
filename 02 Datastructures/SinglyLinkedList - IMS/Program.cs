using System;

namespace SinglyLinkedList___IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL lijst = new SLL();

            Console.WriteLine(lijst);

            Node node = new Node(3.14);
            lijst.Insert(node);
            Console.WriteLine(lijst);

            node = new Node(4.14);
            lijst.Insert(node);
            Console.WriteLine(lijst);

            node = new Node(5.14);
            lijst.Insert(node);
            Console.WriteLine(lijst);

            lijst.Delete(3.14);
            Console.WriteLine(lijst);

            lijst.Insert(new Node(2.14));
            Console.WriteLine(lijst);

            lijst.Delete(5.14);
            Console.WriteLine(lijst);

            lijst.Delete(2.14);
            Console.WriteLine(lijst);

            lijst.Insert(new Node(1.14));
            Console.WriteLine(lijst);

        }
    }
}
