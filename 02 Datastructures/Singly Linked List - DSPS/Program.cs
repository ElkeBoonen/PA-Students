using System;

namespace Singly_Linked_List___DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL list = new SLL();
            Console.WriteLine(list);
            list.Insert(1);
            Console.WriteLine(list);
            list.Insert(2);
            Console.WriteLine(list);
            list.Insert(3);
            Console.WriteLine(list);
            //list.Delete(1);
            Console.WriteLine(list);
            list.Insert(4);
            Console.WriteLine(list);
            list.Delete(3);
            Console.WriteLine(list);
            list.Delete(1);
            Console.WriteLine(list);
            list.Delete(4);
            Console.WriteLine(list);
            list.Insert(5);
            Console.WriteLine(list);

        }
    }
}
