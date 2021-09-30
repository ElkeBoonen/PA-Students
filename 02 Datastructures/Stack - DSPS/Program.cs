using System;

namespace Stack___DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            stack.Push('d');
            stack.Push('e');
            stack.Push('f');
            stack.Push('g');
            Console.WriteLine(stack);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack);
            stack.Push('h');
            Console.WriteLine(stack);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
        }
    }
}
