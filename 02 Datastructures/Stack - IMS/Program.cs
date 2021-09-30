using System;

namespace Stack___IMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            stack.Push(5);
            Console.WriteLine(stack);
            stack.Push(6);
            Console.WriteLine(stack);
            stack.Push(7);
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
            stack.Pop();
            Console.WriteLine(stack);
        }
    }
}
