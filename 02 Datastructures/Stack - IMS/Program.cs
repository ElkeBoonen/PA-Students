using System;

namespace Stack___IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            Console.WriteLine(stack.Push("appel"));
            Console.WriteLine(stack.Push("citroen"));
            Console.WriteLine(stack.Push("banaan"));
            Console.WriteLine(stack.Push("mango"));
            Console.WriteLine(stack.Push("peer"));
            Console.WriteLine(stack.Push("citroen"));
            Console.WriteLine(stack.Push("aardbei"));

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


        }
    }
}
