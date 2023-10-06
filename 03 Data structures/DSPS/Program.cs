namespace DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine(list);

            list.Insert(new Node(10));
            list.Insert(new Node(267));
            list.Insert(new Node(7));
            list.Insert(new Node(-56));
            Console.WriteLine(list);

            Console.WriteLine($"Search 10 {list.Search(10)}");
            Console.WriteLine($"Search -56 {list.Search(-56)}");
            Console.WriteLine($"Search 100 {list.Search(100)}");

            list.Delete(10);
            Console.WriteLine(list);

            list.Delete(7);
            Console.WriteLine(list);

            list.Delete(-56);
            Console.WriteLine(list);

            list.Delete(267);
            Console.WriteLine(list);

            list.Insert(new Node(77));
            Console.WriteLine(list);

            try
            {
                Stack stack = new Stack(3);
                Console.WriteLine(stack);

                stack.Push("3");
                Console.WriteLine(stack);
                stack.Push("test");
                Console.WriteLine(stack);
                stack.Push("blue");
                Console.WriteLine(stack);
                //stack.Push("another");
                //Console.WriteLine(stack);

                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack);
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack);
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack);
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack);
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }

        }
    }
}